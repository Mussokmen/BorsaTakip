﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BorsaTakip.MVC.Models
{
	public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

