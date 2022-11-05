namespace FamilyTree
{
    public class Root
    {
        public Root(Person mother, Person father)
        {
            Mother = mother;
            Father = father;
            Mother.Spouse = Father;
            Father.Spouse = Mother;
        }

        public Person Mother { get; set; }
        public Person Father { get; set; }
    }
}

