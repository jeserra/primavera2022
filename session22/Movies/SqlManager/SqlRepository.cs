using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Movies.SqlManager
{
    public class SqlRepository: IRepository
    {
        private SqlConnectionStringBuilder sqlConnectionStringBuilder
        {
            get
            {
                return new SqlConnectionStringBuilder()
                {
                    DataSource = @"localhost\SQLExpress",
                    IntegratedSecurity = true,
                    InitialCatalog = "Movies"
                };
            }
        }

        
        public List<Movie> GetAll()
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                 
                connection.Open();
                String sql = "SELECT id, title, original_language FROM Movies2";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie()
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                //OriginalLanguage =  reader.GetString(2)
                            }) ;                            
                        }
                    }
                }
            }

            return movies;
        }

        public List<Movie> GetMovieByName(string title)
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();

                String sql = "SELECT id, title, original_language FROM Movies2 where title like @title";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    SqlParameter titleParam = new SqlParameter("@title",  System.Data.SqlDbType.VarChar );
                    titleParam.Value =  "%" +  title + "%";
                    titleParam.Direction = System.Data.ParameterDirection.Input;
                    command.Parameters.Add(titleParam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie()
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                //OriginalLanguage =  reader.GetString(2)
                            });
                        }
                    }
                }
            }

            return movies;
        }

        public long Create(Movie movie)
        {

            
                /* 
                 *    + " , @credits "
                            + " , @keywords "
                            + " , @poster_path "
                            + " , @backdrop_path "
                            + " , @recommendations )";*/
            try
            {


                using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
                {

                    connection.Open();
                    var SqlCreate = "Insert into movies2 (id "
                            + ",title"
                            + ",genres"
                            + ", original_language"
                            + ", overview"
                            + ", popularity"
                            + ", production_companies"
                            + ", release_date "
                            + ", budget "
                            + ", revenue "
                            + ", runtime "
                            + ", status"
                            + ", tagline "
                            + ", vote_average"
                            + ", vote_count"
                            /* + ", credits"
                             + ", keywords"
                             + " , poster_path"
                             + " , backdrop_path"
                             + " , recommendations */ +" )"
                            + " Values ( "
                            + " @id "
                            + " , @title"
                            + " , @genres"
                            + " , @original_language "
                            + " , @overview "
                            + " , @popularity "
                            + " , @production_companies"
                            + " , @release_date"
                            + " , @budget "
                            + " , @revenue "
                            + " , @runtime "
                            + " , @status "
                            + " , @tagline "
                            + " , @vote_average "
                            + " , @vote_count) ";
                            //+ " , @credits )";


                    SqlCommand sqlCommand = new SqlCommand(SqlCreate, connection);

                    sqlCommand.Parameters.Add( new SqlParameter("@id", movie.Id));

                    sqlCommand.Parameters.Add(new SqlParameter("@title", movie.Title));
                    sqlCommand.Parameters.Add(new SqlParameter("@genres", movie.Genre));
                    sqlCommand.Parameters.Add(new SqlParameter("@original_language", movie.OriginalLanguage));
                    sqlCommand.Parameters.Add(new SqlParameter("@overview", movie.Overview));
                    sqlCommand.Parameters.Add(new SqlParameter("@popularity", movie.Popularity));
                    sqlCommand.Parameters.Add(new SqlParameter("@production_companies", String.Join(" ", movie.ProductionCompanies)));
                    sqlCommand.Parameters.Add(new SqlParameter("@release_date", movie.ReleaseDate));
                    sqlCommand.Parameters.Add(new SqlParameter("@budget", movie.Budget));
                    sqlCommand.Parameters.Add(new SqlParameter("@revenue", movie.Revenue));
                    sqlCommand.Parameters.Add(new SqlParameter("@runtime", movie.Runtime));
                    sqlCommand.Parameters.Add(new SqlParameter("@status", movie.Status));
                    sqlCommand.Parameters.Add(new SqlParameter("@tagline", movie.Tagline));
                    sqlCommand.Parameters.Add(new SqlParameter("@vote_average", movie.VoteAverage));
                    sqlCommand.Parameters.Add(new SqlParameter("@vote_count", movie.VoteCount));
                     
                    sqlCommand.ExecuteNonQuery();
                    return movie.Id;

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}

