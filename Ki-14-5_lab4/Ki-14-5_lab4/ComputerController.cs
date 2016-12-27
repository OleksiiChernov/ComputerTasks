using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ki_14_5_lab4
{
    public class ComputerController
    {

        #region Variables

        private List<Computer> _computers;
        private List<Task> _availableTasks;
        private string _wifipass;

        #endregion


        #region Interface

        public ComputerController()
        {
            _computers = new List<Computer>();
            _availableTasks = new List<Task>();
            IsWiFiAvailable = true;
        }

        public void AddTaskToComputer(Computer computer, Task task)
        {
            if (null == computer || null == task)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            computer.AddTask(task);

            if (null != OnDataChanged)
            {
                OnDataChanged(this, new EventArgs());
            }

        }

        public void RemoveTaskFromComputer(Computer computer, Task task)
        {
            if (null == computer || null == task)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            computer.RemoveTask(task);

            if (null != OnDataChanged)
            {
                OnDataChanged(this, new EventArgs());
            }

        }

        public void AddComputer(Computer computer)
        {
            if (null == computer)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            if (null == _computers)
            {
                _computers = new List<Computer>();
            }

            if (_computers.Contains(computer))
            {
                MessageBox.Show("Computer has been alredy added.");
                return;
            }
            else
            {
                _computers.Add(computer);
            }

            if (null != OnDataChanged)
            {
                OnDataChanged(this, new EventArgs());
            }

        }

        public void RemoveComputer(Computer computer)
        {
            if (null == computer)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            if (null == _computers)
            {
                _computers = new List<Computer>();
            }

            if (_computers.Contains(computer))
            {
                _computers.Remove(computer);

                if (null != OnDataChanged)
                {
                    OnDataChanged(this, new EventArgs());
                }

            }
            else
            {
                MessageBox.Show("Incorrect argument.");
                return;
            }

        }

        public void AddNewTask(string name, DateTime time, bool isReady, string info = null)
        {
            Task newTask = new Task(name, time, isReady, info);

            if (null == _availableTasks)
            {
                _availableTasks = new List<Task>();
            }

            if (_availableTasks.Contains(newTask))
            {
                MessageBox.Show("Computer has been alredy added.");
                return;
            }

            _availableTasks.Add(newTask);

            if (null != OnDataChanged)
            {
                OnDataChanged(this, new EventArgs());
            }
        }

        public void RemoveTask(Task task)
        {
            if (null == task)
            {
                MessageBox.Show("Null data excepted.");
                return;
            }

            if (null == _availableTasks)
            {
                _availableTasks = new List<Task>();
            }

            if (_availableTasks.Contains(task))
            {  
                foreach (var comp in _computers)
                {
                    List<int> objectsToDelete = new List<int>();
                    foreach (var compTask in comp.AddedTask)
                    {
                        if (compTask == task)
                        {
                            objectsToDelete.Add(comp.AddedTask.IndexOf(compTask));
                        }
                    }

                    foreach (var obj in objectsToDelete)
                    {
                        comp.AddedTask.RemoveAt(obj);
                    }

                }
            _availableTasks.Remove(task);
            }
            else
            {
                MessageBox.Show("Incorrect argument.");
                return;
            }

            if (null != OnDataChanged)
            {
                OnDataChanged(this, new EventArgs());
            }
        }

        #endregion


        #region Properties

        public EventHandler OnDataChanged { get; set; }

        public List<Computer> ComputersList
        {
            get { return _computers; }
        }

        public List<Task> AvailableTaskList
        {
            get { return _availableTasks; }
        }


        public int TotalComputersCount
        {
            get
            {
                return null == _computers ? 0 : _computers.Count;
            }
        }

        public int AvailableComputersCount
        {
            get
            {
                return null == _computers ? 0 : _computers.Count(comp => comp.IsReady == true);
            }
        }

        public bool IsWiFiAvailable { get; set; }
        public string WiFiPassword
        {
            get
            {
                if (IsWiFiAvailable)
                {
                    return _wifipass;
                }
                else
                {
                    MessageBox.Show("Wifi is unavailable");
                    return string.Empty;
                }
            }
            set
            {
                if (IsWiFiAvailable)
                {
                    if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    {
                        MessageBox.Show("Incorrect pass!");
                        _wifipass = string.Empty;
                    }
                    else
                    {
                        _wifipass = value;
                    }
                }
                else
                {
                    MessageBox.Show("Wifi is unavailable");
                    _wifipass = string.Empty;
                }
            }
        }

        #endregion

    }
}
