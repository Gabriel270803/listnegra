using System;
using System.Collections.Generic;


namespace backend.Utils
{
    public class ListaNegraConversor
    {
        public Models.TbListaNegra ParaTabela(Models.Request.Liatranegraresponse request)
        {
            Models.TbListaNegra ln = new Models.TbListaNegra();
            ln.NmPessoa = request.Nome;
            ln.DsMotivo = request.Motivo;
            ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.listanegrarequest ParaResponse(Models.TbListaNegra ln)
        {
            Models.Response.listanegrarequest resp =new Models.Response.listanegrarequest();
            resp.Id = ln.IdListaNegra;
            resp.Nome = ln.NmPessoa;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
            return resp;
        }

        public List<Models.Response.listanegrarequest> ParaResponse(List<Models.TbListaNegra> lns)
        {
            List<Models.Response.listanegrarequest> resp = new List<Models.Response.listanegrarequest>();
            foreach (Models.TbListaNegra item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}