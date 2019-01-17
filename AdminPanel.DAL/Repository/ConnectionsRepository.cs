using AdminPanel.DAL.Model;
using System.Collections.Generic;

namespace AdminPanel.DAL.Repository
{
    public class ConnectionsRepository : IConnectionsRepository
    {
        private DataContext _context;

        public ConnectionsRepository()
        {
            _context = new DataContext();
        }

        public List<Connection> GetAllConnections()
        {
            return _context.Connections;
        }
    }
}
