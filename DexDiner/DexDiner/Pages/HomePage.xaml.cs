namespace DexDiner.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		SearchBtn.Clicked += async (s, e) => await Shell.Current.GoToAsync($"recipedetails?recipeName={searchResults.SelectedItem}");

    }

	private void OnSearchButtonPressed(object sender, EventArgs e)
	{
		string input = SearchBar.Text;
		string filePath = "C:\\Users\\Dex\\Desktop\\Project1\\DexDiner\\DexDiner\\Resources\\Files\\";


		DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

		List<string> outputList = new List<string>();

		if(input != "")
		{
			foreach( var fi  in directoryInfo.GetFiles("*" + input + "*") )
			{
					string output = fi.Name;
					outputList.Add(output);
			}
            
        }
		
        searchResults.ItemsSource = outputList;
    }


	
}