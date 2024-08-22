using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public DbSet<About> Abouts { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<ContactAbout> ContactAbouts { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=BlogDB;Integrated Security=true;TrustServerCertificate=true");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<ContactAbout>().HasData(
				new ContactAbout
				{
					ContactAboutID = 1,
					Address = "Silivri,İstanbul",
					Mail = "dogukandevp@gmail.com",
					Phone = "905455111134",
					IFrameLocation = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192502.9383590522!2d28.03599348690269!3d41.07208749327083!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14b53fdbc4bfe901%3A0x6f637ffe39da55b6!2sSilivri%2C%20%C4%B0stanbul!5e0!3m2!1str!2str!4v1724266980119!5m2!1str!2str"
				}
			);
			modelBuilder.Entity<SocialMedia>().HasData(
				new SocialMedia
				{
					SocialMediaID = 1,
					FacebookLink = "https://tr-tr.facebook.com/people/Do%C4%9Fukan-Ko%C5%9Fan/pfbid0QFcRA34xX6CGRSAMhyekwT7dbEsvuqxbsUDXK6kjrwM3BP7HWKfNuB7vAPmb1Avfl/",
					GithubLink = "https://github.com/dogukankosan",
					GoogleLink = "dogukandevp@gmail.com",
					InstagramLink = "https://www.instagram.com/dogukankosan/",
				}
			);
			modelBuilder.Entity<About>().HasData(
				new About
				{
					AboutID = 1,
					AboutDetails1 = "Her konuya hitap eden bloglarımızla bilgi dolu bir yolculuğa çıkın! İlham verici makaleler ve pratik tavsiyelerle dolu sitemizde aradığınız her şeyi bulacaksınız.",
					AboutDetails2 = "Her yaşa, ilgi alanına ve ihtiyaca yönelik zengin içeriklerle dolu bloglarımız, bilgiye ulaşmanın en keyifli yolunu sunuyor. Gündelik yaşamdan teknolojiye, sağlıktan seyahate kadar geniş yelpazede ele aldığımız konularla, hem öğrenirken hem de eğleneceksiniz. Uzman yazarlarımızın kaleminden çıkan güncel ve özgün makalelerle hayatınıza değer katın. Sitemizde yer alan pratik tavsiyeler, ilham dolu fikirler ve derinlemesine analizlerle bilginin gücünü keşfedin!",
					AboutImage1 = "https://img.freepik.com/free-vector/blogging-fun-content-creation-online-streaming-video-blog-young-girl-making-selfie-social-network-sharing-feedback-self-promotion-strategy-vector-isolated-concept-metaphor-illustration_335657-855.jpg",
					AboutImage2 = "https://techstory.in/wp-content/uploads/2022/11/Blogging.jpg"
				}
			);
		}
	}
}