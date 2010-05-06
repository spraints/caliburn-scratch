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

        public void DoSomethingCustom()
        {
            System.Windows.MessageBox.Show("It works!");
        }

        public void DoAnotherThing(SomeRandomThing thing, object x)
        {
            System.Windows.MessageBox.Show((thing == null ? "NULL!" : thing.Name) + "\r\n" + x);
        }
    }
}
