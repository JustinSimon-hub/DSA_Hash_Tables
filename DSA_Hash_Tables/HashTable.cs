using System;
namespace DSA_Hash_Tables
{
	public class HashTable
	{
		public string[] _hashTable { get; set; }
		public HashTable()
		{
			_hashTable = new string[10];
		}
		//***convention to put the private methods at the top above public methods
		//this is a VERY VERY weak hashing algo, for educational purposes dont use in real environment

		private int _hash(string key)
		{
			return key.Length % _hashTable.Length;
		}
		public string Get(string key)
		{
			int hashedKey = _hash(key);
			return _hashTable[hashedKey];
		}

		public void Set(string key , string value)
		{
			//key is going to be hashed 
			int hashedKey = _hash(key);
			if (_hashTable[hashedKey] != null)
			{
				Console.WriteLine("sorry hash collision has occurred");
			}
			else
			{
				_hashTable[hashedKey] = value;
			}

		}
	}
}

