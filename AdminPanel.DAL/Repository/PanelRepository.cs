using AdminPanel.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAL.Repository
{
    public class PanelRepository : IPanelRepository
    {
        private DataContext _context = new DataContext();

        public Panel GetPanelById(int id)
        {
            return _context.Panels.Where(p => p.Id == id).FirstOrDefault();
        }
        public Panel GetAPanel()
        {
            return _context.Panels.FirstOrDefault();
        }

        public List<Panel> GetAllPanels()
        {
            return _context.Panels;
        }
    }

}
