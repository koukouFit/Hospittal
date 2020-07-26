using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Model;

namespace UI.ViewModel
{
    /// <summary>
    /// 用于显示好友管理界面
    /// </summary>
    public class PatientRelationViewModel:ObservableObject
    {
        public PatientRelationViewModel()
        {
            // 从数据库中读取数据  并创建三种分组 用于存放不同病人信息
        }

        private ObservableCollection<PatientGroupBase> _patientGroup = new ObservableCollection<PatientGroupBase>();
        /// <summary>
        /// 分组管理
        /// </summary>
        public ObservableCollection<PatientGroupBase> PatientGroup
        {
            get { return _patientGroup; }
            set { _patientGroup = value; RaisePropertyChanged(() => PatientGroup); }
        }
    }
}
