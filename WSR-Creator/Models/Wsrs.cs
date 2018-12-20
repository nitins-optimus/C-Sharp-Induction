using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WSR_Creator.Models
{
    public class Wsr: INotifyPropertyChanged
    {
        public string ProjectName { get; set; }
        public string OwnerName { get; set; }
        public string EffortSpent { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {

        }
    }

   
}
