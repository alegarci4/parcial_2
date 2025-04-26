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

            // Verificar conexión a la base de datos
            if (!dbManager.TestConnection())
            {
                Console.WriteLine("No se pudo conectar a la base de datos. Verifique la conexión e intente nuevamente.");
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Conexión a la base de datos establecida correctamente.");

            // Iniciar el menú principal
            var menuManager = new MenuManager(jugadorService, bloqueService, inventarioService);
            menuManager.MostrarMenuPrincipal();
        }
    }
}
