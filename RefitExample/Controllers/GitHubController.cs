using Microsoft.AspNetCore.Mvc;

namespace RefitExample.Controllers
{
    [Route("api/[controller]")]
    public class GitHubController : Controller
    {
        public readonly IGitHubApi _gitHubApi;
        public GitHubController(IGitHubApi gitHubApi)
        {
            _gitHubApi = gitHubApi;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUser(string username)
        {
            try
            {
                var user = await _gitHubApi.GetUserAsync(username);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
