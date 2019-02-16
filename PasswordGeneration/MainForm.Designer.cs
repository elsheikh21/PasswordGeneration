namespace PasswordGeneration {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GeneratePW = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GeneratePW
            // 
            this.GeneratePW.Location = new System.Drawing.Point(55, 126);
            this.GeneratePW.Name = "GeneratePW";
            this.GeneratePW.Size = new System.Drawing.Size(202, 29);
            this.GeneratePW.TabIndex = 7;
            this.GeneratePW.Text = "Generate and Reset";
            this.GeneratePW.UseVisualStyleBackColor = true;
            this.GeneratePW.Click += new System.EventHandler(this.GeneratePW_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.AccessibleName = "";
            this.PasswordField.BackColor = System.Drawing.Color.White;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(55, 60);
            this.PasswordField.MaxLength = 15;
            this.PasswordField.MinimumSize = new System.Drawing.Size(4, 40);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.ReadOnly = true;
            this.PasswordField.Size = new System.Drawing.Size(202, 22);
            this.PasswordField.TabIndex = 8;
            this.PasswordField.Text = "dasdsadasdasd";
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::PasswordGeneration.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.GeneratePW);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secure Me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneratePW;
        private System.Windows.Forms.TextBox PasswordField;
    }
}

