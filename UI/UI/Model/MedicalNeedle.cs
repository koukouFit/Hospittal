using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Model
{
    /// <summary>
    /// 针灸基本信息是
    /// </summary>
     public class MedicalNeedle : ObservableObject
    {
        public string GUID = Guid.NewGuid().ToString();

        public string Desc { get; set; }

        public string Effect { get; set; }

        // 分类

    }
}
