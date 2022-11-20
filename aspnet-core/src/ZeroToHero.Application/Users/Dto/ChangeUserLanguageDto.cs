using System.ComponentModel.DataAnnotations;

namespace ZeroToHero.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}