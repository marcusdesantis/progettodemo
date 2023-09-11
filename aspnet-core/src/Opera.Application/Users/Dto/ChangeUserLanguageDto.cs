using System.ComponentModel.DataAnnotations;

namespace Opera.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}