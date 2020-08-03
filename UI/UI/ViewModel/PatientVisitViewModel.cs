using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using UI.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace UI.ViewModel
{
    /// <summary>
    /// 用于绑定界面  表示一个用户的所有看诊记录
    /// </summary>
    public class PatientVisitViewModel : ObservableObject
    {
        private String introduction;
        /// <summary>
        /// 欢迎词
        /// </summary>
        public String Introduction
        {
            get { return introduction; }
            set { introduction = value; RaisePropertyChanged(() => Introduction); }
        }
    }

    /// <summary>
    ///  所有用户的访问列表
    /// </summary>
    public class PatientVisitTreeViewModel : ViewModelBase
    {
        private ObservableCollection<PatientVisitModel> _patientVisitList = new ObservableCollection<PatientVisitModel>();
        /// <summary>
        /// 所有用户的病历集合。 一个PatientVisitModel钟包含金短时间的问诊记录。超过的部分需要手动的加载
        /// </summary>
        public ObservableCollection<PatientVisitModel> PatientVisitList
        {
            get { return _patientVisitList; }
            set { _patientVisitList = value; RaisePropertyChanged(() => PatientVisitList); }
        }


        private bool _listboxVisible = true;
        public bool ListBoxVisible
        {
            get { return _listboxVisible; }
            set { _listboxVisible = value; RaisePropertyChanged(() => ListBoxVisible); }
        }


        public PatientVisitTreeViewModel()
        {
            PatientModel patient = new PatientModel() {  Name = "风湿口55522", ImagePath = @"/Image/Image1.jpg"}; 
            PatientModel patient1 = new PatientModel() {  Name = "哈皮吧555", ImagePath = @"/Image/Image2.jpg"};

            PatientRecord patientRecord = new PatientRecord() { Conclusion = "脉搏弱", MedicalType = MedicalType.medicineandnedle, illNessDesc = "身体乏力", EffectDesc = "效果还死心", EffectLevel = EffectLevel.GOOD, Time = DateTime.Now};
            PatientRecord patientRecord1 = new PatientRecord() { Conclusion = "脉搏弱1", MedicalType = MedicalType.medicineandnedle, illNessDesc = "身体乏力1", EffectDesc = "效果还死心1", EffectLevel = EffectLevel.BAD, Time = DateTime.Now };

            PatientVisitModel patientVisitModel = new PatientVisitModel(patient) {  ListVistTime = DateTime.Now.AddDays(-1), RecordCount = 211};
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord);
            patientVisitModel.PatientRecordList.Add(patientRecord1);
            PatientVisitModel patientVisitModel1 = new PatientVisitModel(patient) {  ListVistTime = DateTime.Now.AddDays(-12), RecordCount = 1211};
            patientVisitModel1.PatientRecordList.Add(patientRecord);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            patientVisitModel1.PatientRecordList.Add(patientRecord1);
            PatientVisitList.Add(patientVisitModel);
            PatientVisitList.Add(patientVisitModel1);
            PatientVisitList.Add(patientVisitModel1);

        }

        #region
        private RelayCommand listBoxClickCommand;
        /// <summary>
        /// 双击事件
        /// </summary>
        public RelayCommand ListBoxClickCommand
        {
            get
            {
                if (listBoxClickCommand == null)
                    listBoxClickCommand = new RelayCommand(() => SetListboxVisible());
                return listBoxClickCommand;

            }
            set { listBoxClickCommand = value; }
        }

        private void SetListboxVisible()
        {
            //ListBoxVisible = o;
        }
        #endregion
    }
}
