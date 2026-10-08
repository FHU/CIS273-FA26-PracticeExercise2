namespace PracticeExercise2;

class Program
{
    static void Main(string[] args)
    {

        var linkedlist = new LinkedList<int>();
        linkedlist.Append(1);
        linkedlist.Append(2);
        linkedlist.Append(3);
        linkedlist.Append(4);
        // [1,2,3,4]
        linkedlist.RemoveAt(0);
        // [2,3,4]
        linkedlist.RemoveAt(-6);
        // throw IndexOutOfRangeException
    }
}

