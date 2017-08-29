/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/4 12:20:28
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
    public class OpcGroup
    {
        public OpcGroup() { }

        public void SendValue(List<OpcItemValue> e)
        {
            if (DataChange != null)
            {
                ItemDataEventArgs data = new ItemDataEventArgs { Data = e };
                DataChange(this, data);
            }
        }


        public event EventHandler<ItemDataEventArgs> DataChange;
        public TimeSpan UpdateRate { get; set; }
        public List<OpcItem> Items { get; set; }
        public bool IsActive { get; set; }

        public string Name { get; set; }



    }
}
