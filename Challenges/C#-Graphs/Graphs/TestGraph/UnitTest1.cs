using Graphs;

namespace TestGraph
{
	public class UnitTest1
	{
		[Fact]
		public void VertexCanBeSuccessfullyAddedToGraph()
		{
			// Arrange
			var graph = new Graph<int>();

			// Act
			var vertex = graph.addVertix(1);

			// Assert
			Assert.Contains(vertex, graph.GetVertices());
		}
		[Fact]
		public void EdgeCanBeSuccessfullyAddedToGraph()
		{
			// Arrange
			var graph = new Graph<int>();
			var vertexA = graph.addVertix(1);
			var vertexB = graph.addVertix(2);

			// Act
			graph.addDirectEdge(vertexA, vertexB);

			// Assert
			var neighborsOfA = graph.GetNeighbors(vertexA);
			Assert.Single(neighborsOfA);
			Assert.Equal(2, neighborsOfA[0].vertix.Value);
		}
		 [Fact]
        public void CollectionOfAllVerticesCanBeProperlyRetrieved()
        {
            // Arrange
            var graph = new Graph<int>();
            graph.addVertix(1);
            graph.addVertix(2);

            // Act
            var vertices = graph.GetVertices();

            // Assert
            Assert.Equal(2, vertices.Count);
        }

        [Fact]
        public void AppropriateNeighborsCanBeRetrievedFromGraph()
        {
            // Arrange
            var graph = new Graph<int>();
            var vertexA = graph.addVertix(1);
            var vertexB = graph.addVertix(2);
            graph.addDirectEdge(vertexA, vertexB);

            // Act
            var neighborsOfA = graph.GetNeighbors(vertexA);

            // Assert
            Assert.Single(neighborsOfA);
            Assert.Equal(2, neighborsOfA[0].vertix.Value);
        }

        [Fact]
        public void NeighborsAreReturnedWithWeightBetweenVerticesIncluded()
        {
            // Arrange
            var graph = new Graph<int>();
            var vertexA = graph.addVertix(1);
            var vertexB = graph.addVertix(2);
            graph.addDirectEdge(vertexA, vertexB);

            // Act
            var neighborsOfA = graph.GetNeighbors(vertexA);

            // Assert
            
            Assert.Equal(2, neighborsOfA[0].vertix.Value);
            Assert.Equal(0, neighborsOfA[0].Weight);
        }

        [Fact]
        public void ProperSizeIsReturnedRepresentingNumberOfVertices()
        {
            // Arrange
            var graph = new Graph<int>();
            graph.addVertix(1);
            graph.addVertix(2);

            // Act
            int size = graph.size;

            // Assert
            Assert.Equal(2, size);
        }

        [Fact]
        public void GraphWithOnlyOneVertexAndEdgeCanBeProperlyReturned()
        {
            // Arrange
            var graph = new Graph<int>();
            var vertexA = graph.addVertix(1);
            var vertexB = graph.addVertix(2);
            graph.addDirectEdge(vertexA, vertexB);

            // Act
            var vertices = graph.GetVertices();
            var neighborsOfA = graph.GetNeighbors(vertexA);

            // Assert
            Assert.Equal(2, neighborsOfA[0].vertix.Value);
        }

		[Fact]
		public void TestBreadthFirstNotExistNode()
		{
			// Arrange
			Graph<int> graph = new Graph<int>();
			var node1 = new Vertix<int>(1);
			var node2 = new Vertix<int>(2);

			graph.addUndirectEdge(node1, node2);

			// Act and Assert
			Assert.Throws<Exception>(() => graph.BreadthFirst(new Vertix<int>(3)));
		}

		[Fact]
		public void TestBreadthFirstTraversal()
		{
			// Arrange
			Graph<int> graph = new Graph<int>();
			var node1 = new Vertix<int>(1);
			var node2 = new Vertix<int>(2);
			var node3 = new Vertix<int>(3);
			var node4 = new Vertix<int>(4);

			graph.addUndirectEdge(node1, node2);
			graph.addUndirectEdge(node1, node3);
			graph.addUndirectEdge(node2, node4);

			// Act
			var result = graph.BreadthFirst(node1);

			// Assert
			var expectedOrder = new List<Vertix<int>> { node1, node2, node3, node4 };
			Assert.Equal(expectedOrder, result);
		}
		[Fact]
		public void TestDepthFirst()
		{
			// Arrange
			var graph = new Graph<string>();
			var a = graph.addVertix("A");
			var b = graph.addVertix("B");
			var c = graph.addVertix("C");
			var d = graph.addVertix("D");
			var e = graph.addVertix("E");
			var f = graph.addVertix("F");

			graph.addDirectEdge(a, b);
			graph.addDirectEdge(a, c);
			graph.addDirectEdge(b, d);
			graph.addDirectEdge(b, e);
			graph.addDirectEdge(c, f);

			// Act
			var result = graph.DepthFirst(a);

			// Assert
			Assert.Equal(new List<string> { "A", "B", "D", "E", "C", "F" }, result.ConvertAll(v => v.Value));
		}

		[Fact]
		public void TestDepthFirstSingleNode()
		{
			// Arrange
			var graph = new Graph<string>();
			var a = graph.addVertix("A");

			// Act
			var result = graph.DepthFirst(a);

			// Assert
			Assert.Equal("A", result[0].Value);
		}

		[Fact]
		public void TestDepthFirstEmptyList()
		{
			// Arrange
			var graph = new Graph<string>();

			// Act
			var result = graph.DepthFirst(null); // Pass null as the starting node

			// Assert
			Assert.Empty(result);
		}
	
}
}