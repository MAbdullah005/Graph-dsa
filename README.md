Graph Data Structure in C#

Description
This project implements a graph data structure in C#. It allows for creating a graph, adding vertices and edges, and includes algorithms for Depth-First Search (DFS), Breadth-First Search (BFS), cycle detection, and topological sorting.

Features

Graph Representation: Uses an adjacency list to store graph connections.

Adding Nodes: Methods to add vertices (nodes) to the graph.

Adding Edges: Methods to create connections (edges) between nodes.

Depth-First Search (DFS): Traverse the graph using recursive and iterative methods.

Breadth-First Search (BFS): Traverse the graph level by level.

Cycle Detection: Check if the graph contains cycles.

Topological Sorting: Get a linear ordering of vertices based on their dependencies.

Installation

Clone the repository:https://github.com/MAbdullah005/Graph-dsa.git
bash
Copy code

git clone https://github.com/MAbdullah005/Graph-dsa

Open the project in Visual Studio or your preferred C# IDE.

Build the solution.

Usage
To run the example, execute the Main method in the Progarm class. You can modify the graph by adding nodes and edges as needed.

Example
Copy code

Graph graph = new Graph();

graph.add_node("A");
      
graph.add_node("B");

graph.add_node("C");

graph.add_node("D

graph.add_edge("A", "B");

graph.add_edge("A", "C");

graph.add_edge("A", "D");

graph.add_edge("B", "D");

graph.add_edge("C", "A");

graph.add_edge("D", "B");


Console.WriteLine(graph.cycleDetection()); // Check for cycles

Methods

add_node(string data): Adds a new node to the graph.

add_edge(string from, string to): Creates a directed edge from one node to another.

print(): Displays the graph's connections.

remove(string data): Removes a node and its associated edges.

remove_edge(string from, string to): Removes an edge between two nodes.

Depth_first(string data): Performs DFS from the specified node.

breadth_first(string data): Performs BFS from the specified node.

cycleDetection(): Returns true if there’s a cycle in the graph.

topological_order(): Returns a list of nodes in topological order.

Contributing

Contributions are welcome! Feel free to submit issues or pull requests.    


MIT License

Copyright (c) 2024 Abdullah005

Permission is hereby granted, free of charge, to any person obtaining a copy

of this software and associated documentation files (the "Software"), to deal

in the Software without restriction, including without limitation the rights

to use, copy, modify, merge, publish, distribute, sublicense, and/or sell


copies of the Software, and to permit persons to whom the Software is

furnished to do so, subject to the following conditions:

- The above copyright notice and this permission notice shall be included
- 
- in
  all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR

IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,

FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE

AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
