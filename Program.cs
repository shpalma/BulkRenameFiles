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
		 // Validar si la aplicaci�n ya est� en ejecuci�n
		 if (bfrSystem.IsAlreadyRunning())
		 {
			return; // Salir si la aplicaci�n ya est� en ejecuci�n
		 }

		 Application.EnableVisualStyles();
		 Application.SetCompatibleTextRenderingDefault(false);
		 Application.Run(new frmBFR());

		 // Liberar el mutex cuando la aplicaci�n se cierre
		 bfrSystem.ReleaseMutex();
	  }
   }
}