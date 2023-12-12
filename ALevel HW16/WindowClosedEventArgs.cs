using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_HW16
{
    public class WindowClosedEventArgs : EventArgs
    {
        public State state { get; set; }
        public WindowClosedEventArgs(State State)
        {
            state = State;
        }
    }
}
