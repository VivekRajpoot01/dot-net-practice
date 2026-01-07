using System;

namespace MovieLibrary;

public class FilmLibrary: IFilmLibrary
{
    private List<IFilm> _films;

    public void AddFilm(IFilm film)
    {
        _films.Add(film);
    }

    public void RemoveFilm(string title)
    {
        var findFilm = _films.Find(f =>f.Title == title);
        _films.Remove(findFilm);
    }

    public List<IFilm> GetFilms()
    {
        return new List<IFilm>(_films);
    }

    public List<IFilm> SearchFilms(string query)
    {
        return _films.FindAll(f=>f.Title.Contains(query));
    }
    public int GetTotalFilmCount()
    {
        return _films.Count;    
    }
    
     
}
