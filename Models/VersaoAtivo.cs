using SistemaDeGestaoDeAtivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeAtivos.Models
{
    public class VersaoAtivo
    {
        private int             _id;
        private int             _numeroVersao;
        private DateTime        _dataVersao;
        private string          _descricaoVersao;
        private int             _ativoInformacaoId;    // Relacionamento com Ativo de Informação (uma Versão pertence a um Ativo)
        private AtivoInformacao _ativoInformacao;

        public int Id { get => _id; set => _id = value; }
        public int NumeroVersao { get => _numeroVersao; set => _numeroVersao = value; }
        public DateTime DataVersao { get => _dataVersao; set => _dataVersao = value; }
        public string DescricaoVersao { get => _descricaoVersao; set => _descricaoVersao = value; }
        public int AtivoInformacaoId { get => _ativoInformacaoId; set => _ativoInformacaoId = value; }
        public AtivoInformacao AtivoInformacao { get => _ativoInformacao; set => _ativoInformacao = value; }
    }
}
