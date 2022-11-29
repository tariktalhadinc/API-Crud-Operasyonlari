using System;
namespace PersonalService.Interfaces
{
    public interface IPersonalService
    {
        public List<Personal> Get();

        public Personal Search(string nationalId);

        public bool Add(Personal personal);

        public Personal Update(Personal request);

        public Personal Delete(Personal request);
    }
}

