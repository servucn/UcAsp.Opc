using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UcAsp.Opc;
using System.Linq;
using System.Collections.Generic;
namespace OpcTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ConnectTest()
        {
            OpcClient client = new OpcClient(new Uri("opcda://127.0.0.1/Matrikon.OPC.Simulation.1"));
            string r = client.Read<string>("Random.String");
            Console.WriteLine(r);
        }

        [TestMethod]
        public void UARead()
        {
            OpcClient client = new OpcClient(new Uri("opc.tcp://127.0.0.1:26543/Workstation.RobotServer"));
            float r = client.Read<float>("Robot1.Axis1");
            Console.WriteLine(r);
        }
        [TestMethod]
        public void UAWrite()
        {
            OpcClient client = new OpcClient(new Uri("opc.tcp://127.0.0.1:26543/Workstation.RobotServer"));
            client.Write<float>("Robot1.Axis1", 2.0090f);
            float r = client.Read<float>("Robot1.Axis1");

            Console.WriteLine(r);
        }

        [TestMethod]
        public void FindNode()
        {

            OpcClient client = new OpcClient(new Uri("opc.tcp://127.0.0.1:26543/Workstation.RobotServer"));
            INode root = client.RootNode;           
            IEnumerable<INode> list = client.ExploreFolder(root.Tag);
            IEnumerable<INode> server = client.ExploreFolder(list.ToList()[0].Tag);
            IEnumerable<INode> s = client.ExploreFolder(server.ToList()[0].Tag);
            // string name = node.Name;
        }
        [TestMethod]
        public void UAGroup()
        {
            OpcClient client = new OpcClient(new Uri("opc.tcp://127.0.0.1:26543/Workstation.RobotServer"));
            OpcGroup group = client.AddGroup("Test");
            client.AddItems("Test", new string[] { "Robot1.Axis1", "Robot1.Axis2" });
            group.DataChange += Group_DataChange;
            Console.WriteLine(group);
        }

        private void Group_DataChange(object sender, System.Collections.Generic.List<OpcItemValue> e)
        {
            foreach (OpcItemValue o in e)
            {
                Console.WriteLine(o.Value);
            }
        }
    }
}
