using DataStructureAndAlgorithms.Arrays;
using DataStructureAndAlgorithms.LinkedList;

#region Array

// var array = new DataStructureAndAlgorithms.Arrays.Array(3);

// array.Insert(1);
// array.Insert(2);
// array.Insert(3);
// array.Insert(4);
// array.Insert(5);

// array.InsertAt(8, 3);
// array.Print();

#endregion

#region LinkedList

var linkedList = new LinkedList();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);

linkedList.Reverse();

linkedList.Print();
#endregion

Console.ReadKey();