
namespace UsoDelOperadorToList
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMostrar.Location = new System.Drawing.Point(38, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(150, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Lista de Deportes ";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstLista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(237, 82);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(368, 290);
            this.lstLista.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsoDelOperadorToList.Properties.Resources.deport;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "DEPORTES QUE SE PRACTICAN EN EL SALVADOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstLista;
    }
}

