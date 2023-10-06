

using DSA_Hash_Tables;

HashTable hashTable = new HashTable();

hashTable.Set("Justin", "661-234-1313");
hashTable.Set("Jayden", "661-131-4411");
hashTable.Set("Jessica", "661-313-1341");
hashTable.Set("Sarah", "661-913-4625");
hashTable.Set("Batman", "661-141-1451");


Console.WriteLine(hashTable.Get("Justin"));
Console.WriteLine(hashTable.Get("Jayden"));
Console.WriteLine(hashTable.Get("Jessica"));
Console.WriteLine(hashTable.Get("Sarah"));
Console.WriteLine(hashTable.Get("Batman"));




