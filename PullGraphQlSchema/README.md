# PullGraphQlSchema

## Steps

- Create a new API project
- At the root folder of the project run commands in console
  ```powershell
  dotnet new tool-manifest
  dotnet tool install StrawberryShake.Tools --local
  dotnet add PullGraphQlSchema package StrawberryShake.Transport.Http
  dotnet add PullGraphQlSchema package StrawberryShake.CodeGeneration.CSharp.Analyzers
  dotnet add PullGraphQlSchema package Microsoft.Extensions.DependencyInjection
  dotnet add PullGraphQlSchema package Microsoft.Extensions.Http
  dotnet graphql init https://hc-conference-app.azurewebsites.net/graphql/ -n ConferenceClient -p ./PullGraphQlSchema
  ```
- Create a folder called `ConferenceClient`
- Move `.graphqlrc.json`, `schema.extensions.graphql`, and `schema.graphql` under folder `ConferenceClient`
- Edit `.graphqlrc.json` to look like
  ```json
  {
    "schema": "schema.graphql",
    "documents": "**/*.graphql",
    "extensions": {
      "strawberryShake": {
        "name": "ConferenceClient",
        "namespace": "PullGraphQlSchema.GraphQL",
        "url": "https://hc-conference-app.azurewebsites.net/graphql/",
        "dependencyInjection": true
      }
    }
  }
  ```
- Create a file called `Queries.graphql` and add the following
  ```graphql
  query GetSessions {
    sessions(order: { title: ASC }) {
      nodes {
        title
        startTime
        endTime
        description: abstract
        speakers {
          name
        }
      }
    }
  }
  ```
- Build the project
- Add to `Startup.cs` under the `ConfigureServices` method the below snippet
  ```csharp
  services
      .AddConferenceClient()
      .ConfigureHttpClient(client => client.BaseAddress = new Uri(Configuration.GetConnectionString("ConferenceGraphQLServer")));
  ```
- Add to `appsettings.json` a connection string for the ConferenceGraphQLServer
  ```json
  {
    "ConnectionStrings": {
      "ConferenceGraphQLServer": "https://hc-conference-app.azurewebsites.net/graphql"
    },
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Warning",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    },
    "AllowedHosts": "*"
  }
  ```
- Inject the `IConferenceClient` where GraphQL interactions are required

  ```csharp
  using Microsoft.AspNetCore.Mvc;
  using PullGraphQlSchema.GraphQL;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  namespace PullGraphQlSchema.Controllers
  {
      [ApiController]
      [Route("[controller]")]
      public class ConferenceController : ControllerBase
      {
          private readonly IConferenceClient _conferenceClient;

          public ConferenceController(IConferenceClient conferenceClient)
          {
              _conferenceClient = conferenceClient;
          }

          [HttpGet]
          public async ValueTask<IReadOnlyList<IGetSessions_Sessions_Nodes>?> Get() =>
              (await _conferenceClient.GetSessions.ExecuteAsync().ConfigureAwait(false))
                  .Data?
                  .Sessions?
                  .Nodes;
      }
  }
  ```

## Resources

- https://chillicream.com/docs/strawberryshake/get-started/console/
