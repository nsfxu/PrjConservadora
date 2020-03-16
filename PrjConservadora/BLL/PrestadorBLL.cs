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
    class PrestadorBLL
    {
        DALProjeto dao;
        public PrestadorBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_prestador");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarWhere(string condicao)
        {
            try
            {
                return dao.SelectWhere("tbl_os", condicao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Prestador prestador)
        {
            try
            {
                dao.Insert("tbl_prestador", prestador);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Prestador prestador)
        {
            try
            {
                dao.Delete("tbl_prestador", prestador, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Prestador prestador)
        {
            try
            {
                dao.Update("tbl_prestador", prestador, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
