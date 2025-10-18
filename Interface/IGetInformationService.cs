using HngWebApiProject.Dtos;

namespace HngWebApiProject.Interface
{
    public interface IGetInformationService
    {
        Task<PersonalInfoDto> GetMyInformation();
      
    }
}
