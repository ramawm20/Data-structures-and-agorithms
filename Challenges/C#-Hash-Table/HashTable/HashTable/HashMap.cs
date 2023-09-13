using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
	public  class HashMap
	{
		public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

		public HashMap(int size)
		{
			Map = new LinkedList<KeyValuePair<string, string>>[size];
		}

		public int Hash(string key)
		{
			int hashValue = 0;
			char[] letters = key.ToCharArray();
			for (int i=0;i<letters.Length; i++)
			{
				hashValue += letters[i];
			}
			hashValue= (hashValue +599) % Map.Length;

			return hashValue;
		}

		public void Set(string key, string value)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] == null)
			{
				Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();	
			}
			KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
			Map[hashKey].Add(entry);
		}

		public void Print()
		{
			
			for(int i=0;i<Map.Length;i++)
			{
				if (Map[i] == null)
				{
					Console.WriteLine($"Bucket {i} : is Empty");
			}
				else
				{
					Console.WriteLine($"Backet {i} ");
					Node<KeyValuePair<string, string>> current = Map[i].Head;
					while (current != null)
					{
						Console.WriteLine($"{current.Value.Key} : {current.Value.Value} => ");
						current = current.Next;
					}
				}
				
			}
		}
		public string Get(string key)
		{
			int hashKey = Hash(key);
			var bucket = Map[hashKey];
			var current = bucket?.Head;

			while (current != null)
			{
				if (current.Value.Key == key)
				{
					return current.Value.Value;
				}
				current = current.Next;
			}

			return null;
		}

		public bool Has(string key)
		{
			int hashKey = Hash(key);
			var bucket = Map[hashKey];
			var current = bucket?.Head;

			while (current != null)
			{
				if (current.Value.Key == key)
				{
					return true;
				}
				current = current.Next;
			}

			return false;
		}
		public IEnumerable<string> Keys()
		{
			List<string> keys = new List<string>();

			foreach (var bucket in Map)
			{
				if (bucket != null)
				{
					var current = bucket?.Head;

					while (current != null)
					{
						keys.Add(current.Value.Key);
						current = current.Next;
					}
				}
			}

			return keys;
		}



	}
}
