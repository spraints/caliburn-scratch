using Caliburn.Core;
using Caliburn.PresentationFramework.ApplicationModel;

namespace Scratch
{
    public class ShellViewModel : PropertyChangedBase
    {
        private readonly MyDataModel _model;
        private readonly MyDataPresenter _presenter;
        private readonly IWindowManager _windowManager;

        public ShellViewModel(MyDataModel model, MyDataPresenter presenter, IWindowManager windowManager)
        {
            _model = model;
            _presenter = presenter;
            _windowManager = windowManager;
            _model.PropertyChanged += (s, e) => NotifyOfPropertyChange(e.PropertyName);
        }

        public string TheValue
        {
            get { return _model.TheValue; }
            set { _model.TheValue = value; }
        }

        public void ConfigurePresenter()
        {
            _windowManager.Show(_presenter);
        }

        public void ConfigureObject()
        {
            _windowManager.Show(_model);
        }
    }
}
