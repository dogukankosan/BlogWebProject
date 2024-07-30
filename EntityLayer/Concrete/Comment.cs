using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        [MaxLength(50)]
        public required string CommentUserName { get; set; }
        [MaxLength(50)]
        public required string CommentTitle { get; set; }
        [MaxLength(500)]
        public required string CommentContent { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool CommentStatus { get; set; } = false;
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}