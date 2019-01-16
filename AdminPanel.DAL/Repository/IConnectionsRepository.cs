using System.Collections.Generic;
using AdminPanel.DAL.Model;

namespace AdminPanel.DAL.Repository
{
    public interface IConnectionsRepository
    {
        List<Connection> GetAllConnections();
    }
}