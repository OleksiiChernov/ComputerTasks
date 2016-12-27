using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ki_14_5_lab4
{
    public class Task
    {

        #region Variables

        private DateTime _date;
        //private DateTime _time;
        private bool _isResolved;

        #endregion


        #region Interface

        public Task(Task task)
        {
            if (null == task)
            {
                throw new NullReferenceException();
            }

            ResolveDate = task.ResolveDate;
            IsResolved = task.IsResolved;
            TaskName = task.TaskName;
            Info = task.Info;
        }

        public Task()
        {
            ResolveDate = DateTime.Now;
            IsResolved = false;
            TaskName = string.Empty;
            Info = string.Empty;
        }

        public Task(string name, DateTime time, bool isReady, string info = null)
        {
            TaskName = name;
            ResolveDate = time;
            _isResolved = isReady;
            Info = info;
        }

        public void DoTask()
        {

        }

        public override string ToString()
        {
            return ResolveDate + Constants.Strings.Dash + TaskName;
        }

        #endregion 

        #region Properties

        public EventHandler OnDateChanged { get; set; }
        public EventHandler OnStatusChanged { get; set; }


        public DateTime ResolveDate
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;

                if (null != OnDateChanged)
                {
                    OnDateChanged(this, new EventArgs());
                }
            }
        }

        public bool IsResolved
        {
            get
            {
                return _isResolved;
            }
            set
            {
                _isResolved = value;

                if (null != OnStatusChanged)
                {
                    OnStatusChanged(this, new EventArgs());
                }
            }
        }

        public string TaskName { get; set; }
        public string Info { get; set; }
        
        #endregion

    }
}
