/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/5 10:40:06
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.6.1
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcAsp.Opc
{
    public class OpcItemValue
    {

        public string ItemId { get; set; }

        public string GroupName { get; set; }
        public object Value { get; set; }

        public string Quality { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
