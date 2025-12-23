// enter the name in the text box and display the name in label when button is clicked.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;    
public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        // Get the name from the text box
        string name = NameTextBox.Text;

        // Display the name in the label
        NameLabel.Text = "Hello, " + name + "!";
    }
}