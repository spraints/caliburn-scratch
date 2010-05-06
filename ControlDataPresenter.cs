using Caliburn.PresentationFramework.ApplicationModel;

namespace Scratch
{
    public class ControlDataPresenter : Presenter
    {
        private MyDataModel _model;
        public ControlDataPresenter(MyDataModel model)
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
    }
}
