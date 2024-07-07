using AutoMapper;
using TodoUsingMVC.Models;
using TodoUsingMVC.Models.DTOs;

namespace TodoUsingMVC
{
    public class Maper:Profile
    {
        public Maper() 
        { 
            CreateMap<User,LoginDto>().ReverseMap();
            CreateMap<User,RegisterUserDto>().ReverseMap();
        }
    }
}
