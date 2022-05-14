namespace Movies;
// POCO Objects - Plain Old CSharp Objects
// A POCO object is a class that is designed to represent a database table.



public class Movie
{
    public long Id { get; set;}
    public string Title { get; set; }
    public Genre Genre {get;set;}
    public Original_Language OriginalLanguage { get; set; }
    public string Overview { get; set; }
    public long Popularity {get;set;}
    public List<Production_Companies> ProductionCompanies { get; set; }   
    public DateTime ReleaseDate { get; set; }
    public decimal Budget { get; set; }
    public decimal Revenue { get; set; }
    public int Runtime { get; set; }
    public Status Status { get; set; }
    public String Tagline { get; set; }
    public decimal VoteAverage { get; set; }
    public decimal VoteCount { get; set; }
}
