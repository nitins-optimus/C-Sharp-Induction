using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSR_Creator.Models;

namespace WSR_Creator
{
    public class WsrCollectn
    {
        public List<Wsr> WsrList { get; }

        public Wsr SelectedWsr { get; set; }

        public WsrCollectn()
        {
            using (StreamReader fileData = new StreamReader(@"C:\Users\Nitin Sharma\source\repos\WSR-Creator\WSR-Creator\Data\WsrData.json")) 
            {
                string json = fileData.ReadToEnd();

                Dictionary<string, Wsr> item = JsonConvert.DeserializeObject<Dictionary<string, Wsr>>(json);
                WsrList = item.Values.ToList();


            }

            

          

            /*WsrList = new List<Wsr>();
            WsrList.Add(new Wsr() { ProjectName = "Vaisala", EffortSpent = "90 Hrs", OwnerName = "Nitin Sharma"});
            WsrList.Add(new Wsr() { ProjectName = "Avigilon", EffortSpent = "500 Hrs", OwnerName = "Khushbu"});
            WsrList.Add(new Wsr() { ProjectName = "Best Buy", EffortSpent = "400 Hrs", OwnerName = "Kanika" });
            WsrList.Add(new Wsr() { ProjectName = "Squirrel", EffortSpent = "300 Hrs", OwnerName = "Sarthak Seth" });
            WsrList.Add(new Wsr() { ProjectName = "Monkey Media", EffortSpent = "100 Hrs", OwnerName = "Shubham" });
            WsrList.Add(new Wsr() { ProjectName = "Xmatters", EffortSpent = "250 Hrs", OwnerName = "Manisha" }); */
        }
    }
}
