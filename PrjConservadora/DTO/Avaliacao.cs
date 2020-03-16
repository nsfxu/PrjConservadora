using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Avaliacao
    {
        private int id_avaliacao, nota_avaliacao, tbl_cliente_id_cliente, tbl_prestador_id_prestador;
        private string comentario_avaliacao;

        public int Id_avaliacao { get => id_avaliacao; set => id_avaliacao = value; }
        public int Nota_avaliacao { get => nota_avaliacao; set => nota_avaliacao = value; }
        public string Comentario_avaliacao { get => comentario_avaliacao; set => comentario_avaliacao = value; }
        public int Tbl_cliente_id_cliente { get => tbl_cliente_id_cliente; set => tbl_cliente_id_cliente = value; }
        public int Tbl_prestador_id_prestador { get => tbl_prestador_id_prestador; set => tbl_prestador_id_prestador = value; }
    }
}
