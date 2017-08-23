# 连接
## DA 
 OpcClient client = new OpcClient(new Uri("opcda://127.0.0.1/Matrikon.OPC.Simulation.1"));
## UA

OpcClient client = new OpcClient(new Uri("opc.tcp://127.0.0.1:26543/Workstation.RobotServer"));

# Read
if (client.Connect == OpcStatus.Connected)
{
                float r = client.Read<float>("Robot1.Axis1");
}

# Write

if (client.Connect == OpcStatus.Connected)
{
     client.Write<float>("Robot1.Axis1", 2.0090f);
      loat r = client.Read<float>("Robot1.Axis1");
 }
# DataChage

if (client.Connect == OpcStatus.Connected)
{
     OpcGroup group = client.AddGroup("Test");
     client.AddItems("Test", new string[] { "Robot1.Axis1", "Robot1.Axis2" });
      group.DataChange += Group_DataChange;
      Console.WriteLine(group);
}


#  注意：

## 使用DA 前请先安装OPC Core Components Redistributable (x64).msi