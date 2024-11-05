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
         public void print()
        {
            ICollection<Node> nodes = adjaencylist.Keys;
            foreach (var source in adjaencylist.Keys)
            {
                var targets = adjaencylist[source];
                if (targets != null)
                {
                    foreach (var target in targets)
                    {
                        Console.WriteLine(source + " is connected to " + target);
                    }
                }
            }
        }
          public void remove(string data)
        {
            var node = _nodes[data];
            if (node == null) return;
            foreach (var source in adjaencylist.Keys)
            {
                adjaencylist[(source)].Remove(node);
            }
            adjaencylist.Remove(node);
            _nodes.Remove(data);
        }
        public void remove_edge(string from, string to)
        {
            var fromnode = _nodes[from];
            var tonode = _nodes[to];
            if (fromnode == null || tonode == null)
            {
                return;
            }
            adjaencylist[fromnode!].Remove(tonode!);
        }
         public void Depth_fist(string data)
        {
            if (data == null)
            {
                return;
            }
            if (_nodes.ContainsKey(data))
            {
                var node = _nodes[data];
                if (node == null) return;
                Depth_fist(adjaencylist, node, new HashSet<Node>());
            }

        }
        private void Depth_fist(Dictionary<Node, List<Node>> adjecent, Node node, HashSet<Node> set)
        {
            if (!set.Contains(node))
            {
                Console.WriteLine(node.lable);
            }
            foreach (var source in adjecent[node])
            {
                Depth_fist(adjecent, source, set);
                set.Add(source);
            }
        }
        public void depthfist_iteration(string data)
        {
            if (_nodes.ContainsKey(data))
            {
                Console.WriteLine("[" + data + "]");
                var node = _nodes[data];
                foreach (var source in adjaencylist[node])
                {
                    Console.WriteLine(source);
                    if (source != null)
                    {
                        foreach (var i in adjaencylist[source])
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
        public void depthfist_iteration_mosh(string data)
        {
            Stack<Node> stack = new Stack<Node>(); 
            HashSet<Node> set = new HashSet<Node>();
            if (_nodes.ContainsKey(data))
            {
                var node= _nodes[data];
                stack.Push(node);
                while(stack.Count > 0)
                {
                    var current=stack.Pop();
                    if (set.Contains(current))
                        continue;
                    Console.WriteLine(current);
                    set.Add(current);
                    foreach(var nigbour in adjaencylist[current])
                    {
                        if(!set.Contains(nigbour))
                        {
                            stack.Push(nigbour);
                        }
                    }
                }
            }
        }
         public void breast_fist(string data)
        {
            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> set = new HashSet<Node>();
            if (_nodes.ContainsKey(data))
            {
                var current = _nodes[data];
                queue.Enqueue(current);
                while (queue.Count > 0)
                {
                    var node= queue.Dequeue();
                    if(set.Contains(node))
                        continue;
                    Console.WriteLine(node);
                    set.Add((Node)node);
                    foreach(var nigbour in adjaencylist[node])
                    {
                        if(!set.Contains((Node)nigbour))
                        {
                            queue.Enqueue(nigbour);
                        }
                    }
                }
            }
        }
         public List<string> topological_order()
        {
           Stack<Node> stack = new Stack<Node>();
            HashSet<Node> set = new HashSet<Node>();
            foreach(var node in _nodes.Values)
            {
                topological_order(node, set, stack);
            }
            List<string> list = new List<string>();
            while(stack.Count > 0)
            {
                list.Add(stack.Pop().lable);
            }
            return list;
        }
        private void topological_order(Node node,HashSet<Node> set,Stack<Node> stack)
        {
            if(set.Contains(node))return;
            set.Add(node);
            foreach(var child in adjaencylist[node])
            {
                topological_order(child, set, stack);
            }
            stack.Push(node);
        }
         public bool cycleDetection()
        {
            HashSet<Node> all = new HashSet<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            HashSet<Node> visiting = new HashSet<Node>();
            foreach(var node in _nodes.Values)
            {
                all.Add(node);
            }

            while(all.Count > 0)
            {
                var current = all.ToArray()[0];
                if (cycleDetection(current, all, visiting, visited))
                {
                    return true;
                }
            }
            return false;
        }
        private bool cycleDetection(Node node,HashSet<Node> all,HashSet<Node> visiting,HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);
            foreach(var nigbur in adjaencylist[node])
            {
                if(visited.Contains(nigbur))
                    continue; 
                if(visiting.Contains(nigbur))
                {
                    return true;
                }
                if (cycleDetection(nigbur, all, visiting, visited))
                {
                    return true;
                }
            }
            visiting.Remove(node);
            visited.Add(node);
            return false;
        }
    }

    public class Progarm
    {
        static void Main()
        {
             graph.add_node("A");
            graph.add_node("B");
            graph.add_node("C");
            graph.add_node("D");
            graph.add_edge("A", "B");
            graph.add_edge("A", "C");
            graph.add_edge("A", "D");
            graph.add_edge("B", "D");
            graph.add_edge("C", "A");
            graph.add_edge("D", "B");
            graph.print();
        }
    }
}
