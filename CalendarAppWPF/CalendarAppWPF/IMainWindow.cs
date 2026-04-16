using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAppWPF
{
    interface IMainWindow
    {
        void ShowError(string message);
        void AddNewEvent();
        void CategoryWindowShow();
        void SaveAndQuit();
        void FilterByMonth();
        void FilterByCategory();

        //void DisplayEvents();
    }
}
