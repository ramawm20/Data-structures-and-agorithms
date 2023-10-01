using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertix<T>
    {
        public T Value { get; set; }
        public Vertix(T data)
        {
            Value = data;
        }
    }
    public class Edge<T>
    {
        public int Weight { get; set; }

        public Vertix<T> vertix { get; set; }
    }
        public  class Graph<T>
    {
        public Dictionary<Vertix<T> , List<Edge<T>>> AdjacencyList { get; set; }

        public int size = 0;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertix<T>, List<Edge<T>>>();

        }

        public Vertix<T> addVertix(T vertix)
        {
            Vertix<T> node = new Vertix<T>(vertix);

            AdjacencyList.Add(node, new List<Edge<T>>());
            size++;

            return node;
        }
        public void addDirectEdge(Vertix<T> vA,Vertix<T> vB)
        {
            AdjacencyList[vA].Add(new Edge<T>
            {
                Weight = 0,
                vertix = vB,
            });
        }
        public void addUndirectEdge (Vertix<T> a,Vertix<T> b)
        {
            addDirectEdge(a, b);
            addDirectEdge(b, a);
        }

        public List<Edge<T>> GetNeighbors(Vertix<T> vertix)
        {
            return AdjacencyList[vertix];
        }
        public void Print()
        {
            foreach(var item in AdjacencyList)
            {
                Console.Write($"Vertix {item.Key.Value} =>");
                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.vertix.Value} => ");
                }
                Console.WriteLine();
            }
        }
		public List<Vertix<T>> GetVertices()
		{
			List<Vertix<T>> vertices = new List<Vertix<T>>(AdjacencyList.Keys);
			return vertices;
		}

	}
}
