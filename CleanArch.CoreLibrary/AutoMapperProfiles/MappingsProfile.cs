using AutoMapper;
using CleanArch.CoreLibrary.Dtos;
using CleanArch.CoreLibrary.Models;
using CleanArch.CoreLibrary.ViewModels;

namespace CleanArch.CoreLibrary.AutoMapperProfiles
{
    public class MappingsProfile:Profile
    {
        public override string ProfileName => "MappingsProfile";

        public MappingsProfile()
        {
            CreateMap<Student, Student>();

            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

            CreateMap<Student, StudentViewModel>();
            CreateMap<StudentViewModel, Student>();
        }
    }
}