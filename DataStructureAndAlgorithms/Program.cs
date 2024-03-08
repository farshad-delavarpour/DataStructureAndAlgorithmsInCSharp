using Array = DataStructureAndAlgorithms.Arrays.Array;
using DataStructureAndAlgorithms.Sorting;
using DataStructureAndAlgorithms.Queue;
using DataStructureAndAlgorithms.Test;
using static DataStructureAndAlgorithms.Test.Test2;
using System.Xml.XPath;
using DataStructureAndAlgorithms.Searching;
using DataStructureAndAlgorithms.StringManipulation;
using System.Text;
using static DataStructureAndAlgorithms.Test.LeetCode;

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

int[] list = new int[] { 7, 3, 1, 9, 5, 5, 4, 2, 11, 123, 23, 13, 115, 9 };
Sorting.QuickSort(list, 0, list.Length - 1);

// Sorting.CountSorting(list);


// Console.WriteLine(string.Join(", ", sortedList));

#endregion

#region StringManipulation
//Console.WriteLine(StringManipulator.GetVowelsCount("Hi my name is farshad"));
//Console.WriteLine(StringManipulator.Reverse("Hi my name is farshad"));
//Console.WriteLine(StringManipulator.ReverseWords("Hi my name is farshad"));
//Console.WriteLine(StringManipulator.IsRotation("ABCDE", "BCDEA"));
//Console.WriteLine(StringManipulator.IsRotation("ABCDE", "BCDDS"));
//Console.WriteLine(StringManipulator.RemoveDuplicate("HeeeLLLoo!!"));
//Console.WriteLine(StringManipulator.GetMostRepeatedChar("Heeeloo!!"));
//Console.WriteLine(StringManipulator.GetMostRepeatedCharWithOutHashTable("Hi Agaaain!"));
//Console.WriteLine(StringManipulator.CapitalizeAndRemoveSpace("coulD    yOU  plEAsE    work?"));
//Console.WriteLine(StringManipulator.IsAnagram("ABCDEFG", "GFABCDE"));
#endregion

#region Test
//var result = Test2.GcdOfStrings("ABABAB", "ABABAB");
//var result = Test.Compress(new char[7] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });

ListNode node = new (10, new ListNode(5, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, null))))));
//LeetCode.ReverseList(node);
LeetCode.PairSum(node);
#endregion


Console.ReadKey();