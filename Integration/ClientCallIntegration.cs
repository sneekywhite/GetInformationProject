using System.Net;

namespace HngWebApiProject.Integration
{
    public class ClientCallIntegration
    {

        public async static Task<string>  PostCToclient()
        {
            string result = string.Empty;
            try
            {
                
                var client = new HttpClient();
                //client.BaseAddress = new Uri("");
                var response = await client.GetAsync("https://catfact.ninja/fact");

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return string.Empty;
                }

                result = await response.Content.ReadAsStringAsync();
                
            }
            catch (Exception e)
            {
                result = string.Empty;
                Console.WriteLine($"internal server error {e.Message}");
            }

            return result;
        }
    }
}
         