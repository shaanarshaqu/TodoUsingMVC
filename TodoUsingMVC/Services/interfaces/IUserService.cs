using TodoUsingMVC.Models.DTOs;

namespace TodoUsingMVC.Services.interfaces
{
    public interface IUserService
    {
        bool LoginUser(LoginDto user);
        bool RegisterUser(RegisterUserDto user);
    }
}
