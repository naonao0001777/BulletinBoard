﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TwitterDemo.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public int AccountType { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}