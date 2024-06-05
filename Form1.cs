using BFRSystem;
using System.Diagnostics.Eventing.Reader;

namespace BFRMain
{
   public partial class frmBFR : Form
   {
	  public frmBFR()
	  {
		 InitializeComponent();
	  }

	  private void frmBFR_Load(object sender, EventArgs e)
	  {

	  }

	  private void rdbRegEx_CheckedChanged(object sender, EventArgs e)
	  {
		 if (rdbRegEx.Checked) {txtbRegEx.Visible = true; }
		 else { txtbRegEx.Visible = false; }
	  }
   }
}
