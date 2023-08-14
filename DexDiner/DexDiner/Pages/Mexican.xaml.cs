namespace DexDiner.Pages;

public partial class Mexican : ContentPage
{
	public Mexican()
	{
		InitializeComponent();

		ChickenEnchiladaBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Chicken Enchiladas w. Sauce.txt");
		FishTacoBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Fish Tacos.txt");
		StuffedPeppersBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Stuffed Peppers.txt");
    }
}