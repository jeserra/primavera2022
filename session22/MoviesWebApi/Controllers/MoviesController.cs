using Microsoft.AspNetCore.Mvc;
using Movies;
using Movies.SqlManager;
namespace MoviesWebApi.Controllers;


// http://www.movieswebapi.com/swagger/index.html

// http://www.movieswebapi.com/api/movies

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private readonly IRepository _repository;
    public MoviesController(ILogger<MoviesController> logger)
    {
        _logger = logger;
        _repository = new SqlRepository(); 
        //_repository = new Repository();
        //_repository.LoadFile(@"C:\Users\joser\OneDrive\Documentos\TRSF\Spring 2022\movies.csv");
    }

    [HttpGet]
    [Route("GetMovies")]
    public IEnumerable<Movie> GetMovies()
    {
        return _repository.GetAll();
    }

    [HttpGet]
    [Route("GetMoviesByName")]
    public IEnumerable<Movie> GetMoviesByName(String title)
    {
       // _logger.Log("Leyendo movies por nombre");
        return _repository.GetMovieByName(title);
    }

    [HttpPost]
    [Route("Movies")]
    public long Post([FromBody] Movie movie)
    {
        return _repository.Create(movie);
    }
}