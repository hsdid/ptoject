using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Comment : BaseDatabase
    {
        public string? Text { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User? User { get; set; }

        public int IdPost { get; set; }
        [ForeignKey("IdPost")]
        public virtual Post? Post { get; set; }
    }
}
