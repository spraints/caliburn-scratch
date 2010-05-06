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
    }
}
