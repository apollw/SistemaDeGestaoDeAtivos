using SistemaDeGestaoDeAtivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeAtivos.Models
{
    public class PermissaoAcesso
    {
        private int             _id;
        private string          _tipoPermissao;
        private int             _usuarioId; // Relacionamento com Usuário (uma Permissão pertence a um Usuário)
        private Usuario         _usuario;
        private int             _ativoInformacaoId;//Relacionamento com Ativo de Informação (uma Permissão está associada a um Ativo)
        private AtivoInformacao _ativoInformacao;

        public int Id { get => _id; set => _id = value; }
        public string TipoPermissao { get => _tipoPermissao; set => _tipoPermissao = value; }
        public int UsuarioId { get => _usuarioId; set => _usuarioId = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public int AtivoInformacaoId { get => _ativoInformacaoId; set => _ativoInformacaoId = value; }
        public AtivoInformacao AtivoInformacao { get => _ativoInformacao; set => _ativoInformacao = value; }
    }
}
