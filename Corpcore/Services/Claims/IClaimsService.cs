namespace Corpcore.Services.Claims
{
    public interface IClaimsService
    {
        Guid GetOrganizationId();
        Guid GetUserId();
        string GetUserRole();
    }
}
