using Caliburn.Core;

namespace Scratch
{
    public class ControlDataModel : PropertyChangedBase
    {
        private MyDataModel _model;
        public ControlDataModel(MyDataModel model)
        {
            _model = model;
            _model.PropertyChanged += (s, e) => NotifyOfPropertyChange(e.PropertyName);
        }

        public string TheValue
        {
            get { return _model.TheValue; }
            set { _model.TheValue = value; }
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
