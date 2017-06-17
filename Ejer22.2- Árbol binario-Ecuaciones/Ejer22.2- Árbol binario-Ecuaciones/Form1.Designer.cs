namespace Ejer22._2__Árbol_binario_Ecuaciones
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
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnResolverPre = new System.Windows.Forms.Button();
            this.btnResolverPost = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(302, 9);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(112, 34);
            this.btnCrearArbol.TabIndex = 0;
            this.btnCrearArbol.Text = "Crear Árbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(13, 13);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(283, 26);
            this.txtCadena.TabIndex = 1;
            this.txtCadena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadena_KeyPress);
            // 
            // btnResolverPre
            // 
            this.btnResolverPre.Enabled = false;
            this.btnResolverPre.Location = new System.Drawing.Point(13, 55);
            this.btnResolverPre.Name = "btnResolverPre";
            this.btnResolverPre.Size = new System.Drawing.Size(100, 51);
            this.btnResolverPre.TabIndex = 2;
            this.btnResolverPre.Text = "Resolver Pre-Order";
            this.btnResolverPre.UseVisualStyleBackColor = true;
            this.btnResolverPre.Click += new System.EventHandler(this.btnResolverPre_Click);
            // 
            // btnResolverPost
            // 
            this.btnResolverPost.Enabled = false;
            this.btnResolverPost.Location = new System.Drawing.Point(128, 55);
            this.btnResolverPost.Name = "btnResolverPost";
            this.btnResolverPost.Size = new System.Drawing.Size(100, 51);
            this.btnResolverPost.TabIndex = 3;
            this.btnResolverPost.Text = "Resolver Post-Order";
            this.btnResolverPost.UseVisualStyleBackColor = true;
            this.btnResolverPost.Click += new System.EventHandler(this.btnResolverPost_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(262, 55);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(152, 51);
            this.txtRespuesta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 121);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnResolverPost);
            this.Controls.Add(this.btnResolverPre);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.btnCrearArbol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnResolverPre;
        private System.Windows.Forms.Button btnResolverPost;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}

