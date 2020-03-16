using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Servicos
    {
        private int id_servico, minimohora_servico, tbl_categoria_id_categoria;
        private string descricao_servico;
        private double valorhora_servico, valorhoravip_servico;

        public int Id_servico { get => id_servico; set => id_servico = value; }
        public string Descricao_servico { get => descricao_servico; set => descricao_servico = value; }
        public double Valorhora_servico { get => valorhora_servico; set => valorhora_servico = value; }
        public double Valorhoravip_servico { get => valorhoravip_servico; set => valorhoravip_servico = value; }
        public int Minimohora_servico { get => minimohora_servico; set => minimohora_servico = value; }
        public int Tbl_categoria_id_categoria { get => tbl_categoria_id_categoria; set => tbl_categoria_id_categoria = value; }
    }
}
