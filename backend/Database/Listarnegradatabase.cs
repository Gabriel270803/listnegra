using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace backend.Database
{
    public class ListaNegradatabase
    {
        Models.infob08Context db = new Models.infob08Context();
            

        public Models.TbListaNegra Salvar(Models.TbListaNegra ln)
        {
            db.Add(ln);
            db.SaveChanges();

            return ln;
        }

        public List<Models.TbListaNegra> Listar()
        {
             List<Models.TbListaNegra> lns = db.TbListaNegra.ToList();
             return lns;
        }
    }
}