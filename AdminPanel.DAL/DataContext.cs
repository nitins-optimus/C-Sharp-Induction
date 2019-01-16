using AdminPanel.DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdminPanel.DAL
{
    public class DataContext
    {
        private List<Panel> _panels;
        private List<Device> _devices;
        private List<Control> _controls;
        private List<Connection> _connections;


        public List<Panel> Panels { get { return _panels; } }
        public List<Device> Devices { get { return _devices;  } }
        public List<Control> Controls { get { return _controls; } }
        public List<Connection> Connections { get { return _connections; } }

        public DataContext()
        {
            LoadData();
        }

        private void LoadData()
        {
            string panelPath = @"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\Panels.json";
            string devicesPath = @"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\Devices.json";
            string controlPath = @"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\Panels.json";
            string connectionsPath = @"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\Connections.json";

            string panels;
            string devices;
            string controls;
            string connections;

            try
            {
                panels = File.ReadAllText(panelPath);
                devices = File.ReadAllText(devicesPath);
                controls = File.ReadAllText(controlPath);
                connections = File.ReadAllText(connectionsPath);

                _panels = JsonConvert.DeserializeObject<List<Panel>>(panels);
                _devices = JsonConvert.DeserializeObject<List<Device>>(devices);
                _controls = JsonConvert.DeserializeObject<List<Control>>(controls);
                _connections = JsonConvert.DeserializeObject<List<Connection>>(connections);

                foreach(var p in _panels)
                {
                    p.Controls = _controls.FindAll(c => c.PanelId == p.Id);
                    p.Devices = _devices.FindAll(d => d.PanelId == p.Id);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        
    }
}
