using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    /// <summary>
    /// 员工分组基类， 目前分为好友 群组 特别关心
    /// </summary>
    public class PatientGroupBase: ObservableObject
    {
        private List<PatientModel> patients = new List<PatientModel>();
        public List<PatientModel> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                RaisePropertyChanged(() => Patients);
            }
        }

        public virtual string Name { get;  }
    }

    /// <summary>
    /// 好友 
    /// </summary>
    public class PatientRelativeGroup : PatientGroupBase
    {
        public override string Name { get => "好友"; }

    }

    /// <summary>
    /// 群组
    /// </summary>
    public class PatientGroup : PatientGroupBase
    {
        public override string Name { get => "群组"; }
    }

    /// <summary>
    /// 特别关心
    /// </summary>
    public class PatientSpecialGroup:PatientGroupBase
    {
        public override string Name { get => "特别关心"; }
    }

}
