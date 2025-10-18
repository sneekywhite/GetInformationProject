using HngWebApiProject.Dtos;
using HngWebApiProject.Interface;

namespace HngWebApiProject.Service
{
    public class GetInformationService : IGetInformationService
    {
        public async Task<PersonalInfoDto> GetMyInformation()
        {
            string fact = string.Empty;

            var response = new PersonalInfoDto();
            try
            {
                var resobj = await FetchCatchAsyncService.FetchCatchAsync();

                if (resobj != null) 
                {
                     fact = resobj;
                }
                response.status = "success";
                response.user = new User
                {
                    name = "OKOH EMMANUEL",
                    email = "okoh.onyeka123@gmail.com",
                    stack = ".Net and Fastapi"
                };
               
                response.timestamp = DateTime.UtcNow.ToString("o");
                response.fact = fact;
            }
            catch
            {
                response.status = "failure";
            }

            return response;
        }
    }
}
