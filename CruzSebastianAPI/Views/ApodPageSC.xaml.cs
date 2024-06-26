using CruzSebastianAPI.ViewModels;

namespace CruzSebastianAPI.Views;

public partial class ApodPageSC : ContentPage
{
	public ApodPageSC()
	{
		InitializeComponent();
        BindingContext = new ApodViewModelSC();
    }
}