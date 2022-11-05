namespace FamilyTree
{
    public class Program
    {
        static public void Main()
        {
            FamilyTree familyTree = new FamilyTree();
            familyTree.CreateFamilyTree(1,"gila",2,"alon");
            Console.WriteLine("CreateFamilyTree(1,\"gila\",2,\"alon\")");
            familyTree.Show();
            familyTree.HaveAKid(1, 2, 3, "dani", Gender.MALE);
            Console.WriteLine("HaveAKid(1, 2, 3, \"dani\", Gender.MALE);");
            familyTree.Show();
            familyTree.Divorce(1, 2, Custody.WithFather);
            Console.WriteLine("Divorce(1, 2, Custody.WithFather)");
            familyTree.Show();
            familyTree.Marry(3, 4, "valeria", Gender.FEMALE);
            Console.WriteLine("Marry(3, 4, \"valeria\", Gender.FEMALE)");
            familyTree.Show();
            familyTree.HaveAKid(4, 3, 5, "boris", Gender.MALE);
            Console.WriteLine("HaveAKid(4, 3, 5, \"boris\", Gender.MALE)");
            familyTree.Show();
        }
    }   
}