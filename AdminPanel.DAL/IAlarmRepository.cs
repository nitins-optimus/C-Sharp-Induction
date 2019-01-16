using AdminPanel.DAL.Model;
using System.Collections.Generic;

namespace AdminPanel.DAL
{
    public interface IAlarmRepository
    {
        System.Collections.Generic.List<Alarm> GetAllAlarms();
        void Save(List<AlarmMap> list);
        List<AlarmMap> GetAllAlarmMapping();
    }
}