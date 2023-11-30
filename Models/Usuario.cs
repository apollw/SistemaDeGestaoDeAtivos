using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeAtivos.Models
{
    public class Usuario
    {
        private int                   _id;
        private string                _nome;
        private string                _senha;
        private string                _papel;
        private List<PermissaoAcesso> _permissoesAcesso; // Relacionamento com Permissões de Acesso (um Usuário pode ter várias Permissões)

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Papel { get => _papel; set => _papel = value; }
        public List<PermissaoAcesso> PermissoesAcesso { get => _permissoesAcesso; set => _permissoesAcesso = value; }
    }
}
