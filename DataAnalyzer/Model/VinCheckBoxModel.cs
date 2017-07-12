using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyzer.Model
{
    public class VinCheckBoxModel : ViewModelBase
    {
        private string name;
        public string Name { get { return name; } set { Set(ref name, value); } }
        private bool isSelected;
        public bool IsSelected { get { return isSelected; } set { Set(ref isSelected, value); RaisePropertyChanged("vinCheckList"); } }
    }
}
