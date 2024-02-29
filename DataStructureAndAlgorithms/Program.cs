using Array = DataStructureAndAlgorithms.Arrays.Array;
using DataStructureAndAlgorithms.LinkedList;
using DataStructureAndAlgorithms.Stack;
using DataStructureAndAlgorithms.Sorting;
using DataStructureAndAlgorithms.Queue;
using DataStructureAndAlgorithms.Test;
using System.Data;
using static DataStructureAndAlgorithms.Test.Test2;
using System.Xml.XPath;

#region Array

var array = new Array(3);

// array.Insert(1);
// array.Insert(2);
// array.Insert(3);
// array.Insert(4);
// array.Insert(5);

// array.InsertAt(8, 3);
// array.Print();

#endregion

#region LinkedList

// var linkedList = new LinkedList();

// linkedList.AddLast(1);
// linkedList.AddLast(2);
// linkedList.AddLast(3);
// linkedList.AddLast(4);

// System.Console.WriteLine(linkedList.GetKthNodeFromTheEnd(2));

#endregion

#region Stacks

//System.Console.WriteLine(StringReverser.Reverse("Farshad"));
//System.Console.WriteLine(Expression.IsBalanced("([](Test))<>"));

//Stack stack = new();

//stack.Push(10);
//stack.Push(20);
//stack.Push(30);

//System.Console.WriteLine(stack.Pop());
//System.Console.WriteLine(stack.Pop());
//System.Console.WriteLine(stack.Pop());

//stack.Pop();

#endregion

#region Queues
// Queue<int> queue = new();
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.Enqueue(4);

// Console.WriteLine(string.Join(", ", queue));

// queue = queue.Reverse();

// Console.WriteLine(string.Join(", ", queue));

#endregion

#region Sorting

// int[] sortedList = new int[] { 3, 4, 2, 8, 1, 10, 3, 11 };
// sortedList.SelectionSort();
// Console.WriteLine(string.Join(", ", sortedList));

#endregion

#region Test
// Node node1 = new(1);
// Node node2 = new(2);
// Node node3 = new(3);
// Node node4 = new(4);
// Node node5 = new(5);

// node1.next = node2;
// node2.child = node3;
// node3.next = node4;
// node2.next = node5;

// Test2 test = new();
// Node result = test.Flatten(node1);
#endregion


Console.ReadKey();