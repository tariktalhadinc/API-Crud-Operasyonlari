using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalService
{
    public class Personal   
    {
        public int Id;
        public string? NationalId;
        public string? Name;
        public string? Surname;
        public int Age;


        public Personal(int _Id, string _NationalId, string _Name, string _Surname, int _Age)
        {
            Id = _Id;
            NationalId = _NationalId;
            Name = _Name;
            Surname = _Surname;
            Age = _Age;
        }

        //public void PersoneliGoster()
        //{
        //    Console.WriteLine("Personel Bilgileri :" + " " + Id + " " + NationalId + " " + Name + " " + Surname + " " + Age);
        //}

    }
}
