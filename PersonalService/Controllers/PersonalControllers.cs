using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace PersonalService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalControllers : ControllerBase
    {
        private static List<Personal> mockPersonal = new List<Personal>()
        {
           new Personal()
           {
               Id = 1,
               NationalId = "13595581052",
               Name = "Tarık Talha",
               Surname = "DİNÇ",
               Age = 20,
               Salary = 5500,
           },

           new Personal()
           {
               Id = 2,
               NationalId = "13595581054",
               Name = "Görkem",
               Surname = "Tekin",
               Age = 20,
               Salary = 7500,
           }
        };

        [HttpGet]
        [Route("PersonalList")]
        public async Task<ActionResult<Personal>> GetPersonals()
        {
            return Ok(mockPersonal);
        }

        [HttpGet]
        [Route("SearchPersonal")]

        public async Task<ActionResult<Personal>> GetPersonals(string nationalId)
        {
          var Personal = mockPersonal.Find(x => x.NationalId == nationalId);
          if (Personal == null)
              return BadRequest("No Data");
          return Ok(Personal);
        }
        
        [HttpPost]
        [Route("AddPersonal")]
        public async Task<ActionResult<bool>> AddPersonals(Personal personal)
        {
          var tempPersonel = personal;
          tempPersonel.Id = mockPersonal.Count() + 1;
          mockPersonal.Add(tempPersonel);
          return Ok(true);
        }

        [HttpPut]
        [Route("UpdatePersonal")]
        public async Task<ActionResult<Personal>> UpdatePersonals(Personal request)
        {
          var Personal = mockPersonal.Find(x => x.Id == request.Id);
          if (Personal == null)
              return BadRequest("No personal Data");
          Personal.Name = request.Name;
          Personal.Surname = request.Surname;
          return Ok(Personal);
        }

        [HttpDelete]
        [Route("DeletePersonal")]
        public async Task<ActionResult<Personal>> DeletePersonals(Personal request)
        {
          var personal = mockPersonal.Find(x => x.Id == request.Id);
          if (personal == null)
              return BadRequest("No personal found");

          mockPersonal.Remove(personal);
          return Ok(personal);
        }   
    }
}