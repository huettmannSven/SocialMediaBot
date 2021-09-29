
namespace ObsSocialMediaNotifier.Controls
{
    partial class MainPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageControl1 = new ObsSocialMediaNotifier.Controls.TabPageControl();
            this.SuspendLayout();
            // 
            // tabPageControl1
            // 
            this.tabPageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageControl1.Location = new System.Drawing.Point(0, 0);
            this.tabPageControl1.Name = "tabPageControl1";
            this.tabPageControl1.Size = new System.Drawing.Size(698, 446);
            this.tabPageControl1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPageControl1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(698, 446);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPageControl tabPageControl1;
    }
}
