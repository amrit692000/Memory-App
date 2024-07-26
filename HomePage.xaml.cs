namespace Memory_App;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }



    /*Event handler for when the "Add Memory" button is clicked.*/

    /*<param name="sender">The object that triggered the event, typically the button that was clicked.*/
    /*<param name="e">Event arguments related to the click event.</param>*/


    /**This method is an asynchronous event handler that responds to the button click by navigating
      to a new page called "AddMemory". The navigation operation is performed asynchronously to 
    ensure that the user interface remains responsive during the transition.
     */


    private async void OnAddMemoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddMemory());
    }
}