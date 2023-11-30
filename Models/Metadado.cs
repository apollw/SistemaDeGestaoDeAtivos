using SistemaDeGestaoDeAtivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeAtivos.Models
{
    public  class Metadado
    {
        private int             _id;
        private string          _chave;
        private string          valor;
        private string          _descricao;
        private int             _ativoInformacaoId; // Relacionamento com Ativo de Informação (um Metadado pertence a um Ativo)
        private AtivoInformacao _ativoInformacao;

        public int Id { get => _id; set => _id = value; }
        public string Chave { get => _chave; set => _chave = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int AtivoInformacaoId { get => _ativoInformacaoId; set => _ativoInformacaoId = value; }
        public AtivoInformacao AtivoInformacao { get => _ativoInformacao; set => _ativoInformacao = value; }
    }
}
