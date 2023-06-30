namespace Gasolinera;
/// <summary>
/// <Createdate>29/06/2023</Createdate>
/// <Company>SANDBOX</Company>
/// <Lastmodificationsdate>29/06/2023</Lastmodificationsdate>
/// <Lastmodificationsdescription>se agrego un mensaje de error al introducir 
/// dato nulo o vacio</Lastmodificationsdescription>
/// <Lastmodificationsautor>Ingrid Gabriel</Lastmodificationsautor>
/// </summary>
public partial class MainPage : ContentPage
{

	/// <summary>
	/// Constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// se calculara el precio a cobrar convirtiendo los galones a litros con la
	/// la formula correcta
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

	private void Calcular_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(galones.Text))
		{
			double gal, l;

			gal = Convert.ToDouble(galones.Text);

			l = gal * 3.78 / 1;

			precioL.Text = l.ToString("N2");
		}
		else
		{
			DisplayAlert("ERROR", "Introduzca el dato requerido", "OK");
		}
    }
}

