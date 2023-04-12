using BlogDapper.Models;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;

        public TagRepository(SqlConnection connection) 
            : base(connection)        
            => _connection = connection;        
    }
}
