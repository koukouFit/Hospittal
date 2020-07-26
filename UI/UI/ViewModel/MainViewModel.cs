using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using UI.Model;

namespace UI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _functionModelList.Add(new FunctionModel() { Type = FuncType.Records });
            _functionModelList.Add(new FunctionModel() { Type = FuncType.Patients });
            _functionModelList.Add(new FunctionModel() { Type = FuncType.Functions });
            _functionModelList.Add(new FunctionModel() { Type = FuncType.Settings });
        }

        private ObservableCollection<FunctionModel> _functionModelList = new ObservableCollection<FunctionModel>();
        /// <summary>
        /// 分组管理
        /// </summary>
        public ObservableCollection<FunctionModel> FunctionModelList
        {
            get { return _functionModelList; }
            set { _functionModelList = value; RaisePropertyChanged(() => FunctionModelList); }
        }
    }
}