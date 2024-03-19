using ClientApp.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Service
{
    public class NameServiceViaWindow : INameService
    {
        public string GetName()
        {
            MsgWindow nw = new MsgWindow();
            nw.ShowDialog();
            return nw.VM.EnteredName;
        }
    }
}