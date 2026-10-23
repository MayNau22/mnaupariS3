namespace mnaupariS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = "";
    string contrasena = "";
	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string UsuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
        usuario = UsuarioNuevo;
        contrasena = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioingresado = txtUsuario.Text;
			string contrasenaingresada = txtContrasena.Text;

			if (usuario == usuarioingresado && contrasena == contrasenaingresada)

			{
				await Navigation.PushAsync(new Views.vPrincipal(usuario));
			}

			else
			{
				DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
				txtUsuario.Text = "";
				txtContrasena.Text = "";


			}
		}
		catch (Exception ex)
		{

            await DisplayAlertAsync("ERROR", ex.Message, "Cerrar");
            
        }

    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vRegistro());
    }
}