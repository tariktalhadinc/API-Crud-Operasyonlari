using Microsoft.AspNetCore.Mvc;
using PersonalService.Interfaces;
using System.Security.Cryptography.Xml;

namespace PersonalService.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class PersonalControllers : ControllerBase
    {
        private readonly IPersonalService _personalService;

        public PersonalControllers(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        [HttpGet]
        [Route("ListPersonal")]
        public async Task<ActionResult<Personal>> Get()
        {
            return Ok(_personalService.Get());
        }

        [HttpGet]
        [Route("SearchPersonal")]

        public async Task<ActionResult<Personal>> Search(string nationalId)
        {
            var personel = _personalService.Search(nationalId);
            if (personel == null)
                return BadRequest("No Data");
            return Ok(personel);
        }

        [HttpPost]
        [Route("AddPersonal")]
        public async Task<ActionResult<bool>> Add(Personal personal)
        {
            var tempPersonel = personal;
            _personalService.Add(tempPersonel);
            return Ok(true);
        }

        [HttpPut]
        [Route("UpdatePersonal")]
        public async Task<ActionResult<Personal>> Update(Personal request)
        {
            _personalService.Update(request);
            return BadRequest("No personal Data");
            return Ok();
        }

        [HttpDelete]
        [Route("DeletePersonal")]
        public async Task<ActionResult<Personal>> Delete(Personal request)
        {
            _personalService.Delete(request);
            return Ok();
        }
    }
}