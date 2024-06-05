using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFRSystem
{
   public class bfrSystem
   {
	  private static Mutex mutex = null;

	  public static bool IsAlreadyRunning()
	  {
		 string mutexName = "BulkFileRename"; 
		 bool createdNew;

		 mutex = new Mutex(true, mutexName, out createdNew);

		 if (!createdNew)
		 {
			MessageBox.Show("La aplicación ya está en ejecución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return true;
		 }

		 return false;
	  }

	  public static void ReleaseMutex()
	  {
		 if (mutex != null)
		 {
			mutex.ReleaseMutex();
			mutex = null;
		 }
	  }
   }
}
