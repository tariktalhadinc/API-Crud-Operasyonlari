
namespace PersonalService
{
    class PersonalService
    {
        static void Main()
        {
            //int Id = 1;
            //string NationalId = "13595581054";
            //string Name = "Tarık";
            //string Surname = "Dinç";
            //int Age = 20;



            Personal personal = new(1,"13595581052","Tarık","Dinç",20);

            Console.WriteLine(personal.Id);
            Console.WriteLine(personal.NationalId);
            Console.WriteLine(personal.Name);
            Console.WriteLine(personal.Surname);
            Console.WriteLine(personal.Age);




            //personal.Id = 1;
            //personal.NationalId = "13595581052";
            //personal.Name = "Tarık Talha";
            //personal.Surname = "Dinç";
            //personal.Age = 20;


            //personal.KisiyiGoster();
        }
    }
}