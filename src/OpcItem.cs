/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/4 12:21:39
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
    public class OpcItem
    {
        public string ItemId { get; set; }

        public string GroupName { get; set; }
        public string RequestedDataType { get; set; }
        public string CanonicalDataType { get; set; }
        public bool IsActive { get; set; }
       
        public AccessRights AccessRights { get; set; }


    }
}
