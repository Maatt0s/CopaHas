using AppCopaHAS.ViewModels;

namespace AppCopaHAS.Views.Jogadores;

public partial class CadastroJogadorView: ContentPage
{
	CadastroJogadorView viewModel;
	public CadastroJogadorView()
	{
        InitializeComponent();

        viewModel = new CadastroJogadorView();
        BindingContext = viewModel;
        Title = "Cadastro de Jogadores";
    }
}