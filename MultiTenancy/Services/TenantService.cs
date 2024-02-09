
using Microsoft.Extensions.Options;

namespace MultiTenancy.Services
{
    public class TenantService : ITenantService
    {
        private readonly TenantSettings _tenantSettings;
        private HttpContext? _httpContext;
        private Tenant? _currentTenant;
        public TenantService(IHttpContextAccessor contextAccessor, IOptions<TenantSettings> tenantSettings)
        {
            _httpContext=contextAccessor.HttpContext;
            _tenantSettings = tenantSettings.Value;
            if (_httpContext is not null)
            {
                if (_httpContext.Request.Headers.TryGetValue(key: "tenant", out var tenantId))
                {
                    SetCurrentTenant(tenantId!);
                }
                else
                {
                    throw new Exception(message: "No tenant provided!");
                }
            }
        }
        public string? GetConnectionString()
        {
            var currentConnectionsString = _currentTenant is null ? _tenantSettings.Defaults.ConnectionString : _currentTenant.ConnectionString;

            return currentConnectionsString;
        }

        public Tenant? GetCurrentTenant()
        {
            return _currentTenant;
        }

        public string? GetDatabaseProvider()
        {
            return _tenantSettings.Defaults.DBProvider;
        }

        private void SetCurrentTenant(string tenantId)
        {
            _currentTenant = _tenantSettings.Tenants.FirstOrDefault(t => t.TId == tenantId);

            if (_currentTenant is null)
            {
                throw new Exception(message: "Invalid tenant ID");
            }
            if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
            {
                _currentTenant.ConnectionString = _tenantSettings.Defaults.ConnectionString;
            }
        }
    }
}
