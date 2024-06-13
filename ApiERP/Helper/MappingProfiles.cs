using AutoMapper;
using DAL.Dtos;
using DAL.Models;

namespace ApiERP.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<HrEmployeeDto, HrEmployee>();
        }
    }
}
