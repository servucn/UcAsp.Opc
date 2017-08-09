using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcAsp.Opc
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            OpcClient _client = new OpcClient(new Uri("opc.tcp://yingjian-yurx:26543/Workstation.RobotServer"));


            OpcGroup group = _client.AddGroup("Test");
            OpcGroup groups = _client.AddGroup("Test2");
            _client.AddItems("Test", new string[] { "Robot1.Axis1", "Robot1.Axis2" });
           // _client.AddItems("Test2", new string[] { "Robot1.Axis3", "Robot1.Axis4" });
            group.DataChange += Group_DataChange;
            groups.DataChange += Group_DataChange2;
            Console.ReadKey();
            //  bool b=_client.Read<bool>("dd.dd.dd");


        }

        private static void Group_DataChange(object sender, List<OpcItemValue> e)
        {
            foreach (OpcItemValue value in e)
            {
                Console.WriteLine(value.ItemId+","+ value.GroupName+","+value.Timestamp+","+ value.Value);
            }
        }
        private static void Group_DataChange2(object sender, List<OpcItemValue> e)
        {
            foreach (OpcItemValue value in e)
            {
                Console.WriteLine(value.ItemId + "," + value.GroupName + "," + value.Timestamp + "," + value.Value);
            }
        }
    }

}
