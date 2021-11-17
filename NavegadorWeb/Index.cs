using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Index : Form
    {
        #region Inicialización.
        public Index() { InitializeComponent(); }
        #endregion

        #region Variables.
        string NewPageNames = "Nueva ventana";

        List<NewPageUserControl> CurrentPages = new List<NewPageUserControl>();
        #endregion

        private void Index_Load(object sender, EventArgs e)
        { CreatePage(); }

        private void NewPage_Click_1(object sender, EventArgs e)
        { CreatePage(); }

        private void CreatePage()
        {
            TabPage Page = new TabPage();
            NewPageUserControl newPage = new NewPageUserControl();
            Page.Text = NewPageNames + " " + (CurrentPages.Count + 1);
            Page.Controls.Add(newPage);
            newPage.Dock = DockStyle.Fill;

            WebView.TabPages.Add(Page);
            CurrentPages.Add(newPage);
            WebView.SelectedTab = Page;
        }

        #region ControlForm
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que desea salir de la aplicación?", "¡Está saliendo de la aplicación!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void CloseWindows_Click(object sender, EventArgs e)
        {
            CurrentPages.Remove(CurrentPages[WebView.SelectedIndex]);
            WebView.Controls.Remove(WebView.SelectedTab);

            for (int i = 0; i < CurrentPages.Count; i++)
            { WebView.TabPages[i].Text = NewPageNames + " " + (i + 1); }

            if (CurrentPages.Count < 1)
            {
                CreatePage();
                return;
            }
        }
    }
}
