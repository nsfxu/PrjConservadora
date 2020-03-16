using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Os
    {
        private int id_os, numendereco_os, vip_os, horacontratadas_os, tbl_servicos_id_servico, tbl_cliente_id_cliente, status_os, tbl_prestador_id_prestador;
        private string complemento_os, descricao_os, comentarios_os, cep_os, dataabertura_os, dataservico_os;

        public int Id_os { get => id_os; set => id_os = value; }
        public string Dataabertura_os { get => dataabertura_os; set => dataabertura_os = value; }
        public string Dataservico_os { get => dataservico_os; set => dataservico_os = value; }
        public string Cep_os { get => cep_os; set => cep_os = value; }
        public int Numendereco_os { get => numendereco_os; set => numendereco_os = value; }
        public string Complemento_os { get => complemento_os; set => complemento_os = value; }
        public int Vip_os { get => vip_os; set => vip_os = value; }
        public int Horacontratadas_os { get => horacontratadas_os; set => horacontratadas_os = value; }

        public string Descricao_os { get => descricao_os; set => descricao_os = value; }
        public string Comentarios_os { get => comentarios_os; set => comentarios_os = value; }
        public int Status_os { get => status_os; set => status_os = value; }
        public int Tbl_servicos_id_servico { get => tbl_servicos_id_servico; set => tbl_servicos_id_servico = value; }
        public int Tbl_cliente_id_cliente { get => tbl_cliente_id_cliente; set => tbl_cliente_id_cliente = value; }
        public int Tbl_prestador_id_prestador { get => tbl_prestador_id_prestador; set => tbl_prestador_id_prestador = value; }
    }
}
