using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WriterID { get; set; }
        [MaxLength(50)]
        public required string WriterName { get; set; }
        [MaxLength(250)]
        public required string WriterAbout { get; set; }
        [MaxLength(50)]
        //todo bunu ayarla [Index(IsUnique = true)]
        public required string WriterMail { get; set; }
        [MaxLength(50)]
        public required string WriterPassword { get; set; }
        [MaxLength(250)]
        public required string WriterImage { get; set; }
        public bool WriterStatus { get; set; } = false;
    }
}