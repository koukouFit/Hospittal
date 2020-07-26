using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Model
{
    public class DrugInfo
    {
        public string GUID = Guid.NewGuid().ToString();
        public string Name
        {
            get;set;
        }
        public string Desc
        {
            get;set;
        }
        /// <summary>
        /// 注意事项
        /// </summary>
        public string Note
        {
            get;set;
        }

        // 分类


    }
    /// <summary>
    /// 一次开具的药方中的一个项
    /// </summary>
    public class DrugApply : ObservableObject
    {
        /// <summary>
        /// 自身guid
        /// </summary>
        public string GUID = Guid.NewGuid().ToString() ;

        /// 关联的药品
        /// 开具的数量
        private double count = 0;
        public double Count
        {
            get { return count; }
            set { count = value; RaisePropertyChanged(() => Count); }
        }
        /// 本次药品的remark

    }
}
