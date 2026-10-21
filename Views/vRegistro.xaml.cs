namespace mnaupariS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void btnGuardarUsuario_Clicked(object sender, EventArgs e)
    {
        string usuarioNuevo = txtUsuarioNuevo.Text;
        string contasenaNueva = txContrasena.Text;

        await Navigation.PushAsync(new vLogin(usuarioNuevo, contasenaNueva));
        await DisplayAlertAsync("ALERTA", "Usuario Guardado", "Cerrar");
    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {

    }
}