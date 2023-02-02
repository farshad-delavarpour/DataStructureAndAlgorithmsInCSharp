using DataStructureAndAlgorithms.Arrays;
using DataStructureAndAlgorithms.LinkedList;
using DataStructureAndAlgorithms.Stack;

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

// var linkedList = new LinkedList();

// linkedList.AddLast(1);
// linkedList.AddLast(2);
// linkedList.AddLast(3);
// linkedList.AddLast(4);

// System.Console.WriteLine(linkedList.GetKthNodeFromTheEnd(2));

#endregion

#region Stacks

System.Console.WriteLine(StringReverser.Reverse("Farshad"));
System.Console.WriteLine(Expression.IsBalanced("([](Test))<>"));

Stack stack = new();

stack.Push(10);
stack.Push(20);
stack.Push(30);

System.Console.WriteLine(stack.Pop());
System.Console.WriteLine(stack.Pop());
System.Console.WriteLine(stack.Pop());

stack.Pop();

#endregion
Console.ReadKey();