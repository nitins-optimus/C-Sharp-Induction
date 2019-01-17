using AdminPanel.DAL.Model;
using AdminPanel.DAL.Repository;
using System;
using System.Collections.Generic;

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
