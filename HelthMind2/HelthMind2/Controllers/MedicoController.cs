using HelthMind2.Context;
using HelthMind2.Model;
using HelthMind2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelthMind2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly MedicoRepository medicoRepository;

        public MedicoController(DataBaseContext context)
        {
            medicoRepository = new MedicoRepository(context);
        }

        [HttpGet("{id:int}")]
        public ActionResult<MedicoModel> Get([FromRoute] int id)
        {
            try
            {
                var medicoModel = medicoRepository.ConsultarPorId(id);

                return Ok(medicoModel);

            }catch (KeyNotFoundException ex) 
            {
                throw ex;
            }
        }
    }
}
