using Welp.PowerCollections;
Welp.PowerCollections.Stack<char> stack = new();

stack.Push('G');
stack.Push('I');

Console.WriteLine("Размер стека: " + stack.Capacity);
Console.WriteLine("Работа метода top: " + stack.Top() + "(" + stack.Count + ")");
Console.WriteLine("Работа метода pop: " + stack.Pop() + "(" + stack.Count + ")");
