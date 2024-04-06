using AutoMapper;
using DatabaseFirstExample.Application.CustomMapper.MapperHelper;
using DatabaseFirstExample.Application.Dtos;
using DatabaseFirstExample.Domain.Entities;

namespace DatabaseFirstExample.Application.CustomMapper
{
    public class GradeMapper : Profile
    {
        public GradeMapper()
        {
            CreateMap<Grade, GradeCreateDto>().ReverseMap();
            CreateMap<Grade, GradeDataDto>()
                .ForMember(d => d.DepartmentName, o => o.MapFrom((src, dst) => src.Department.Name))
                .ReverseMap();
            CreateMap<GradeUpdateDto, Grade>().MapUpdate();
        }
    }
}
