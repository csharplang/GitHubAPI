using System;
using Octokit;

namespace GitHubAPIClientlibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Github github =new Github();
            github.GetInfo();
            Console.ReadKey();

        }
    }
}
