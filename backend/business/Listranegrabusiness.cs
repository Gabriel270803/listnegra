using System;
using System.Collections.Generic;
using System.Linq;


namespace backend.Business
{
    public class ListaNegraBusiness
    {
        Database.ListaNegradatabase db =new Database.ListaNegradatabase();

        public Models.TbListaNegra Salvar(Models.TbListaNegra ln)
        {
            if (ln.NmPessoa == string.Empty)
                throw new Exception("Nome é obrigatório");
            if (ln.DsMotivo == string.Empty)
                throw new Exception("Motivo é obrigatório");

            return db.Salvar(ln);
        }

        public List<Models.TbListaNegra> Listar()
        {
            return db.Listar();
        }
    }
}