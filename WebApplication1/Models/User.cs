namespace WebApplication1.Models
{
    public class User : BaseDatabase
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public virtual ICollection<Post>? Posts { get; set; }

        public virtual ICollection<Comment>? Comments{ get; set; }

        public virtual ICollection<SavedPost>? SavedPosts { get; set; }
    }
}
