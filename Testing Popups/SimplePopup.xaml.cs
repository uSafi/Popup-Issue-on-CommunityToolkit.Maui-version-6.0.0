using CommunityToolkit.Maui.Views;

namespace Testing_Popups;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)=> Close();

}