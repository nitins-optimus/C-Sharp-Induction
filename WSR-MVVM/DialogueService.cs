using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WSR_MVVM.Models;
using WSR_MVVM.Views;

namespace WSR_MVVM
{
    class DialogueService
    {
        private static DialogueService _instance = new DialogueService();
        
        
            private DialogueService()
        {

        }

        public static DialogueService Instance
        {
            get { return _instance; }
           
        }

        public void ShowWsrDetailDialog( Wsr wsr)
        {
            Window wsrWindow = new WsrProjectDetail();
            wsrWindow.DataContext = wsr;
            wsrWindow.Show();
        }

    }
}
