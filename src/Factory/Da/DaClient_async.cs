using System.Collections.Generic;
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


  }
}
