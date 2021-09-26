using DotnetFiveBlog.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFiveBlog.Models
{
    public class Post
    {
		public int Id { get; set; }
		public int BlogId { get; set; }
		public string AuthorId { get; set; }

		[Required]
		[StringLength(75, ErrorMessage = "The {0} must be at least {2} and no more than {1} character.")]
		public string Title { get; set; }

		[Required]
		[StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} character.")]
		public string Abstract { get; set; }

		[Required]
		public string Content { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime Created { get; set; } = DateTime.Now;

		[DataType(DataType.DateTime)]
		public DateTime? Updated { get; set; }

		public ReadyStatus ReadyStatus { get; set; }

		public string Slug { get; set; }

		public byte[] ImageDate { get; set; }
		public string ContentType { get; set; }

		[NotMapped]
		public IFormFile Image { get; set; }

		public virtual Blog Blog { get; set; }
		public virtual IdentityUser Author { get; set; }
		public virtual ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
		public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();




	}
}
