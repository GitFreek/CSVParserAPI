using CSVParserAPI;
using CSVParserAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSVParserAPIController
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ICSVService _csvService;

        public UserController(ICSVService csvService)
        {
            _csvService = csvService;
        }

        [HttpPost("read-user-csv")]
        public async Task<IActionResult> GetUsersCSV([FromForm] IFormFileCollection file)
        {
            var users = _csvService.ReadCSV<Users>(file[0].OpenReadStream());

            return Ok(users);
        }
    }
}

