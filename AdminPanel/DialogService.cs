using AdminPanel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdminPanel
{
    class DialogService
    {
        Window configureConnections = null;
        Window saveDialog = null;
        
        public void ShowConnectionConfiguration()
        {
            configureConnections = new ConfigureConnectionsView();
            configureConnections.ShowDialog();
        }

        public void CloseConnectionConfiguration()
        {
            if(configureConnections!=null)
            {
                configureConnections.Close();
            }
        }
        public void ShowSaveDialog()
        {
            saveDialog = new SaveConfirmationView();
            saveDialog.ShowDialog();
        }

        public void CloseSaveDialog()
        {
            if(saveDialog!=null)
            {
                saveDialog.Close();
            }
        }
        
    }
}
