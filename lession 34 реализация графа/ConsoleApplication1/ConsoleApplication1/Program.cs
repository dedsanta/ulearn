using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Node
    {
        public readonly List<Node> IncidentNodes = new List<Node>();
    }

    public class Graph
    {
        public readonly List<Node> Nodes = new List<Node>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            var v1 = new Node();
            var v2 = new Node();
            v1.IncidentNodes.Add(v2);
            graph.Nodes.Add(v1);
            graph.Nodes.Add(v2);

        }
    }
}
