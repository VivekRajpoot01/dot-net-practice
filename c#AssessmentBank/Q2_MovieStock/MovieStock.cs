public class MovieStock
{
    List<Movie> movies = new List<Movie>();

    public void AddMovie(string movieDetails)
    {
        string[] details = movieDetails.Split(',');
        Movie mv = new Movie();
        
        if(details.Length == 4)
        {
            mv.Title = details[0];
            mv.Artist = details[1];
            mv.Genre = details[2];
            mv.Ratings = int.Parse(details[3]);
        }

        movies.Add(mv);
    }

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        List<Movie> lst = new List<Movie>();
        foreach(var mv in movies)
        {
            if(mv.Genre == genre)
            {
                lst.Add(mv);
            }
        }
        return lst;
    }

    public List<Movie> ViewMoviesByRatings()
    {
        //List<Movie> lst = new List<Movie>();

        return movies.OrderBy(m => m.Ratings).ToList();


    }    
        
}