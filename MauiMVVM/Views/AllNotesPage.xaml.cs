namespace MauiMVVM.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();
	}

    void ContentPage_NavigatedTo(System.Object sender, Microsoft.Maui.Controls.NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}
