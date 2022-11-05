namespace FamilyTree
{
    public class FamilyTree
    {
        public Root? Root { get; set; }

        public void CreateFamilyTree(int motherId,string motherName,int fatherId,string fatherName)
        {
            Person father = new Person(fatherId, fatherName, Gender.MALE, null,null,null);
            Person mother = new Person(motherId, motherName, Gender.FEMALE, null,null,null);
            Root = new Root(mother, father);
        }

        public void HaveAKid(int motherId,int fatherId,int kidId,string kidName,Gender kidGender)
        {
            Person? mother = findPersonById(motherId);
            Person? father = mother.Spouse;
            if (father == null) return;
            Person kid = new Person(kidId, kidName, kidGender,null,null,null);

            if (mother.FirstKid == null)
            {
                mother.FirstKid = kid;   
            }
            else
            {
                mother.FirstKid.NextSibling = kid;
            }

            if (father.FirstKid == null)
            {
                father.FirstKid = kid;
            }
            else
            {
                father.FirstKid.NextSibling = kid;
            }
        }

        public void Marry(int id,int otherId,string otherName,Gender otherGender)
        {
            Person? existingPerson = findPersonById(id);
            if (existingPerson.Spouse != null)
            {
                return;
            }
            Person otherPerson = new Person(otherId, otherName, otherGender, existingPerson,null,null);
            existingPerson.Spouse = otherPerson;
        }

        public void Divorce(int motherId,int fatherId, Custody custody)
        {
            Person? mother = findPersonById(motherId);
            Person? father = mother.Spouse;
            if (father == null)
            {
                return;
            }
            mother.Spouse = null;
            father.Spouse = null;
            if(custody == Custody.WithFather)
            {
                mother.FirstKid = null;
            }
            else
            {
                father.FirstKid = null;
            }

        }

        public void Show()
        {
            Console.WriteLine("*************************************");
            MyList visited = new MyList();
            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(Root.Father);
            while (queue.Any())
            {
                Person? visitedPerson = queue.Dequeue();
                Console.WriteLine(visitedPerson.Name);
                if (!visited.IsExist(visitedPerson))
                {
                    visited.Add(visitedPerson);
                }
                Person? spouse = visitedPerson.Spouse;
                if (spouse != null && !visited.IsExist(spouse))
                {
                    queue.Enqueue(spouse);
                    visited.Add(spouse);
                }
                Person currentKid = visitedPerson.FirstKid;
                while (currentKid != null && !visited.IsExist(currentKid))
                {
                    queue.Enqueue(currentKid);
                    visited.Add(currentKid);
                    currentKid = currentKid.NextSibling;
                }
            }
            Console.WriteLine("");
        }

        private Person? findPersonById(int Id)
        {
            MyList visited = new MyList();
            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(Root.Father);
            while (queue.Any())
            {
                Person? visitedPerson = queue.Dequeue();
                if (visitedPerson.Id == Id)
                {
                    return visitedPerson;
                }
                if (!visited.IsExist(visitedPerson))
                {
                    visited.Add(visitedPerson);
                }
                Person? spouse = visitedPerson.Spouse;
                if (spouse!=null && !visited.IsExist(spouse) )
                {
                    queue.Enqueue(spouse);
                    visited.Add(spouse);
                }
                Person currentKid = visitedPerson.FirstKid;
                while (currentKid != null && !visited.IsExist(currentKid))
                {
                    queue.Enqueue(currentKid);
                    visited.Add(currentKid);
                    currentKid = currentKid.NextSibling;
                }
            }
            return null;
        }
    }
}
