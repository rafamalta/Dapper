using BlogDapper.Models;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        private readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection) 
            : base(connection)        
            => _connection = connection;        
    }
}
