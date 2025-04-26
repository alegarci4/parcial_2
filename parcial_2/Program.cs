using MinecraftManager.Services;
using MinecraftManager.UI;
using MinecraftManager.Utils;
using parcial_2;

namespace MinecraftManager
{
    class Program
    {
        [STAThread]
     
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            Console.ForegroundColor = ConsoleColor.Green;

            // Inicializar servicios
            var dbManager = new DatabaseManager();
            var jugadorService = new JugadorService(dbManager);
            var bloqueService = new BloqueService(dbManager);
            var inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);

            // Verificar conexi�n a la base de datos
            if (!dbManager.TestConnection())
            {
                Console.WriteLine("No se pudo conectar a la base de datos. Verifique la conexi�n e intente nuevamente.");
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Conexi�n a la base de datos establecida correctamente.");

            // Iniciar el men� principal
            var menuManager = new MenuManager(jugadorService, bloqueService, inventarioService);
            menuManager.MostrarMenuPrincipal();
        }
    }
}
