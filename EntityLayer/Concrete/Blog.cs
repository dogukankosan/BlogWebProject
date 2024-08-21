using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogID { get; set; }
        [MaxLength(50)]
        public required string BlogTitle { get; set; }
        [MaxLength(250)]
        public required string BlogContent { get; set; }
        [MaxLength(250)]
        public required string BlogSmallImage { get; set; }
        [MaxLength(250)]
        public required string BlogBigImage { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool BlogStatus { get; set; } = false;
        public byte CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int WriterID{ get; set; }
        public Writer Writer { get; set; }
    }
}