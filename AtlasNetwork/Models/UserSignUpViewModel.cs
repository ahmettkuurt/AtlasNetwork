﻿using System.ComponentModel.DataAnnotations;

namespace AtlasNetwork.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required (ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
        public string username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
        public string Mail { get; set; }
    }
}
