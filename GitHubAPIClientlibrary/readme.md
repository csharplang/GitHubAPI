# GitHub API Client Library for .NET

### Create C# Console Project: MacOS
> dotnet new sln -n ProjectName </br>
dotnet new console -n ProjectName </br>
dotnet sln ProjectName.sln add ProjectName/ProjectName.csproj

### Run project: MacOS
```bash
$ cd project dir
$ dotnet restore
$ dotnet run 
```


* Main project: https://github.com/octokit/octokit.net
* Install-Package Octokit
* dotnet add package Octokit --version 0.32.0 
* Install-Package Octokit.Reactive

### Code Example
```CSharp
public async void GetInfo()
        {
            var github = new GitHubClient(new ProductHeaderValue("GitHubAPIClientlibrary"));
            var user = await github.User.Get("shahedbd");
            Console.WriteLine(user.Followers + " folks love the shahedbd!");
        }
```