using System.ComponentModel.DataAnnotations;

namespace AtlasNetwork.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Gİriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Gİriniz")]
        public string Password { get; set; }

    }
}
