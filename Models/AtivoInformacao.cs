using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeAtivos.Models
{
    public class AtivoInformacao
    {
        private int               _id;
        private string            _nome; 
        private string            _descricao; 
        private string            _tipoAtivo;
        private DateTime          _dataCriacao;
        private DateTime          _ultimaModificacao;
        private string            _categoria;
        private List<Metadado>    _listaDeMetadados; // Relacionamento com Metadados (um Ativo pode ter vários Metadados associados)
        private List<VersaoAtivo> _versoes; // Relacionamento com Versões do Ativo (um Ativo pode ter várias Versões)

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string TipoAtivo { get => _tipoAtivo; set => _tipoAtivo = value; }
        public DateTime DataCriacao { get => _dataCriacao; set => _dataCriacao = value; }
        public DateTime UltimaModificacao { get => _ultimaModificacao; set => _ultimaModificacao = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public List<Metadado> ListaDeMetadados { get => _listaDeMetadados; set => _listaDeMetadados = value; }
        public List<VersaoAtivo> Versoes { get => _versoes; set => _versoes = value; }
    }
}
