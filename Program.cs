Queue<int> myQueue = new Queue<int>();
string input;
Console.WriteLine("Введите элементы очереди");
while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
{
    int number = int.Parse(input);
    myQueue.Enqueue(number);
}
myQueue.PrintQueue();


