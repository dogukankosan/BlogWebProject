using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
	public class NewsLetter
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int NewsLetterID { get; set; }
		[MaxLength(50)]	
		public required string Mail { get; set; }
		public bool MailStatus { get; set; } = true;
	}
}