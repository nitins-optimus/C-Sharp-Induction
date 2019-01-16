using AdminPanel.DAL.Model;
using System.Collections.Generic;

namespace AdminPanel.DAL.Repository
{
    public interface IPanelRepository
    {
        Panel GetAPanel();
        Panel GetPanelById(int id);
        List<Panel> GetAllPanels();
    }
}