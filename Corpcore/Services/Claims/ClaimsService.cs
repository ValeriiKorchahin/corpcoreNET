using Corpcore.Utils.Error;

namespace Corpcore.Services.Claims
{
    public class ClaimsService(IHttpContextAccessor _httpContext): IClaimsService
    {
        public Guid GetOrganizationId() 
        {
            var claim = _httpContext.HttpContext.User.FindFirst("organizationId").Value;

            if (string.IsNullOrEmpty(claim)) 
            {
                throw new RestException(System.Net.HttpStatusCode.Unauthorized, "OrganizationId is missing in claim");
            }

            return Guid.Parse(claim);
        }

        public Guid GetUserId()
        {
            var claim = _httpContext.HttpContext.User.FindFirst("userId").Value;

            if (string.IsNullOrEmpty(claim))
            {
                throw new RestException(System.Net.HttpStatusCode.Unauthorized, "UserId is missing in claim");
            }

            return Guid.Parse(claim);
        }

        public string GetUserRole()
        {
            var claim = _httpContext.HttpContext.User.FindFirst("role").Value;

            if (string.IsNullOrEmpty(claim))
            {
                throw new RestException(System.Net.HttpStatusCode.Unauthorized, "Role is missing in claim");
            }

            return claim;
        }
    }
}
