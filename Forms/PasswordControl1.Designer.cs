namespace IT_Assessment_2.Forms
{
    partial class PasswordControl1
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblForgotten = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnSwitchToPin = new System.Windows.Forms.Button();
            this.lblNewStaff = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlCard
            //
            this.pnlCard.BackColor = AmanePOSHelpers.AmaneStyling.CardPanel;
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblForgotten);
            this.pnlCard.Controls.Add(this.button1);
            this.pnlCard.Controls.Add(this.lblOr);
            this.pnlCard.Controls.Add(this.btnSwitchToPin);
            this.pnlCard.Controls.Add(this.lblNewStaff);
            this.pnlCard.Location = new System.Drawing.Point(40, 40);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(560, 660);
            this.pnlCard.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 14F);
            this.lblTitle.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 12, 0, 12);
            this.lblTitle.Size = new System.Drawing.Size(560, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "amane staff portal";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblUsername.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnURL;
            this.lblUsername.Location = new System.Drawing.Point(60, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(260, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "please enter email/username";
            //
            // txtUsername
            //
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtUsername.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.txtUsername.Location = new System.Drawing.Point(60, 200);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(440, 34);
            this.txtUsername.TabIndex = 2;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblPassword.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnURL;
            this.lblPassword.Location = new System.Drawing.Point(60, 255);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 28);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "please enter password";
            //
            // txtPassword
            //
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtPassword.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.txtPassword.Location = new System.Drawing.Point(60, 290);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(440, 34);
            this.txtPassword.TabIndex = 4;
            //
            // lblForgotten
            //
            this.lblForgotten.AutoSize = true;
            this.lblForgotten.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblForgotten.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnURL;
            this.lblForgotten.Location = new System.Drawing.Point(60, 340);
            this.lblForgotten.Name = "lblForgotten";
            this.lblForgotten.Size = new System.Drawing.Size(180, 28);
            this.lblForgotten.TabIndex = 5;
            this.lblForgotten.Text = "forgotten password?";
            //
            // button1
            //
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.FlatAppearance.BorderColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10F);
            this.button1.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(200, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = false;
            //
            // lblOr
            //
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Cambria", 8F);
            this.lblOr.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnURL;
            this.lblOr.Location = new System.Drawing.Point(230, 460);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(100, 24);
            this.lblOr.TabIndex = 7;
            this.lblOr.Text = "- or sign in with -";
            //
            // btnSwitchToPin
            //
            this.btnSwitchToPin.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.btnSwitchToPin.FlatAppearance.BorderSize = 1;
            this.btnSwitchToPin.FlatAppearance.BorderColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnSwitchToPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToPin.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSwitchToPin.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnSwitchToPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchToPin.Location = new System.Drawing.Point(290, 500);
            this.btnSwitchToPin.Name = "btnSwitchToPin";
            this.btnSwitchToPin.Size = new System.Drawing.Size(210, 42);
            this.btnSwitchToPin.TabIndex = 8;
            this.btnSwitchToPin.Text = "PIN log in";
            this.btnSwitchToPin.UseVisualStyleBackColor = false;
            //
            // lblNewStaff
            //
            this.lblNewStaff.AutoSize = true;
            this.lblNewStaff.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblNewStaff.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnURL;
            this.lblNewStaff.Location = new System.Drawing.Point(190, 580);
            this.lblNewStaff.Name = "lblNewStaff";
            this.lblNewStaff.Size = new System.Drawing.Size(200, 28);
            this.lblNewStaff.TabIndex = 9;
            this.lblNewStaff.Text = "new staff? contact admin";
            //
            // PasswordControl1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCard);
            this.Name = "PasswordControl1";
            this.Size = new System.Drawing.Size(648, 743);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblForgotten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnSwitchToPin;
        private System.Windows.Forms.Label lblNewStaff;
    }
}
