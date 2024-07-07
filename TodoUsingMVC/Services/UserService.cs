using AutoMapper;
using TodoUsingMVC.Data;
using TodoUsingMVC.Models;
using TodoUsingMVC.Models.DTOs;
using TodoUsingMVC.Services.interfaces;

namespace TodoUsingMVC.Services
{
    public class UserService:IUserService
    {
        private readonly TodoContext todoContext;
        private readonly Mapper maper;
        public UserService(TodoContext todoContext, Mapper maper)
        {
            this.todoContext = todoContext;
            this.maper = maper;
        }

        public bool RegisterUser(RegisterUserDto user)
        {
            try
            {
                User newUser = maper.Map<User>(user);
                User IsUserExist = todoContext.Users.FirstOrDefault(u => u.Email == user.Email);
                if (IsUserExist != null)
                {
                    throw new Exception("user already exist");
                }
                todoContext.Users.Add(newUser);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool LoginUser(LoginDto user)
        {
            try
            {
                User IsUserExist = todoContext.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                if (IsUserExist == null)
                {
                    throw new Exception("Incorrect UserName or Password");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
