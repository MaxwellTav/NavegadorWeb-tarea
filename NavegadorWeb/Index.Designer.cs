
namespace NavegadorWeb
{
    partial class Index
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.WebView = new System.Windows.Forms.TabControl();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NewPage = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Maximize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TopPanel_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CloseWindows = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 10;
            this.Form_Elipse.TargetControl = this;
            // 
            // WebView
            // 
            this.WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebView.Location = new System.Drawing.Point(0, 27);
            this.WebView.Name = "WebView";
            this.WebView.SelectedIndex = 0;
            this.WebView.Size = new System.Drawing.Size(932, 502);
            this.WebView.TabIndex = 0;
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.CloseWindows);
            this.TopPanel.Controls.Add(this.NewPage);
            this.TopPanel.Controls.Add(this.Minimize_Button);
            this.TopPanel.Controls.Add(this.Maximize_Button);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(932, 28);
            this.TopPanel.TabIndex = 1;
            // 
            // NewPage
            // 
            this.NewPage.Animated = true;
            this.NewPage.AutoRoundedCorners = true;
            this.NewPage.BorderRadius = 8;
            this.NewPage.CheckedState.Parent = this.NewPage;
            this.NewPage.CustomImages.Parent = this.NewPage;
            this.NewPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(235)))));
            this.NewPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPage.ForeColor = System.Drawing.Color.White;
            this.NewPage.HoverState.Parent = this.NewPage;
            this.NewPage.Location = new System.Drawing.Point(3, 5);
            this.NewPage.Name = "NewPage";
            this.NewPage.ShadowDecoration.Parent = this.NewPage;
            this.NewPage.Size = new System.Drawing.Size(100, 18);
            this.NewPage.TabIndex = 1;
            this.NewPage.Text = "Nueva ventana";
            this.NewPage.Click += new System.EventHandler(this.NewPage_Click_1);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.CustomImages.Parent = this.Minimize_Button;
            this.Minimize_Button.FillColor = System.Drawing.Color.Gray;
            this.Minimize_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Location = new System.Drawing.Point(870, 5);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_Button.ShadowDecoration.Parent = this.Minimize_Button;
            this.Minimize_Button.Size = new System.Drawing.Size(17, 17);
            this.Minimize_Button.TabIndex = 0;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Maximize_Button
            // 
            this.Maximize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize_Button.CheckedState.Parent = this.Maximize_Button;
            this.Maximize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize_Button.CustomImages.Parent = this.Maximize_Button;
            this.Maximize_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Maximize_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Maximize_Button.ForeColor = System.Drawing.Color.White;
            this.Maximize_Button.HoverState.Parent = this.Maximize_Button;
            this.Maximize_Button.Location = new System.Drawing.Point(889, 5);
            this.Maximize_Button.Name = "Maximize_Button";
            this.Maximize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Maximize_Button.ShadowDecoration.Parent = this.Maximize_Button;
            this.Maximize_Button.Size = new System.Drawing.Size(17, 17);
            this.Maximize_Button.TabIndex = 0;
            this.Maximize_Button.Click += new System.EventHandler(this.Maximize_Button_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(907, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(17, 17);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TopPanel_Drag
            // 
            this.TopPanel_Drag.TargetControl = this.TopPanel;
            // 
            // CloseWindows
            // 
            this.CloseWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseWindows.Animated = true;
            this.CloseWindows.AutoRoundedCorners = true;
            this.CloseWindows.BorderRadius = 8;
            this.CloseWindows.CheckedState.Parent = this.CloseWindows;
            this.CloseWindows.CustomImages.Parent = this.CloseWindows;
            this.CloseWindows.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(235)))));
            this.CloseWindows.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseWindows.ForeColor = System.Drawing.Color.White;
            this.CloseWindows.HoverState.Parent = this.CloseWindows;
            this.CloseWindows.Location = new System.Drawing.Point(716, 5);
            this.CloseWindows.Name = "CloseWindows";
            this.CloseWindows.ShadowDecoration.Parent = this.CloseWindows;
            this.CloseWindows.Size = new System.Drawing.Size(148, 18);
            this.CloseWindows.TabIndex = 1;
            this.CloseWindows.Text = "Cerrar ventana actual";
            this.CloseWindows.Click += new System.EventHandler(this.CloseWindows_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 529);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.WebView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Index_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private System.Windows.Forms.TabControl WebView;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Maximize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButton;
        private Guna.UI2.WinForms.Guna2DragControl TopPanel_Drag;
        private Guna.UI2.WinForms.Guna2Button NewPage;
        private Guna.UI2.WinForms.Guna2Button CloseWindows;
    }
}

