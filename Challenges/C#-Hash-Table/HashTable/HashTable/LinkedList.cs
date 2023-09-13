using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
	public class LinkedList<T>
	{
		public Node<T> Head { get; set; }

		public void Add(T value)
		{
			var newNode = new Node<T>(value);
			if (Head == null)
			{
				Head = newNode;
			}
			else
			{
				var current = Head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNode;
			}
		}

		

	}


}
