using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Post : BaseDatabase
    {
        public string? Title { get; set; }
        public string? Content { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User? User { get; set; }

        public int IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category? Category { get; set; }

        public virtual ICollection<Comment>? Comments { get; set;}
    }
}
