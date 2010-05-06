using Caliburn.PresentationFramework.ApplicationModel;

namespace Scratch
{
    public class MyDataPresenter : Presenter
    {
        private MyDataModel _model;
        public MyDataPresenter(MyDataModel model)
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
