﻿namespace PryMendozaIEDefinitivo
{
    partial class FrmInicio
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
            this.LblInicio = new MetroFramework.Drawing.Html.HtmlLabel();
            this.TxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.TxtContraseña = new MetroFramework.Controls.MetroTextBox();
            this.LblUsuario = new MetroFramework.Controls.MetroLabel();
            this.LblContraseña = new MetroFramework.Controls.MetroLabel();
            this.PtcImagenSeguro = new System.Windows.Forms.PictureBox();
            this.GrpInicioDeSesiòn = new System.Windows.Forms.GroupBox();
            this.BtnIniciarSesion = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.PtcImagenSeguro)).BeginInit();
            this.GrpInicioDeSesiòn.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblInicio
            // 
            this.LblInicio.AutoScroll = true;
            this.LblInicio.AutoScrollMinSize = new System.Drawing.Size(180, 48);
            this.LblInicio.BackColor = System.Drawing.SystemColors.Window;
            this.LblInicio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(174, 42);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(180, 48);
            this.LblInicio.TabIndex = 0;
            this.LblInicio.Text = "Bienvenido!";
            // 
            // TxtUsuario
            // 
            // 
            // 
            // 
            this.TxtUsuario.CustomButton.Image = null;
            this.TxtUsuario.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.TxtUsuario.CustomButton.Name = "";
            this.TxtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsuario.CustomButton.TabIndex = 1;
            this.TxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsuario.CustomButton.UseSelectable = true;
            this.TxtUsuario.CustomButton.Visible = false;
            this.TxtUsuario.Lines = new string[0];
            this.TxtUsuario.Location = new System.Drawing.Point(100, 33);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.ShortcutsEnabled = true;
            this.TxtUsuario.Size = new System.Drawing.Size(115, 23);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.UseSelectable = true;
            this.TxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContraseña
            // 
            // 
            // 
            // 
            this.TxtContraseña.CustomButton.Image = null;
            this.TxtContraseña.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.TxtContraseña.CustomButton.Name = "";
            this.TxtContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContraseña.CustomButton.TabIndex = 1;
            this.TxtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContraseña.CustomButton.UseSelectable = true;
            this.TxtContraseña.CustomButton.Visible = false;
            this.TxtContraseña.Lines = new string[0];
            this.TxtContraseña.Location = new System.Drawing.Point(100, 68);
            this.TxtContraseña.MaxLength = 32767;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '\0';
            this.TxtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.SelectionLength = 0;
            this.TxtContraseña.SelectionStart = 0;
            this.TxtContraseña.ShortcutsEnabled = true;
            this.TxtContraseña.Size = new System.Drawing.Size(92, 23);
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.UseSelectable = true;
            this.TxtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Location = new System.Drawing.Point(11, 33);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(83, 19);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.Location = new System.Drawing.Point(6, 68);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(88, 19);
            this.LblContraseña.TabIndex = 5;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // PtcImagenSeguro
            // 
            this.PtcImagenSeguro.Image = global::PryMendozaIEDefinitivo.Properties.Resources.Seguros;
            this.PtcImagenSeguro.Location = new System.Drawing.Point(139, 106);
            this.PtcImagenSeguro.Name = "PtcImagenSeguro";
            this.PtcImagenSeguro.Size = new System.Drawing.Size(240, 149);
            this.PtcImagenSeguro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtcImagenSeguro.TabIndex = 6;
            this.PtcImagenSeguro.TabStop = false;
            // 
            // GrpInicioDeSesiòn
            // 
            this.GrpInicioDeSesiòn.Controls.Add(this.BtnIniciarSesion);
            this.GrpInicioDeSesiòn.Controls.Add(this.LblContraseña);
            this.GrpInicioDeSesiòn.Controls.Add(this.LblUsuario);
            this.GrpInicioDeSesiòn.Controls.Add(this.TxtContraseña);
            this.GrpInicioDeSesiòn.Controls.Add(this.TxtUsuario);
            this.GrpInicioDeSesiòn.Location = new System.Drawing.Point(139, 294);
            this.GrpInicioDeSesiòn.Name = "GrpInicioDeSesiòn";
            this.GrpInicioDeSesiòn.Size = new System.Drawing.Size(240, 143);
            this.GrpInicioDeSesiòn.TabIndex = 7;
            this.GrpInicioDeSesiòn.TabStop = false;
            this.GrpInicioDeSesiòn.Text = "Inicio de sesión";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(86, 114);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciarSesion.TabIndex = 8;
            this.BtnIniciarSesion.Text = "Inciar sesión";
            this.BtnIniciarSesion.UseSelectable = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.GrpInicioDeSesiòn);
            this.Controls.Add(this.PtcImagenSeguro);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtcImagenSeguro)).EndInit();
            this.GrpInicioDeSesiòn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel LblInicio;
        private MetroFramework.Controls.MetroTextBox TxtUsuario;
        private MetroFramework.Controls.MetroTextBox TxtContraseña;
        private MetroFramework.Controls.MetroLabel LblUsuario;
        private MetroFramework.Controls.MetroLabel LblContraseña;
        private System.Windows.Forms.PictureBox PtcImagenSeguro;
        private System.Windows.Forms.GroupBox GrpInicioDeSesiòn;
        private MetroFramework.Controls.MetroButton BtnIniciarSesion;
    }
}

