using AutoMapper;
using DatabaseFirstExample.Application.CustomMapper.MapperHelper;
using DatabaseFirstExample.Application.Dtos;
using DatabaseFirstExample.Domain.Entities;

namespace DatabaseFirstExample.Application.CustomMapper
{
    public class DepartmentMapper : Profile
    {
        public DepartmentMapper()
        {
            CreateMap<Department, DeparmentCreateDto>().ReverseMap();
            CreateMap<Department, DepartmentDataDto>().ReverseMap();
            CreateMap<DepartmentUpdateDto, Department>().MapUpdate();
        }
    }
}
