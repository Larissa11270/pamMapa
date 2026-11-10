using MapaPam.ViewModels;

namespace MapaPam.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
    LocalizacaoViewModel viewModel;
    public LocalizacaoView()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
        //viewModel.InicializarMapa();
        viewModel.ChecarLocalizacao();
        viewModel.ExibirUsuariosNoMapa();

        BindingContext = viewModel;
    }
}