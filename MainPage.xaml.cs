namespace SistemaDeGestaoDeAtivos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

/*
1. **Tela de Login:**
   - Essa tela permite que os usuários façam login no sistema, inserindo suas credenciais (nome de usuário e senha) para acessar as funcionalidades.
   
2. **Dashboard ou Tela Inicial:**
   - Uma tela inicial que fornece uma visão geral do sistema, exibindo estatísticas simples, como número total de ativos, últimas modificações, etc.
   
3. **Tela de Cadastro de Ativos:**
   - Uma tela para adicionar novos ativos de informação ao sistema, com campos para inserir nome, descrição, tipo de ativo, categoria, entre outros detalhes.

4. **Tela de Visualização de Ativos:**
   - Uma tela que lista todos os ativos cadastrados, permitindo a visualização rápida dos detalhes de cada ativo, como nome, descrição, tipo, categoria, etc.

5. **Tela de Detalhes do Ativo:**
   - Uma tela mais detalhada que exibe informações específicas de um ativo selecionado, incluindo metadados associados, histórico de versões, etc.

6. **Tela de Busca e Filtros:**
   - Uma tela com campos de busca e filtros para facilitar a localização de ativos com base em critérios específicos, como nome, tipo, categoria, data, etc.

7. **Tela de Edição de Ativos:**
   - Uma tela que permite editar as informações de um ativo existente, como atualizar metadados, modificar descrição, alterar categoria, entre outros.

8. **Tela de Relatórios Simples:**
   - Uma tela para gerar relatórios básicos que apresentem informações resumidas sobre os ativos, como quantidade total, tipos mais comuns, últimos ativos adicionados, etc.
*/
