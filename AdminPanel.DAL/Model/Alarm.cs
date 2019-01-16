using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAL.Model
{
    public class Alarm
    {
        private string _name;
        private string _site;

        public Alarm()
        {

        }

        public string Name { get; set; }
        public string Site { get; set; }
    }
}
