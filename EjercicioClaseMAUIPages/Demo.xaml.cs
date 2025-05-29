using EjercicioClaseMAUIPages.Repositories;
using System.Threading.Tasks;

namespace EjercicioClaseMAUIPages;

public partial class Demo : ContentPage
{
	private ManejoArchivosRepository _repo;
	public Demo()
	{
        _repo = new ManejoArchivosRepository();
        InitializeComponent();
        ObtenerInformacionArchivo();
    }

    private async Task ObtenerInformacionArchivo()
    {
        texto1.Text = await _repo.ObtenerInformacionArchivo();
    }

   

    private async void BotonGuardar_Clicked_1(object sender, EventArgs e)
    {
        string texto = texto1.Text;
        Boolean guardar = await _repo.GuardarArchivo(texto);
        if (!guardar)
        {
            throw new Exception("No se pudo guardar el archivo");
        }
    }
}