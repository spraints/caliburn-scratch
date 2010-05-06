using Caliburn.Core;

namespace Scratch
{
    public class MyDataModel : PropertyChangedBase
    {
        private string _theValue = "TEST";
        public string TheValue
        {
            get { return _theValue; }
            set { _theValue = value; NotifyOfPropertyChange("TheValue"); }
        }
    }
}
