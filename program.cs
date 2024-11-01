using System;
namespace Graph_dsa
{
    public class Graph
    {
        private class Node
        {
            public string lable;
            public Node(string lable)
            {
                this.lable = lable;
            }
        }
        Dictionary<string, Node> _nodes = new Dictionary<string, Node>();
        Dictionary<Node, List<Node>> adjaencylist = new Dictionary<Node, List<Node>>();
         public void add_node(string data)
        {
            Node node = new Node(data); 
            _nodes.TryAdd(data, node);
            adjaencylist.TryAdd(node, new List<Node>());
        }
        public void add_edge(string from, string to)
        {
            var fromnode = _nodes[from];
            if (fromnode == null)
            {
                throw new Exception("from node is not parsent");
            }
            var tonode = _nodes[to];
            if (tonode == null)
            {
                throw new Exception("to node is noy parsent");
            }
            adjaencylist[fromnode!].Add(tonode!);
        }
    }

    public class Progarm
    {
        static void Main()
        {

        }
    }
}
