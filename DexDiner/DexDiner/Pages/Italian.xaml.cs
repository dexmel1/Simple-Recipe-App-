namespace DexDiner.Pages;

public partial class Italian : ContentPage
{
	public Italian()
	{
		InitializeComponent();

		ChickenTortelliniSalad.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Chicken Tortellini Salad.txt");
    }
}