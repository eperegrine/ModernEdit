using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModernEdit.Commands
{
    public static class WindowCommands
    {
        public static readonly RoutedUICommand ShowInfo = new RoutedUICommand
            ("ShowInfo", "ShowInfo", typeof(WindowCommands));
    }
}
