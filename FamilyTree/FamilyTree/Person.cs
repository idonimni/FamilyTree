namespace FamilyTree
{
    public class Person
    {
        public Person(int id,string name,Gender gender,Person? spouse, Person? firstKid,Person? nextSibling)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Spouse = spouse;
            FirstKid = firstKid;
            NextSibling = nextSibling;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Person? Spouse { get; set; }
        public Person? FirstKid { get; set; }
        public Person? NextSibling { get; set; }
    }
}

