using HngWebApiProject.Dtos;
using HngWebApiProject.Integration;
using Microsoft.Extensions.Http;
using Newtonsoft.Json;

namespace HngWebApiProject.Service
{
    public class FetchCatchAsyncService
    {
        public static async Task<string> FetchCatchAsync()
        {
           
            var fact = string.Empty;

            try
            {
                var result = await ClientCallIntegration.PostCToclient();

                if (result == null || string.IsNullOrEmpty(result))
                {
                    return null;
                }

                var obj = JsonConvert.DeserializeObject<catFactRequest>(result);

                fact = obj?.fact;
            }
            catch(Exception ex) 
            {
                fact = null;
                
            }

            return fact;
        }
    }
}
