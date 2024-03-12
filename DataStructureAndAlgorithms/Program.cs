using Array = DataStructureAndAlgorithms.Arrays.Array;
using DataStructureAndAlgorithms.Sorting;
using DataStructureAndAlgorithms.Queue;
using DataStructureAndAlgorithms.Test;
using static DataStructureAndAlgorithms.Test.Test2;
using System.Xml.XPath;
using DataStructureAndAlgorithms.Searching;
using DataStructureAndAlgorithms.StringManipulation;
using System.Text;
using DataStructureAndAlgorithms.BinaryTrees;
using DataStructureAndAlgorithms.AVLTrees;
using DataStructureAndAlgorithms.Tries;

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

//int[] list = new int[] { 7, 3, 1, 9, 5, 5, 4, 2, 11, 123, 23, 13, 115, 9 };
//Sorting.QuickSort(list, 0, list.Length - 1);

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

//LeetCode.ReverseList(node);
//int[] list2 = new int[] { 10, 2, -5, 1, 2, -3, 11, 12, -5, -7, -13, 20 };
//int[] list3 = new int[] { -10, -22, -5, 1, 2, -3, 11, 12, -5, -7, -13, 20 };

//var test = DataStructureAndAlgorithms.Test.Random.PivotIndex(list2);
//var test2 = DataStructureAndAlgorithms.Test.Random.RemoveStars("*Farr*shadhe**");
//var test3 = DataStructureAndAlgorithms.Test.Random.AsteroidCollision(list2);
//var test33 = DataStructureAndAlgorithms.Test.Random.AsteroidCollision(list3);
#endregion

#region Tree
//BinaryTree tree = new();
//tree.Add(7);
//tree.Add(8);
//tree.Add(10);
//tree.Add(4);
//tree.Add(5);
//tree.Add(4);
//tree.Add(9);
//tree.TraversePreOrder();
//Console.WriteLine("-----------------");
//tree.TraverseInOrder();
//Console.WriteLine("-----------------");
//tree.TraversePostOrder();
//Console.WriteLine("-----------------");
//Console.WriteLine(tree.Min());
//Console.WriteLine("-----------------");
//Console.WriteLine(tree.IsBinarySearchTree());
#endregion

#region AVLNode
//AVLTree avlTree = new();
//avlTree.Insert(10);
//avlTree.Insert(20);
//avlTree.Insert(30);
#endregion

#region Trie
//Trie trie = new();
//trie.Insert("mobile");
//trie.Insert("mouse");
//trie.Insert("monitor");
//trie.Insert("mousepad");
//string[] products = new string[5] { "mobile", "mouse", "monitor", "mousepad", "moneypot" };

//TrieRandom trieRandom = new();
//IList<IList<string>> result = trieRandom.SuggestedProducts(products, "mouse");
//var resu2lt = TrieRandom.CalculateFactorial(5);

StringTrie trie = new("First");
trie.Insert("First", "First-Child1");
trie.Insert("First", "First-Child2");
trie.Insert("First-Child1", "Child1-child1");
trie.Insert("First-Child1", "Child1-child2");
trie.Insert("First-Child2", "Child2-child1");
trie.Insert("First-Child2", "Child2-child2");
trie.PrintInOrder();

#endregion
Console.ReadKey();