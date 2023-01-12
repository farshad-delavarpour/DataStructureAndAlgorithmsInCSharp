using DataStructureAndAlgorithms.Arrays;

var array = new DataStructureAndAlgorithms.Arrays.Array(3);

array.Insert(1);
array.Insert(2);
array.Insert(3);
array.Insert(4);
array.Insert(5);

array.RemoveAt(3);

array.Print();

System.Console.WriteLine(array.IndexOf(3));

Console.ReadKey();