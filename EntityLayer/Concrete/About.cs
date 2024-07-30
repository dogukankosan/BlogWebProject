using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AboutID { get; set; }
        [MaxLength(100)]
        public required string AboutDetails1 { get; set; }
        [MaxLength(100)]
        public required string AboutDetails2 { get; set; }
        [MaxLength(250)]
        public required string AboutImage1 { get; set; }
        [MaxLength(250)]
        public required string AboutImage2 { get; set; }
        [MaxLength(500)]
        public required string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; } = false;
    }
}