namespace CourseWork.Model;

public class Genre
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return Name;
    }
}