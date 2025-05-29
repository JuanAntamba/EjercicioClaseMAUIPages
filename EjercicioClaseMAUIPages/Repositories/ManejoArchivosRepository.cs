using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseMAUIPages.Repositories
{
    class ManejoArchivosRepository
    {
        private string path = Path.Combine(FileSystem.AppDataDirectory + "/notes.txt");
        public async Task<bool> GuardarArchivo(string Texto)
        {
            string path = Path.Combine(FileSystem.AppDataDirectory + "/notes.txt");
            await File.WriteAllTextAsync(path, Texto);

            try
            {

                if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                return false;
            }
        }
        public async Task<string> ObtenerInformacionArchivo()
        {
            if(File.Exists(path))
            {
                string texto=await File.ReadAllTextAsync(path);
                return texto;
            }
            return "No encontre nada";
        }
    }
}
