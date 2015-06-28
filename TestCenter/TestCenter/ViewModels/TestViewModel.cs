using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public new string Title
        {
            get
            {
                return "Test Details";
            }
        }
    }
}
