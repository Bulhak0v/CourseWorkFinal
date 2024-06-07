namespace CourseWork.Model;

public class Playlist
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Movie> Movies { get; set; }
}