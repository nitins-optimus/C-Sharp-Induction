using System.Collections.Generic;

namespace AdminPanel.DAL.Model
{
    public class Panel
    {
        public Panel()
        {
            Devices = new List<Device>();
            Controls = new List<Control>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Device> Devices { get; set; }
        public List<Control> Controls { get; set; }
    }
}
