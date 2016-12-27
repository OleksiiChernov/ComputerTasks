using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ki_14_5_lab4
{
    public class Computer
    {

        #region Variables

        private List<Task> _addedTasks;
        private bool _isReady;


        #endregion


        #region Interface

        public Computer()
        {
            _addedTasks = new List<Task>();
            _isReady = false;
        }

        public Computer(string name, bool isReady)
        {
            Name = name;
            _isReady = isReady;
            _addedTasks = new List<Task>();
        }

        //public static bool operator ==(Computer first , Computer second)
        //{
        //    if (null == first && null == second)
        //    {
        //        return true;
        //    }

        //    if (null == first || null == second)
        //    {
        //        return false;
        //    }

        //    return (first.IsReady.Equals(second.IsReady) && 
        //        first.TasksCount.Equals(second.TasksCount) && first.AddedTask.Equals(second.AddedTask));
        //}

        public override bool Equals(object obj)
        {
            if (obj is Computer)
            {
                var comp = obj as Computer;
                return IsReady.Equals(comp.IsReady) && TasksCount.Equals(comp.TasksCount) && AddedTask.Equals(comp.AddedTask);
            }
            return false;
        }

        //public static bool operator !=(Computer first, Computer second)
        //{
        //    return !(first == second);
        //}

        public void AddTask(Task task)
        {
            if (null == task)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            if (null == _addedTasks)
            {
                _addedTasks = new List<Task>();
            }

            if (_addedTasks.Contains(task))
            {
                MessageBox.Show("Component has been alredy added.");
                return;
            }

            _addedTasks.Add(task);

        }

        public void RemoveTask(Task task)
        {
            if (null == task)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            if (null == _addedTasks)
            {
                _addedTasks = new List<Task>();
            }

            if (_addedTasks.Contains(task))
            {
                _addedTasks.Remove(task);
            }
            else
            {
                MessageBox.Show("Incorrect component.");
            }
        }

        #endregion


        #region Properties

        public EventHandler OnReadyChanged { get; set; }
        public EventHandler OnAllTaskResolved { get; set; }

        public string Name { get; set; }

        public bool IsReady
        {
            get
            {
                return _isReady;
            }
            set
            {
                _isReady = value;

                if (null != OnReadyChanged)
                {
                    OnReadyChanged(this, new EventArgs());
                }
            }
        }

        public int TasksCount
        {
            get
            {
                return null == _addedTasks ? 0 : _addedTasks.Count;
            }
        }

        public List<Task> AddedTask
        {
            get
            {
                return _addedTasks;
            }
        }

        #endregion

    }
}
