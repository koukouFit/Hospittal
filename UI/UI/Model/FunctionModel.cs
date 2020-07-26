using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Commons;

namespace UI.Model
{
    public class FunctionModel
    {
        public string Name 
        {
            get { return Type.ToString(); }
        }
        /// <summary>
        /// 界面上显示的名称
        /// </summary>
        public string FuncDesc 
        {
            get { return CommonFunction.GetDescription(Type); }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public FuncType Type { get; set; }



    }

    public enum FuncType
    {
        [Description("就诊记录")]
        Records,
        [Description("通讯录")]
        Patients,
        [Description("功能")]
        Functions,
        [Description("设置")]
        Settings
    }
}
