/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/4 12:22:38
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
    /// <summary>
  /// 读写权限
  /// </summary>
    public enum AccessRights
    {
        /// <summary>
        /// Ignore access rights.
        /// </summary>
        Ignore = 0,

        /// <summary>
        /// Read only.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Write only.
        /// </summary>
        Write = 2,

        /// <summary>
        /// Read and write.
        /// </summary>
        ReadWrite = 3
    }
}
