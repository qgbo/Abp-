using System.ComponentModel.DataAnnotations;

namespace qgb48.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}