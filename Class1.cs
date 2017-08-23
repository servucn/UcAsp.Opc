/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/23 16:52:25
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

namespace UcAsp.Opc
{
    class Class1
    {
        static void Main(string[] arg)
        {
            OpcClient client = new OpcClient(new Uri("opcda://127.0.0.1/Matrikon.OPC.Simulation.1"));
            OpcGroup group = client.AddGroup("Test");
            string msg;
            group = client.AddItems("Test", new string[] { "D.Random.Int1", "Random.Int2" }, out msg);
            group.DataChange += Group_DataChange;

            Console.ReadKey();

        }

        private static void Group_DataChange(object sender, List<OpcItemValue> e)
        {
            foreach (OpcItemValue v in e)
            {
                Console.WriteLine("{0},{1}", v.ItemId, v.Value);
            }
        }
    }
}
