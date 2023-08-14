using Microsoft.Maui.Graphics.Text;
using System.Xml.Linq;

namespace DexDiner.Pages;
[QueryProperty(nameof(RecipeName), "recipeName")]


public partial class RecipeDisplayPage : ContentPage
{


    public RecipeDisplayPage()
	{
		InitializeComponent();
       
    }

    string recipeName;
    public string RecipeName
    {
        get => recipeName;
        set
        {
            recipeName = value;
            FindRecipe(recipeName);
        }
    }
    //Need to work on a relative path

    string mainPath = "C:\\Users\\Dex\\Desktop\\Project1\\DexDiner\\DexDiner\\Resources\\Files\\";
    public void FindRecipe(string recipeName)
	{
        StreamReader sr = new StreamReader(mainPath + recipeName);
         this.listView.Text = sr.ReadToEnd();
    }




}