/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/2 18:23:34
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
    public interface INode
    {
        string Name { get; }
        string Tag { get; }
        INode Parent { get; }
        string NodeId { get; }
    }

}
