﻿using Microsoft.AspNetCore.Http;

namespace core_proje.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureURL { get; set; }
        public IFormFile Picture { get; set; }
    }
}
