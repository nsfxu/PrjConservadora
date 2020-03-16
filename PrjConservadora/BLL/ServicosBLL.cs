using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    class ServicosBLL
    {
        DALProjeto dao;
        public ServicosBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_servicos");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Servicos servicos)
        {
            try
            {
                dao.Insert("tbl_servicos", servicos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Servicos servicos)
        {
            try
            {
                dao.Delete("tbl_servicos", servicos, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Servicos servicos)
        {
            try
            {
                dao.Update("tbl_servicos", servicos, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
