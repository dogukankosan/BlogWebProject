using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SocialMediaID { get; set; }
        [MaxLength(150)]
        public required string FacebookLink { get; set; }
        [MaxLength(150)]
        public required string GithubLink { get; set; }
        [MaxLength(150)]
        public required string GoogleLink { get; set; }
        [MaxLength(150)]
        public required string InstagramLink { get; set; }
    }
}