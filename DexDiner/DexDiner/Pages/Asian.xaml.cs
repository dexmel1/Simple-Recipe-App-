namespace DexDiner.Pages;

public partial class Asian : ContentPage
{
	public Asian()
	{
		InitializeComponent();

		BeefBroccoliBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Beef and Broccoli.txt");
		ChickenFriedRiceBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Chicken Fried Rice.txt");
		GrilledTeriyakiChickenBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Grilled Teriyaki Chicken.txt");
    }




}