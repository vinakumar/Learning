using Refit;

namespace RefitExample
{
    public interface IGitHubApi
    {
        [Get("/users/{username}")]
        Task<GitHubUser> GetUserAsync(string username);
    }
}
