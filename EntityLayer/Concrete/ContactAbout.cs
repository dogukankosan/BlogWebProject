using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
	public class ContactAbout
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ContactAboutID { get; set; }
		[MaxLength(500)]
		public required string IFrameLocation { get; set; }
		[MaxLength(100)]
		public required string Address { get; set; }
		[MaxLength(12)]
		public required string Phone { get; set; }
		[MaxLength(50)]
		public required string Mail { get; set; }
	}
}