namespace ArslanElArabaları.Models
{
    public class PostEditModel
    {
        public int PostId { get; set; }
        public string? PostTitle { get; set; }
        public string PictureURL { get; set; }
        public IFormFile Picture { get; set; }
        public DateTime PostCreateDate { get; set; }
        public bool? PostStatus { get; set; }
    }
}
