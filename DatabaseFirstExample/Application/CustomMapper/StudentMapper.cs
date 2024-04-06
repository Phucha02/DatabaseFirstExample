using AutoMapper;
using DatabaseFirstExample.Application.Dtos;
using DatabaseFirstExample.Domain.Entities;

namespace DatabaseFirstExample.Application.CustomMapper
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<Student, StudentCreateDto>().ReverseMap();
        }
    }
}
