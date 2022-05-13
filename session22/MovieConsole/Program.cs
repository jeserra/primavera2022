using Movies;

Movie movie = new Movie();
movie.Id = 1;
movie.Title = "The Shawshank Redemption";
movie.Genre = Genre.Action|Genre.Science|Genre.Fiction;
movie.OriginalLanguage = Original_Language.en;
movie.Overview = "Two imprisoned triying to escape from prision";

Console.WriteLine("{0}", movie.Title);
Console.WriteLine("{0}", movie.Genre);
Console.WriteLine("{0}", movie.OriginalLanguage);
Console.WriteLine("{0}", movie.Overview);

 