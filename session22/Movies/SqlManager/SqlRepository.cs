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
    }
}
