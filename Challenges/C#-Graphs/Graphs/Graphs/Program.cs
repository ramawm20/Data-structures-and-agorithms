namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
           Graph<string> graph = new Graph<string>();

            Vertix<string> a = graph.addVertix("Amman");
            Vertix<string> b = graph.addVertix("Irbid");
            Vertix<string> c = graph.addVertix("Salt");

            //Completed Graph
            graph.addDirectEdge(a, b);
            graph.addDirectEdge(b, c);
            graph.addDirectEdge(c, a);

            graph.Print();
        }
    }
}