using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class SavedPost : BaseDatabase
    {
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User? User { get; set; }

        public int IdPost { get; set; }
        [ForeignKey("IdPost")]
        public virtual Post? Post { get; set; }
    }
}
