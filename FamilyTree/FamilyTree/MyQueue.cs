namespace FamilyTree
{
    public class MyQueue
    {
        MyNode? head;
        MyNode? tail;

        public void Enqueue(Person element)
        {
            MyNode temp = new MyNode(element);
            if (head == null)
                head = tail = temp;
            else
            {
                tail.Next = temp;
                tail = temp;
            }
        }

        public Person Dequeue()
        {
            Person temp = head.Element;
            head = head.Next;
            return temp;
        }

        public bool Any()
        {
            return head != null;
        }
    }

    

}

