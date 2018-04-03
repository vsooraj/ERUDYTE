using System.ComponentModel.DataAnnotations;

namespace Erudyte.CMS.ViewModels
{
    public class LoginViewModel
    {
        public string Title { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
