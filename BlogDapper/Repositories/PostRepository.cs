using BlogDapper.Models;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection)
            : base(connection)
            => _connection = connection;        
    }
}
