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
    class ClienteBLL
    {
        DALProjeto dao;
        public ClienteBLL()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public DataTable Listar()
        {
            try
            {
                return dao.SelectAll("tbl_cliente");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Cliente cliente)
        {
            try
            {
                dao.Insert("tbl_cliente", cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(Cliente cliente)
        {
            try
            {
                dao.Delete("tbl_cliente", cliente, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                dao.Update("tbl_cliente", cliente, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
