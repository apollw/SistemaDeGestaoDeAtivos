using SistemaDeGestaoDeAtivos.Models;
using Windows.System;

namespace SistemaDeGestaoDeAtivos.Pages;

public partial class PageCadastroDeAtivo : ContentPage
{
	public PageCadastroDeAtivo()
	{
		InitializeComponent();

        List<Metadado> listaDeMetadados = new List<Metadado>
        {
            new Metadado
            {
                Id = 1,
                Chave = "Data de Criação",
                Valor = "2023-01-15",
                Descricao = "Data em que o ativo foi criado",
                AtivoInformacaoId = 101,
                AtivoInformacao = new AtivoInformacao { Id = 101, Nome = "Ativo 1" }
            },
            new Metadado
            {
                Id = 2,
                Chave = "Peso",
                Valor = "1500",
                Descricao = "Peso do ativo em quilogramas",
                AtivoInformacaoId = 102,
                AtivoInformacao = new AtivoInformacao { Id = 102, Nome = "Ativo 2" }
            },
            new Metadado
            {
                Id = 3,
                Chave = "Status",
                Valor = "Ativo",
                Descricao = "Status atual do ativo",
                AtivoInformacaoId = 103,
                AtivoInformacao = new AtivoInformacao { Id = 103, Nome = "Ativo 3" }
            },
            new Metadado
            {
                Id = 4,
                Chave = "Tamanho",
                Valor = "Large",
                Descricao = "Tamanho do ativo",
                AtivoInformacaoId = 104,
                AtivoInformacao = new AtivoInformacao { Id = 104, Nome = "Ativo 4" }
            },
            new Metadado
            {
                Id = 5,
                Chave = "Última Modificação",
                Valor = "2023-03-20",
                Descricao = "Data da última modificação do ativo",
                AtivoInformacaoId = 105,
                AtivoInformacao = new AtivoInformacao { Id = 105, Nome = "Ativo 5" }
            },
            new Metadado
            {
                Id = 6,
                Chave = "Custo",
                Valor = "5000.00",
                Descricao = "Custo estimado do ativo em reais",
                AtivoInformacaoId = 106,
                AtivoInformacao = new AtivoInformacao { Id = 106, Nome = "Ativo 6" }
            },
            new Metadado
            {
                Id = 7,
                Chave = "Versão",
                Valor = "1.0",
                Descricao = "Versão do Ativo",
                AtivoInformacaoId = 107,
                AtivoInformacao = new AtivoInformacao { Id = 107, Nome = "Ativo 7" }
            },
            new Metadado
            {
                Id = 8,
                Chave = "Plataforma",
                Valor = "Windows",
                Descricao = "Plataforma do Software",
                AtivoInformacaoId = 108,
                AtivoInformacao = new AtivoInformacao { Id = 108, Nome = "Ativo 8" }
            }
        };

        _picker.ItemsSource = listaDeMetadados;
        _picker.ItemDisplayBinding = new Binding("Chave");
        _picker.SelectedIndex = 0;
    }

    private void CadastrarAtivo_Clicked(object sender, EventArgs e)
    {
        AtivoInformacao novoAtivo = new AtivoInformacao
        {
            Nome              = NomeEntry.Text,
            Descricao         = DescricaoEntry.Text,
            TipoAtivo         = TipoAtivoEntry.Text,
            Categoria         = CategoriaEntry.Text,
            DataCriacao       = DateTime.Now, 
            UltimaModificacao = DateTime.Now,
            ListaDeMetadados  = new List<Metadado>(),
            Versoes           = new List<VersaoAtivo>()
        };
        
        DisplayAlert("Sucesso", "Ativo cadastrado com sucesso!", "OK");


    }
}