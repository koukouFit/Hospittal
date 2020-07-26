using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace UI.Model
{
    /// <summary>
    /// 病人基本信息
    /// </summary>
    public  class PatientModel : ObservableObject
    {
        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(() => Name); }
        }

        public string GUID = Guid.NewGuid().ToString();

        #region  基本信息
        // 默认是灰色头像  界面上有图片供选择  也可以添加额外的。
        public string ImagePath
        {
            get;set;
        }
        #endregion


    }

    /// <summary>
    /// 来访的历史病人  
    /// </summary>
    public class PatientVisitModel : ObservableObject
    {
        public PatientVisitModel(PatientModel patientInfo)
        {
            _patientModel = patientInfo;
        }

        private PatientModel _patientModel = null;
        public PatientModel PatientInfo { get { return _patientModel; } }


        #region 外部关联
        public bool Started { get; set; }

        public DateTime ListVistTime { get; set; }

        public int RecordCount { get; set; }
        #endregion


        ///病史记录
        ///
        private ObservableCollection<PatientRecord> _patientRecordList = new ObservableCollection<PatientRecord>();
        public ObservableCollection<PatientRecord> PatientRecordList
        {
            get { return _patientRecordList; }
            set { _patientRecordList = value; RaisePropertyChanged(() => PatientRecordList); }
        }

    }


}
