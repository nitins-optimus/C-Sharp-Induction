using AdminPanel.DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAL
{
    public class AlarmRepository : IAlarmRepository
    {
        private List<Alarm> _alarms;
        public AlarmRepository()
        {
            _alarms = new List<Alarm>();
            for (var i = 1; i < 5; i++)
            {
                _alarms.Add(
                    new Alarm()
                    {
                        Name = "Alarm" + i,
                        Site = "Site" + i
                    }
                    );
            }
        }

        public List<AlarmMap> GetAllAlarmMapping()
        {
            List<AlarmMap> maps = null;
            string map = File.ReadAllText(@"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\AlarmMapping.json");

            try
            {
                maps = JsonConvert.DeserializeObject<List<AlarmMap>>(map);
            }
            catch(Exception)
            {

            }
            return maps;
        }

        public List<Alarm> GetAllAlarms()
        {
            return _alarms;
        }

        public void Save(List<AlarmMap> alarmMap)
        {
            using (StreamWriter file = File.CreateText(@"C:\Optimus\Avigilon\Induction\MVVM-Induction\AdminPanel.DAL\Data\AlarmMapping.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, alarmMap);
            }
        }

    }
}
