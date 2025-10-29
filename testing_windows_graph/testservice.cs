using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace testing_windows_graph
{
    internal class testservice
    {
        private static readonly string[] Scopes = { "Files.ReadWrite.All", "Sites.Read.All" };

        internal static async Task<bool> Main(string cID, string dPath, string fPath)
        {
            // Initialize public client app
            var publicClientApp = PublicClientApplicationBuilder.Create(cID)
                .WithAuthority(AzureCloudInstance.AzurePublic, AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount)
                .WithRedirectUri("http://localhost") // Required for interactive login
                .Build();

            // Acquire token interactively
            AuthenticationResult authResult = null;
            var accounts = await publicClientApp.GetAccountsAsync();
            try
            {
                authResult = await publicClientApp.AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
                                                 .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                authResult = await publicClientApp.AcquireTokenInteractive(Scopes)
                                                  .ExecuteAsync();
            }

            if (authResult != null)
            {
                var graphClient = new GraphServiceClient(new DelegateAuthenticationProvider(
                    requestMessage =>
                    {
                        requestMessage.Headers.Authorization =
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authResult.AccessToken);
                        return Task.CompletedTask;
                    }));

                try
                {
                    // Get file content
                    var fileStream = await graphClient.Sites[dPath]
                                                      .Drive.Root.ItemWithPath(fPath)
                                                      .Content
                                                      .Request()
                                                      .GetAsync();

                    using (var file = new FileStream("Downloaded_Example.xlsx", FileMode.Create, FileAccess.Write))
                    {
                        await fileStream.CopyToAsync(file);
                    }
                    Console.WriteLine("Excel file downloaded successfully.");
                    return true;
                }
                catch (ServiceException ex)
                {
                    Console.WriteLine($"Error accessing SharePoint file: {ex.Message}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Authentication failed.");
                return false;
            }
        }
    }
}
