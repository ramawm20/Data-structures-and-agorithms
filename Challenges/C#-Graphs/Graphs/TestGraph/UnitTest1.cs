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
	}
}