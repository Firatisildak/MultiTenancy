namespace MultiTenancy.Contract
{
    public interface IMustHaveTenant
    {
        public string TenantId { get; set; }
    }
}
