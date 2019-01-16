using AdminPanel.DAL;
using AdminPanel.DAL.Model;
using AdminPanel.DAL.Repository;
using AdminPanel.Extensions;
using AdminPanel.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AdminPanel.VIewModel
{
    public class ConfigurationViewModel : INotifyPropertyChanged
    {
        private Panel _selectedPanel;
        private Alarm _selectedAlarm;
        private AlarmMap _selectedAlarmMap;

        private List<Alarm> _alarms;
        private List<Panel> _panels;
        private IAlarmRepository _alarmRepository;
        private IPanelRepository _panelsRepository;
        private ObservableCollection<AlarmMap> _alarmMapping;
        private DialogService dialogService;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Alarm> Alarms { get { return _alarms; } }
        public List<Panel> Panels { get { return _panels; } }
        public ObservableCollection<AlarmMap> AlarmMap  { get { return _alarmMapping; } }

        public Panel SelectedPanel
        {
            get
            {
                return _selectedPanel;
            }
            set
            {
                _selectedPanel = value;
               
            }
        }
        public Alarm SelectedAlarm
        {
            get { return _selectedAlarm; }

            set
            {
                _selectedAlarm = value;
               

            }
        }
        public AlarmMap SelectedAlarmMap
        {
            get { return _selectedAlarmMap; }
            set
            {
                _selectedAlarmMap = value;
                AlarmMapCommand.RaiseCanExecuteChanged();
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedAlarmMap"));
            }
        }

        public IRelayCommand ConfigureConnectionsCommand { get; private set; }
        public IRelayCommand AlarmMapCommand { get; private set; }
        public IRelayCommand RemoveAlarmMapCommand { get; private set; }
        public IRelayCommand SaveCommand { get; private set; }

        // Constructor
        public ConfigurationViewModel()
        {
            _alarmRepository = new AlarmRepository();
            _panelsRepository = new PanelRepository();
            _alarmMapping = _alarmRepository.GetAllAlarmMapping().ToObservableCollection();
            ConfigureConnectionsCommand = new RelayCommand(ConfigureConnections,CanConfigure);
            AlarmMapCommand = new RelayCommand(MapAlarm, CanMapAlarm);
            RemoveAlarmMapCommand = new RelayCommand(RemoveAlarmMap);
            SaveCommand = new RelayCommand(SaveAlarmMapping);
            dialogService = new DialogService();
            LoadData();
        }

        private void ConfigureConnections()
        {
            dialogService.ShowConnectionConfiguration();
        }

        private void SaveAlarmMapping()
        {
            var alarmMapList = _alarmMapping.ToList();
            _alarmRepository.Save(alarmMapList);
            dialogService.ShowSaveDialog();
        }

        private bool CanConfigure()
        {
            return true;
        }

        private bool CanMapAlarm()
        {
            return true;
        }

        private void RemoveAlarmMap()
        {
            if(_selectedAlarmMap != null)
            {
                _alarmMapping.Remove(_selectedAlarmMap);     
            }
        }

        private void LoadData()
        {
            _alarms = _alarmRepository.GetAllAlarms();
            _panels = _panelsRepository.GetAllPanels();
        }

        private void MapAlarm()
        {
            bool IsAlarmMapPresent = false; 

            if (SelectedAlarm != null && SelectedPanel != null)
            {
                var alarm = new AlarmMap()
                {
                    AlarmName = SelectedAlarm.Name,
                    SiteName = SelectedAlarm.Site,
                    PanelName = SelectedPanel.Name,
                    PanelType = SelectedPanel.Type
                };
                foreach (var ala in _alarmMapping)
                {
                    if (ala.AlarmName.Equals(SelectedAlarm.Name)
                         && ala.SiteName.Equals(SelectedAlarm.Site)
                         && ala.PanelName.Equals(SelectedPanel.Name)
                         && ala.PanelType.Equals(SelectedPanel.Type)
                        )
                    {
                        IsAlarmMapPresent = true;
                    }
                }
                if(!IsAlarmMapPresent)
                    _alarmMapping.Add(alarm);
            }
        }      
    }
}
