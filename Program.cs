using BFRMain;
using BFRSystem;

namespace BulkRenameFiles
{
   internal static class Program
   {
	  /// <summary>
	  ///  The main entry point for the application.
	  /// </summary>
	  [STAThread]
	  static void Main()
	  {
		 // Validar si la aplicación ya está en ejecución
		 if (bfrSystem.IsAlreadyRunning())
		 {
			return; // Salir si la aplicación ya está en ejecución
		 }

		 Application.EnableVisualStyles();
		 Application.SetCompatibleTextRenderingDefault(false);
		 Application.Run(new frmBFR());

		 // Liberar el mutex cuando la aplicación se cierre
		 bfrSystem.ReleaseMutex();
	  }
   }
}