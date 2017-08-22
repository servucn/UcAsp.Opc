/***************************************************
*创建人:rixiang.yu
*创建时间:2017/8/2 18:16:39
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
    public class OpcClient
    {
        private IClient<INode> _client;
        ClientOptions _options = new ClientOptions();
        private Dictionary<string, OpcGroup> _groups = new Dictionary<string, OpcGroup>();

        public OpcStatus Connect { get; set; }
        public OpcClient(Uri url)
        {
            string m_scheme = url.Scheme.ToLower();
            if ("opcda" == m_scheme)
            {
                _client = new Da.DaClient(url);
            }
            else if ("opc.tcp" == m_scheme)
            {
                _client = new Ua.UaClient(url);
            }
            try
            {
                _client.Connect();
                Connect = OpcStatus.Connected;
            }
            catch (Exception ex)
            {
                Connect = OpcStatus.NotConnected;
            }
        }
        public OpcClient(Uri url, ClientOptions options)
        {
            string m_scheme = url.Scheme;
            _options = options;
            if ("opcda" == m_scheme)
            {
                _client = new Da.DaClient(url, _options);
            }
            else if ("opc.tcp" == m_scheme)
            {
                _client = new Ua.UaClient(url, _options);
            }
            try
            {
                _client.Connect();
                Connect = OpcStatus.Connected;
            }
            catch (Exception ex)
            {
                Connect = OpcStatus.NotConnected;
            }

        }

        public OpcGroup AddGroup(string groupName)
        {
            OpcGroup _group = new OpcGroup();
            if (_groups.TryGetValue(groupName, out _group))
            {
                return _group;
            }
            else
            {
                _group = _client.AddGroup(groupName);
                _groups.Add(groupName, _group);
                return _group;
            }
        }
        public Result AddItems(string groupName, string[] itemName)
        {
            Result result = new Result();
            OpcGroup _group = new OpcGroup();
            if (_groups.TryGetValue(groupName, out _group))
            {
                result = _client.AddItems(groupName, itemName);
                return result;
            }
            else
            {
                _client.AddGroup(groupName);
                result = _client.AddItems(groupName, itemName);
                _groups.Add(groupName, _group);
                return result;
            }
        }

        public INode FindNode(string tag)
        {
            return _client.FindNode(tag);
        }

        public IEnumerable<INode> ExploreFolder(string tag)
        {
            return _client.ExploreFolder(tag);

        }

        public INode RootNode
        {
            get { return _client.RootNode; }
        }
        public T Read<T>(string itemName)
        {
            return _client.Read<T>(itemName);
        }
        public Task<T> ReadAsync<T>(string itemName)
        {
            return _client.ReadAsync<T>(itemName);
        }



        public void Write<T>(string itemName, T value)
        {
            _client.Write<T>(itemName, value);
        }

        public Task WriteAsync<T>(string itemName, T value)
        {
            return _client.WriteAsync<T>(itemName, value);
        }


    }
}
