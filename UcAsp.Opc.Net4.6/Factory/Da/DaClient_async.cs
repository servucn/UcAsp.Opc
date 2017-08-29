/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/28 13:14:32
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.0
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UcAsp.Opc;
using Opc;
using Factory = OpcCom.Factory;
using OpcDa = Opc.Da;
using System.Threading.Tasks;
using UcAsp.Opc;

namespace UcAsp.Opc.Da
{
    /// <summary>
    /// Client Implementation for DA
    /// </summary>
    public partial class DaClient
    {
        /// <summary>
        /// Read a tag asynchronusly
        /// </summary>
        public async Task<T> ReadAsync<T>(string tag)
        {

            return await Task.Run(() => Read<T>(tag));
        }

        /// <summary>
        /// Write a value on the specified opc tag asynchronously
        /// </summary>
        public async Task WriteAsync<T>(string tag, T item)
        {
            await Task.Run(() => Write(tag, item));
        }
        public async Task<INode> FindNodeAsync(string tag)
        {
            return await Task.Run(() => FindNodeAsync(tag));
        }

        public async Task<IEnumerable<INode>> ExploreFolderAsync(string tag)
        {
            return await Task.Run(() => ExploreFolderAsync(tag));
        }

    }
}
