using AdminPanel.DAL.Model;
using AdminPanel.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.VIewModel
{
    public class ConfigureConnectionsViewModel
    {
        private IConnectionsRepository _repository;

        public List<Connection> Connections
        {
            get;
            private set;
        }

        //Constructor
        public ConfigureConnectionsViewModel()
        {
            _repository = new ConnectionsRepository();
            LoadData();
        }

        private void LoadData()
        {
            Connections = _repository.GetAllConnections();
        }

    }
}
