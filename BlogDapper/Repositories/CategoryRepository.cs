using BlogDapper.Models;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;
        public CategoryRepository(SqlConnection connection)
            : base(connection)
            => _connection = connection;        
    }
}
