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
            ("ShowInfo", "ShowInfo", typeof(ApplicationCommands));

        public static RoutedUICommand SaveAs = new RoutedUICommand(
            "Save As",
            "SaveAs",
            typeof(MediaCommands),
            SaveAsInputGesture());

        public static InputGestureCollection SaveAsInputGesture ()
        {
            InputGestureCollection igc = new InputGestureCollection();
            igc.Add(new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Shift));

            return igc;
        }
    }
}
