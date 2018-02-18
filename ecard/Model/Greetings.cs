using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("Your Friend's Name")]
        [Display(Prompt = "your friend's name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string friendname { get; set; }

        [DisplayName("Your Friend's Email")]
        [Display(Prompt = "your friend's email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string friendemail { get; set; }

        [DisplayName("Email Subject")]
        [Display(Prompt = "email subject")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string subject { get; set; }

        [DisplayName("Your Custom Message")]
        [Display(Prompt = "your custom message")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 150 characters")]
        public string message { get; set; }

        [DisplayName("Your Name")]
        [Display(Prompt = "your name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string sendername { get; set; }

        [DisplayName("Your Email")]
        [Display(Prompt = "your email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string senderemail { get; set; }
    }
}
