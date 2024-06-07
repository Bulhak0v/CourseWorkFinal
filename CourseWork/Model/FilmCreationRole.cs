using System.Reflection;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork.Model;

public class FilmCreationRole
{
    
    public Artist Artist { get; set; }
    [JsonIgnore]
    public Movie Movie { get; set; }
    public RoleName RoleName { get; set; }
    public string ArtistName
    {
        get { return Artist.Name; }
    }
}