using DexDiner.Pages;

namespace DexDiner;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("recipedetails", typeof(RecipeDisplayPage));
	}
}
