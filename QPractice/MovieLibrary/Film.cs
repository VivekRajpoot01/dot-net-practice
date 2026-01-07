using System;

namespace MovieLibrary;

public class Film: IFilm
{
    ///<summary>
    /// Properties of Film Class
    ///</summary>

    public string Title { get; set; }
    public string Director { get; set; }
    public int year{ get; set; }
    
      
}
