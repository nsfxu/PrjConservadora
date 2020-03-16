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
    class OsBLL
    {
        DALProjeto dao;
        public OsBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_os");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Os os)
        {
            try
            {
                dao.Insert("tbl_os", os);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Os os)
        {
            try
            {
                dao.Delete("tbl_os", os, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Os os)
        {
            try
            {
                dao.Update("tbl_os", os, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
