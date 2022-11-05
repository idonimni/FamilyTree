namespace FamilyTree
{
    class MyNode
    {
        public MyNode(Person val)
        {
            Element = val;
        }
        public Person Element { get; set; }
        public MyNode? Next { get; set; }
    }
}

