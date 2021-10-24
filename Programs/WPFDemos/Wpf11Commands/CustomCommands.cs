using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConceptArchitect.Commands
{
    public class CustomCommands
    {
        public static RoutedCommand DeleteCommand { get; set; } = new RoutedCommand();
    }
}
