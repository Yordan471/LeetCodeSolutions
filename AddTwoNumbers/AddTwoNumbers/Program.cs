using AddTwoNumbers;
using System.Collections.Generic;
using System.Text;

LinkedList<int> linked = new();
LinkedList<int> linked2 = new();

int firstCount = int.Parse(Console.ReadLine());

for (int i = 0; i < firstCount; i++)
{
    linked.AddLast(int.Parse(Console.ReadLine()));
}

int secondCount = int.Parse(Console.ReadLine());

for (int i = 0;i < secondCount; i++)
{
    linked2.AddLast(int.Parse(Console.ReadLine()));
}

StringBuilder firstLinked = new();
StringBuilder secondLinked = new();

while (linked.Count > 0)
{
    firstLinked.Append(linked.Last());
    linked.RemoveLast();
}

while (linked2.Count > 0)
{    
    secondLinked.Append(linked2.Last());    
    linked2.RemoveLast();
}

LinkedList<int> linked3 = new();

string thirdLinked = (int.Parse(firstLinked.ToString()) + int.Parse(secondLinked.ToString())).ToString();
int thirdLinkedInt = int.Parse(thirdLinked);

while (thirdLinkedInt != 0)
{
    int lastNumber = thirdLinkedInt % 10;
    thirdLinkedInt /= 10;
    linked3.AddLast(lastNumber);
}

foreach (var number in linked3)
{
    Console.Write(number);
}

// ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//{
//
//}