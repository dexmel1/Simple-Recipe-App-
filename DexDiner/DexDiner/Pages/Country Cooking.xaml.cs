namespace DexDiner.Pages;

public partial class CountryCooking : ContentPage
{
	public CountryCooking()
	{
		InitializeComponent();

		MacAndCheeseBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Baked Mac and Cheese.txt");
		BuffaloChickenDip.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Buffalo Chicken Dip.txt");
		ChristmasHamBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Christmas Ham.txt");
		BakedBeansBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Dr Pepper Baked Beans.txt");
		GreenBeanCasseroleBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Green Bean Casserole.txt");
		NoodlesBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Home Made Noodles.txt");
		ChileBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync("recipedetails?recipeName=Kitchen Sink Chili.txt");
    }
}