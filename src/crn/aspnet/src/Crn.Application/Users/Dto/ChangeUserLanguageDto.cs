using System.ComponentModel.DataAnnotations;

namespace Crn.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}