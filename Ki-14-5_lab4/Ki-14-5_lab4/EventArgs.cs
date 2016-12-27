using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ki_14_5_lab4
{
    public class ComputerEventArgs : EventArgs
    {
        public ComputerEventArgs(string name, bool availabel)
        {
            ComputerName = name;
            IsAvailable = availabel;
        }

        public string ComputerName { get; private set; }
        public bool IsAvailable { get; private set; }
    }

    public class TaskEventArgs : EventArgs
    {
        public TaskEventArgs(string name, string info , DateTime date)
        {
            TaskName = name;
            TaskInfo = info;
            Date = date;
        }

        public string TaskName { get; private set; }
        public string TaskInfo { get; private set; }
        public DateTime Date {get;set;}
    }

}
