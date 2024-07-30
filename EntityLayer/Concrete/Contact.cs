using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactID { get; set; }
        [MaxLength(50)]
        public required string ContactUserName { get; set; }
        [MaxLength(50)]
        //todo bunu ayarla [Index(IsUnique = true)]
        public required string ContactMail { get; set; }
        [MaxLength(50)]
        public required string ContactSubject { get; set; }
        [MaxLength(500)]
        public required string ContactMessage { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool ContactStatus { get; set; } = true;
    }
}