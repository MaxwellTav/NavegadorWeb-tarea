
namespace NavegadorWeb
{
    partial class NewPageUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BrowserControl = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // BrowserControl
            // 
            this.BrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserControl.IsWebBrowserContextMenuEnabled = false;
            this.BrowserControl.Location = new System.Drawing.Point(0, 0);
            this.BrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrowserControl.Name = "BrowserControl";
            this.BrowserControl.ScriptErrorsSuppressed = true;
            this.BrowserControl.Size = new System.Drawing.Size(779, 331);
            this.BrowserControl.TabIndex = 0;
            this.BrowserControl.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            // 
            // NewPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BrowserControl);
            this.Name = "NewPageUserControl";
            this.Size = new System.Drawing.Size(779, 331);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser BrowserControl;
    }
}
