namespace CourseWork.Model;

public class Movie
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public int Duration { get; set; }
    public Genre Genre{ get; set; }
    public Studio Studio { get; set; }
    public string Description { get; set; }
    public int Score { get; set; }
    public List<FilmCreationRole> Squad { get; set; }

}