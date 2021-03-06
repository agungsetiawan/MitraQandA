﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MitraQandA.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnline { get; set; }
        public virtual List<Role> Roles { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}