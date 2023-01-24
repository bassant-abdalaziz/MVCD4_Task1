namespace MVCD1.Models
{
    public class SampleData
    {
        private static List<Visitor> visitors = new List<Visitor>()
        {
            new Visitor() {Name="ali",Email="Ali123@gmail.com",Phone="01116245287",willAttend="true" },
            new Visitor() {Name="bassant",Email="bassant55@gmail.com",Phone="01210258732",willAttend="true" },
            new Visitor() {Name="mona",Email="mona12@gmail.com",Phone="01215892732", willAttend = "true"},
            new Visitor() {Name="aya",Email="aya2@gmail.com",Phone="012134532", willAttend = "no"}
        };
        public static List<Visitor> Visitors { get => visitors; }

        public static void AddVisitor(Visitor visitor)
        {
            visitors.Add(visitor);
        }

    }
}
