/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/28 11:06:37
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.0
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcAsp.Opc
{
    public class ItemDataEventArgs : EventArgs
    {
        public List<OpcItemValue> Data { get; set; }

    }
}
