
namespace MostrarDatosListBox
{
    partial class Form1
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
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstBoxTexto = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIngresar
            // 
            this.txtIngresar.Location = new System.Drawing.Point(137, 25);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(174, 20);
            this.txtIngresar.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(53, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ingresar Texto";
            // 
            // lstBoxTexto
            // 
            this.lstBoxTexto.FormattingEnabled = true;
            this.lstBoxTexto.Location = new System.Drawing.Point(137, 96);
            this.lstBoxTexto.Name = "lstBoxTexto";
            this.lstBoxTexto.Size = new System.Drawing.Size(174, 95);
            this.lstBoxTexto.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(351, 25);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(500, 24);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(100, 20);
            this.txtOtro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstBoxTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstBoxTexto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtOtro;
    }
}

