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
    class AvaliacaoBLL
    {
        DALProjeto dao;
        public AvaliacaoBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_avaliacao");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Avaliacao avaliacao)
        {
            try
            {
                dao.Insert("tbl_avaliacao", avaliacao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Avaliacao avaliacao)
        {
            try
            {
                dao.Delete("tbl_avaliacao", avaliacao, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Avaliacao avaliacao)
        {
            try
            {
                dao.Update("tbl_avaliacao", avaliacao, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
