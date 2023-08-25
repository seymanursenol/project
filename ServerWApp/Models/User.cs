using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ServerWApp.Models
{
    public class User: IdentityUser<int>
    {
        public string? Name{get;set;}
        public string? LastName{get;set;}
        public DateTime Created { get; internal set;}
    }
}