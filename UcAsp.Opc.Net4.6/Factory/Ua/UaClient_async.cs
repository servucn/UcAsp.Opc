/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/28 13:06:54
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.6
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcAsp.Opc.Ua
{
    public partial class UaClient
    {
        /// <summary>
        /// Explores a folder asynchronously
        /// </summary>
        public async Task<IEnumerable<INode>> ExploreFolderAsync(string tag)
        {
            return await Task.Run(() => ExploreFolder(tag));
        }
        /// <summary>
        /// Find node asynchronously
        /// </summary>
        public async Task<INode> FindNodeAsync(string tag)
        {
            return await Task.Run(() => FindNode(tag));
        }


    }
}
