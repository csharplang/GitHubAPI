using System;
using Octokit;

namespace GitHubAPIClientlibrary
{
    public class Github
    {
        public async void GetInfo()
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHubAPIClientlibrary"));
            var user = await github.User.Get("shahedbd");
            Console.WriteLine(user.Followers + " folks love the shahedbd!");
        }
    }
}