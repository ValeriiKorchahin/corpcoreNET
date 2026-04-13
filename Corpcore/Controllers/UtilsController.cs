using Corpcore.Services.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Corpcore.Controllers
{
    [Authorize]
    [Route("api/[controller]/countries")]
    [ApiController]
    public class UtilsController(IUtilsService utilsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            var response = await utilsService.GetCountries();
            return Ok(response);
        }
    }
}
