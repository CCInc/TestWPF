using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CCProgressBar
{
    public class ProgressBarViewModel : ViewModelBase
    {
        //public int MinValue { get { return 0; } }
        //public int Maxvalue { get { return 100; } }
        //private int _value;
        //public int Value
        //{
        //    get { return _value; }
        //    set
        //    {
        //        _value = value;
        //        OnPropertyChanged("Value");
        //    }
        //}

        //public void Start()
        //{
        //    TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        //    var dummyTask = Task<int>.Factory.StartNew(() =>
        //    {
        //        Count += 1;
        //        return Values.Count + 1;
        //    });
        //    dummyTask.ContinueWith(antecedent =>
        //    {
        //        Values.Add(new NumberClass { Number = antecedent.Result });
        //    }, CancellationToken.None, TaskContinuationOptions.None, uiScheduler);
        //}
    }
}
