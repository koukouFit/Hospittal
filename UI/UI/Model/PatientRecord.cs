using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Model
{
    /// <summary>
    /// 代表一个就诊病历信息
    /// </summary>
    public  class PatientRecord : ObservableObject
    {
        public string GUID = Guid.NewGuid().ToString();

        private string _illNessDesc = string.Empty;
        /// <summary>
        /// 主诉
        /// </summary>
        public string illNessDesc 
        {
            get { return _illNessDesc; }
            set { _illNessDesc = value; RaisePropertyChanged(() => illNessDesc); }
        }

        private string _conclusion = string.Empty;
        /// <summary>
        /// 望闻问切病状
        /// </summary>
        public string Conclusion
        {
            get { return _conclusion; }
            set { _conclusion = value; RaisePropertyChanged(() => Conclusion); }
        }
        public DateTime Time
        {
            get;set;
        }

        public MedicalType MedicalType
        {
            get;set;
        }
        ///  是否针灸
        ///  针灸位置 GUID 
        ///  本次疗效等级  EffectLevel
        public EffectLevel EffectLevel
        {
            get;set;
        }
        ///  本次疗效描述 
        private string _effectDesc = string.Empty;
        /// <summary>
        /// 效果反馈
        /// </summary>
        public string EffectDesc
        {
            get { return _effectDesc; }
            set { _effectDesc = value; RaisePropertyChanged(() => EffectDesc); }
        }
        ///  本次药品DrugApply
        ///  几贴



    }

    public enum EffectLevel
    {
        GOOD,
        SOSO,
        BAD
    }

    public enum MedicalType
    {
        medicine,
        MedicalNeedle,
        // 中药加针灸
        medicineandnedle,
        // 单纯问诊
        inquiry
    }
}
