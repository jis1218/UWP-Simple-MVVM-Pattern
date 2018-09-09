using MVVMPrac.Models;
using System;

namespace MVVMPrac.ViewModels
{
    public class DataViewModel : NotificationBase<Data>
    {
        private Data _task;

        public DataViewModel()
        {
            _task = new Data();
        }

        public string Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }        
    }
}
