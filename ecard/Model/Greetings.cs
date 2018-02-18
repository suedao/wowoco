using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("Your friend's name")]
        public string friendsname { get; set; }

        [DisplayName("Your friend's email")]
        public string friendsemail { get; set; }

        [DisplayName("Email Subject")]
        public string subject { get; set; }

        [DisplayName("Your Custom Message")]
        public string message { get; set; }

        [DisplayName("Your name")]
        public string sendersname { get; set; }

        [DisplayName("Your email")]
        public string sendersemail { get; set; }
    }
}
