﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSR_Creator.Models;

namespace WSR_Creator
{
    public class WsrCollectn:INotifyPropertyChanged
    {
        public List<Wsr> WsrList { get; }
        private Wsr _selectedWSR;

        public Wsr SelectedWsr
        {
            get { return _selectedWSR; }
            set
            {
                _selectedWSR = value;
            }
        }

        public WsrCollectn()
        {

            using (StreamReader fileData = new StreamReader(@"C:\Users\Nitin Sharma\source\repos\WSR-Creator\WSR-Creator\Data\WsrData.json")) 
            {
                string json = fileData.ReadToEnd();

                Dictionary<string, Wsr> item = JsonConvert.DeserializeObject<Dictionary<string, Wsr>>(json);
                WsrList = item.Values.ToList();


            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}