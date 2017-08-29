/***************************************************
*创建人:rixiang.yu
*创建时间:2017/7/28 13:14:32
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.0
*CLR版本：4.0.30319.42000
***************************************************/
using UcAsp.Opc;

namespace UcAsp.Opc.Da
{
    /// <summary>
    /// Represents a node to be used specifically for OPC DA
    /// </summary>
    public class DaNode : Node
    {
        /// <summary>
        /// Instantiates a DaNode class
        /// </summary>
        /// <param name="name">the name of the node</param>
        /// <param name="tag"></param>
        /// <param name="parent">The parent node</param>
        public DaNode(string name, string tag, Node parent = null)
          : base(name, parent)
        {
            Tag = tag;
        }
    }
}
