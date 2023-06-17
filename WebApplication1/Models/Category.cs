namespace WebApplication1.Models
{
    public class Category : BaseDatabase
    {
        public string? Name { get; set; }

        public virtual ICollection<Post>? Posts { get; set;}
    }
}
