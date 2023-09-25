

namespace ConsoleApp1
{
    public class Employee
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            { return score.sum(); }
        }
    }
    List<int> score = new List<int>();
    public Employee (string Name, string SurName, int Age)
    {
        this.Name = Name;
        this.SurNamer = SurName;
        this.Age = Age;
    }
    public void AddScore(int points)
    {
        this.Score.Add(points);
    }
}
