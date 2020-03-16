using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DAL;

namespace PrjConservadora
{
    class Usuario
    {
        private DALMysql dao = new DALMysql();
        public Usuario()
        {
            dao = new DALProjeto("localhost", "ConservadoraVirtual", "root", "");
        }

        public int Validar(string usuario, string senha)
        {
            try
            {
                DataTable dt = dao.ExecutarConsulta("select * from tbl_usuario where email_usuario = '" + usuario + "' and senha_usuario = '" + senha + "'");
                if (dt.Rows.Count == 0)
                {
                    dt = dao.ExecutarConsulta("select * from tbl_prestador where email_prestador = '" + usuario + "' and senha_prestador = '" + senha + "'");
                    if (dt.Rows.Count == 0)
                    {
                        return -1;
                    }
                    else
                    {
                        Globais.tipo = "Prestador";
                        Globais.id = Convert.ToInt32(dt.Rows[0]["id_prestador"]);
                        Globais.nome = Convert.ToString(dt.Rows[0]["nome_prestador"]);
                        return 0;
                    }
                }
                else
                {
                    Globais.tipo = Convert.ToString(dt.Rows[0]["tipo_usuario"]);
                    Globais.nome = Convert.ToString(dt.Rows[0]["nome_usuario"]);
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarCliente()
        {
            try
            {
                DataTable dt = dao.ExecutarConsulta("SELECT tbl_cliente.nome_cliente AS Cliente, SUM(tbl_avaliacao.nota_avaliacao) AS Nota_Total FROM tbl_cliente LEFT JOIN tbl_avaliacao ON tbl_avaliacao.tbl_cliente_id_cliente = tbl_cliente.id_cliente GROUP BY Cliente Order by Nota_Total desc");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarPrestador()
        {
            try
            {
                DataTable dt = dao.ExecutarConsulta("SELECT tbl_prestador.nome_prestador AS Prestador, SUM(tbl_avaliacao.nota_avaliacao) AS Nota_Total FROM tbl_prestador LEFT JOIN tbl_avaliacao ON tbl_avaliacao.tbl_prestador_id_prestador = tbl_prestador.id_prestador GROUP BY Prestador Order by Nota_Total desc;");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarServicos()
        {
            try
            {
                DataTable dt = dao.ExecutarConsulta("SELECT tbl_servicos.descricao_servico AS Servico, COUNT(tbl_os.tbl_servicos_id_servico) AS Vezes FROM tbl_servicos LEFT JOIN tbl_os ON tbl_os.tbl_servicos_id_servico = tbl_servicos.id_servico GROUP BY Servico Order by Vezes desc");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarResumitivo()
        {
            try
            {
                DataTable dt = dao.ExecutarConsulta("");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
