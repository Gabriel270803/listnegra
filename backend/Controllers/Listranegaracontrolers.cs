using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaNegraController : ControllerBase
    {
        Business.ListaNegraBusiness business = new Business.ListaNegraBusiness();
        Utils.ListaNegraConversor conversor = new Utils.ListaNegraConversor();


        [HttpPost]
        public ActionResult<Models.Response.listanegrarequest> Inserir(Models.Request.Liatranegraresponse request)
        {
            try
            {
                Models.TbListaNegra ln = conversor.ParaTabela(request);
                business.Salvar(ln);

                Models.Response.listanegrarequest resp = conversor.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }


        [HttpGet]
        public ActionResult<List<Models.Response.listanegrarequest>> Listar() 
        {
            try
            {
                List<Models.TbListaNegra> lns = business.Listar();
                if (lns.Count == 0)
                    return NotFound();

                List<Models.Response.listanegrarequest> resp = conversor.ParaResponse(lns);
                return resp;
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );
            }
        }



        
        [HttpGet("ping")]
        public string Ping() 
        {
            return "pong";
        }
    }
}