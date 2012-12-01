using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCWpf
{
    public class ViewModel : UnifiedViewModelBase
    {
        public ViewModel()
        {
            Name = "DefaultName";
        }
        public string Name { get; set; }
    }
}
