using MauiApp1.models;
using MauiApp2.models;
namespace MauiApp2;

public partial class OffresPage : ContentPage
{
	private Alternant _alternant;
	public OffresPage(Alternant alternant)
	{
		InitializeComponent();
		_alternant = alternant;
	}

    private void PostulateBtn_Clicked(object sender, EventArgs e)
    {

    }

  
}