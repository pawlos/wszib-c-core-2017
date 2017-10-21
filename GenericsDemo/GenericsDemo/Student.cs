namespace GenericsDemo
{
    internal class Student : Human, IStudent
    {
        public int Id { get; }
        public string FirstName { get; }

        public Student()
        {

        }
        public Student(int id, string firstName)
        {
            Id = id;
            FirstName = firstName;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return "Jestem studentem";
        //}
    }
}