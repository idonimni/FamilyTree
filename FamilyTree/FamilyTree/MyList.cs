namespace FamilyTree
{
    public class MyList
    {
        MyNode? head;

        public void Add(Person element)
        {
            MyNode temp = new MyNode(element);
            if (head == null)
                head = temp;
            else
            {
                temp.Next = head;
                head = temp;
            }
        }

        public bool IsExist(Person element)
        {
            MyNode currentNode = head;
            
            while (currentNode != null)
            {
                if(currentNode.Element.Id == element.Id)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}

