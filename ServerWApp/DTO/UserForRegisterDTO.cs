using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerWApp.DTO
{
    public class UserForRegisterDTO
    {
        public string? UserName {get; set;}
        public string? Name{get;set;}
        public string? Email {get; set;}
        public string? PasswordHash {get;set;} 
    }
}