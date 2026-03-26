using AutoMapper;
using backend.DTOs;
using backend.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace backend.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentResponseDTO>();
            CreateMap<StudentCreateDTO, Student>();
        }
    }
}