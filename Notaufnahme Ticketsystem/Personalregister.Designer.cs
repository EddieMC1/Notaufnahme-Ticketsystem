namespace Notaufnahme_Ticketsystem
{
    partial class Personalregister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdRegistrierung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAbbruch = new System.Windows.Forms.Button();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblBeruf = new System.Windows.Forms.Label();
            this.txtBenutzer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRolle = new System.Windows.Forms.ComboBox();
            this.groupBoxPersonendaten = new System.Windows.Forms.GroupBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPersonendaten.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRegistrierung
            // 
            this.cmdRegistrierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrierung.Location = new System.Drawing.Point(146, 305);
            this.cmdRegistrierung.Name = "cmdRegistrierung";
            this.cmdRegistrierung.Size = new System.Drawing.Size(133, 32);
            this.cmdRegistrierung.TabIndex = 1;
            this.cmdRegistrierung.Text = "Registrieren";
            this.cmdRegistrierung.UseVisualStyleBackColor = true;
            this.cmdRegistrierung.Click += new System.EventHandler(this.cmdRegistrierung_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(542, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal registrieren";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAbbruch
            // 
            this.cmdAbbruch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbbruch.Location = new System.Drawing.Point(296, 305);
            this.cmdAbbruch.Name = "cmdAbbruch";
            this.cmdAbbruch.Size = new System.Drawing.Size(133, 32);
            this.cmdAbbruch.TabIndex = 2;
            this.cmdAbbruch.Text = "Abbruch";
            this.cmdAbbruch.UseVisualStyleBackColor = true;
            this.cmdAbbruch.Click += new System.EventHandler(this.cmdAbbruch_Click);
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(95, 89);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(163, 22);
            this.txtNachname.TabIndex = 1;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(95, 43);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(163, 22);
            this.txtVorname.TabIndex = 0;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswort.Location = new System.Drawing.Point(18, 91);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(77, 16);
            this.lblPasswort.TabIndex = 6;
            this.lblPasswort.Text = "Nachname:";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(18, 46);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(66, 16);
            this.lblVorname.TabIndex = 5;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblBeruf
            // 
            this.lblBeruf.AutoSize = true;
            this.lblBeruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeruf.Location = new System.Drawing.Point(18, 137);
            this.lblBeruf.Name = "lblBeruf";
            this.lblBeruf.Size = new System.Drawing.Size(43, 16);
            this.lblBeruf.TabIndex = 7;
            this.lblBeruf.Text = "Rolle:";
            // 
            // txtBenutzer
            // 
            this.txtBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenutzer.Location = new System.Drawing.Point(355, 68);
            this.txtBenutzer.Name = "txtBenutzer";
            this.txtBenutzer.PasswordChar = '*';
            this.txtBenutzer.Size = new System.Drawing.Size(163, 22);
            this.txtBenutzer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Benutzer:";
            // 
            // comboBoxRolle
            // 
            this.comboBoxRolle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRolle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRolle.FormattingEnabled = true;
            this.comboBoxRolle.Items.AddRange(new object[] {
            "Arzt",
            "Schwester",
            "Admin"});
            this.comboBoxRolle.Location = new System.Drawing.Point(95, 135);
            this.comboBoxRolle.Name = "comboBoxRolle";
            this.comboBoxRolle.Size = new System.Drawing.Size(163, 24);
            this.comboBoxRolle.TabIndex = 2;
            // 
            // groupBoxPersonendaten
            // 
            this.groupBoxPersonendaten.Controls.Add(this.txtPasswort);
            this.groupBoxPersonendaten.Controls.Add(this.label4);
            this.groupBoxPersonendaten.Controls.Add(this.txtVorname);
            this.groupBoxPersonendaten.Controls.Add(this.comboBoxRolle);
            this.groupBoxPersonendaten.Controls.Add(this.lblVorname);
            this.groupBoxPersonendaten.Controls.Add(this.txtBenutzer);
            this.groupBoxPersonendaten.Controls.Add(this.lblPasswort);
            this.groupBoxPersonendaten.Controls.Add(this.label3);
            this.groupBoxPersonendaten.Controls.Add(this.txtNachname);
            this.groupBoxPersonendaten.Controls.Add(this.lblBeruf);
            this.groupBoxPersonendaten.Location = new System.Drawing.Point(12, 95);
            this.groupBoxPersonendaten.Name = "groupBoxPersonendaten";
            this.groupBoxPersonendaten.Size = new System.Drawing.Size(542, 188);
            this.groupBoxPersonendaten.TabIndex = 0;
            this.groupBoxPersonendaten.TabStop = false;
            this.groupBoxPersonendaten.Text = "Personendaten";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(355, 109);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(163, 22);
            this.txtPasswort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Passwort:";
            // 
            // Personalregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 369);
            this.Controls.Add(this.groupBoxPersonendaten);
            this.Controls.Add(this.cmdRegistrierung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAbbruch);
            this.Name = "Personalregister";
            this.Text = "Personalregister";
            this.Load += new System.EventHandler(this.Personalregister_Load);
            this.groupBoxPersonendaten.ResumeLayout(false);
            this.groupBoxPersonendaten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrierung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAbbruch;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblBeruf;
        private System.Windows.Forms.TextBox txtBenutzer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRolle;
        private System.Windows.Forms.GroupBox groupBoxPersonendaten;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label label4;
    }
}