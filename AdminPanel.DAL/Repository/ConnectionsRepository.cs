using AdminPanel.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
