namespace IT_Assessment_2.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlNav
            //
            this.pnlNav.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.pnlNav.Controls.Add(this.LogoBtn);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1400, 80);
            this.pnlNav.TabIndex = 0;
            //
            // LogoBtn
            //
            this.LogoBtn.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Italic);
            this.LogoBtn.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.LogoBtn.Location = new System.Drawing.Point(30, 18);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(160, 50);
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.Text = "amane";
            this.LogoBtn.UseVisualStyleBackColor = false;
            //
            // pnlLoginContainer
            //
            this.pnlLoginContainer.BackColor = System.Drawing.Color.White;
            this.pnlLoginContainer.Location = new System.Drawing.Point(376, 100);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(648, 743);
            this.pnlLoginContainer.TabIndex = 1;
            //
            // LoginForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.pnlLoginContainer);
            this.Controls.Add(this.pnlNav);
            this.Name = "LoginForm";
            this.Text = "Amane Staff Portal";
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button LogoBtn;
        public System.Windows.Forms.Panel pnlLoginContainer;
    }
}
