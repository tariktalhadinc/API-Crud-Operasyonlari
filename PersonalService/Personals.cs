using System.Reflection.Metadata;

namespace PersonalService
{

    public class Personal //Personal
    {
        public int Id { get; set; }

        public string NationalId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        internal static object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}