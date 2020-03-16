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
    class CategoriaBLL
    {
        DALProjeto dao;
        public CategoriaBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_categoria");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Categoria categoria)
        {
            try
            {
                dao.Insert("tbl_categoria", categoria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Categoria categoria)
        {
            try
            {
                dao.Delete("tbl_categoria", categoria, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Categoria categoria)
        {
            try
            {
                dao.Update("tbl_categoria", categoria, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
