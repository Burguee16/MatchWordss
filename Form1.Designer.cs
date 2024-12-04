namespace MatchWords
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
            this.btnWord1 = new System.Windows.Forms.Button();
            this.btnTranslate1 = new System.Windows.Forms.Button();
            this.btnWord2 = new System.Windows.Forms.Button();
            this.btnTranslate2 = new System.Windows.Forms.Button();
            this.btnWord3 = new System.Windows.Forms.Button();
            this.btnTranslate3 = new System.Windows.Forms.Button();
            this.btnWord4 = new System.Windows.Forms.Button();
            this.btnTranslate4 = new System.Windows.Forms.Button();
            this.btnWord5 = new System.Windows.Forms.Button();
            this.btnTranslate5 = new System.Windows.Forms.Button();
            this.btnContador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWord1
            // 
            this.btnWord1.Location = new System.Drawing.Point(48, 27);
            this.btnWord1.Name = "btnWord1";
            this.btnWord1.Size = new System.Drawing.Size(135, 55);
            this.btnWord1.TabIndex = 0;
            this.btnWord1.Tag = "1";
            this.btnWord1.UseVisualStyleBackColor = true;
            this.btnWord1.Click += new System.EventHandler(this.btnWord1_Click);
            // 
            // btnTranslate1
            // 
            this.btnTranslate1.Location = new System.Drawing.Point(294, 27);
            this.btnTranslate1.Name = "btnTranslate1";
            this.btnTranslate1.Size = new System.Drawing.Size(135, 55);
            this.btnTranslate1.TabIndex = 1;
            this.btnTranslate1.Tag = "1";
            this.btnTranslate1.UseVisualStyleBackColor = true;
            // 
            // btnWord2
            // 
            this.btnWord2.Location = new System.Drawing.Point(48, 99);
            this.btnWord2.Name = "btnWord2";
            this.btnWord2.Size = new System.Drawing.Size(135, 55);
            this.btnWord2.TabIndex = 2;
            this.btnWord2.Tag = "2";
            this.btnWord2.UseVisualStyleBackColor = true;
            // 
            // btnTranslate2
            // 
            this.btnTranslate2.Location = new System.Drawing.Point(294, 99);
            this.btnTranslate2.Name = "btnTranslate2";
            this.btnTranslate2.Size = new System.Drawing.Size(135, 55);
            this.btnTranslate2.TabIndex = 3;
            this.btnTranslate2.Tag = "2";
            this.btnTranslate2.UseVisualStyleBackColor = true;
            // 
            // btnWord3
            // 
            this.btnWord3.Location = new System.Drawing.Point(48, 178);
            this.btnWord3.Name = "btnWord3";
            this.btnWord3.Size = new System.Drawing.Size(135, 55);
            this.btnWord3.TabIndex = 4;
            this.btnWord3.UseVisualStyleBackColor = true;
            // 
            // btnTranslate3
            // 
            this.btnTranslate3.Location = new System.Drawing.Point(294, 178);
            this.btnTranslate3.Name = "btnTranslate3";
            this.btnTranslate3.Size = new System.Drawing.Size(135, 55);
            this.btnTranslate3.TabIndex = 5;
            this.btnTranslate3.UseVisualStyleBackColor = true;
            // 
            // btnWord4
            // 
            this.btnWord4.Location = new System.Drawing.Point(48, 262);
            this.btnWord4.Name = "btnWord4";
            this.btnWord4.Size = new System.Drawing.Size(135, 55);
            this.btnWord4.TabIndex = 6;
            this.btnWord4.UseVisualStyleBackColor = true;
            // 
            // btnTranslate4
            // 
            this.btnTranslate4.Location = new System.Drawing.Point(294, 262);
            this.btnTranslate4.Name = "btnTranslate4";
            this.btnTranslate4.Size = new System.Drawing.Size(135, 55);
            this.btnTranslate4.TabIndex = 7;
            this.btnTranslate4.UseVisualStyleBackColor = true;
            // 
            // btnWord5
            // 
            this.btnWord5.Location = new System.Drawing.Point(48, 343);
            this.btnWord5.Name = "btnWord5";
            this.btnWord5.Size = new System.Drawing.Size(135, 55);
            this.btnWord5.TabIndex = 8;
            this.btnWord5.UseVisualStyleBackColor = true;
            // 
            // btnTranslate5
            // 
            this.btnTranslate5.Location = new System.Drawing.Point(294, 343);
            this.btnTranslate5.Name = "btnTranslate5";
            this.btnTranslate5.Size = new System.Drawing.Size(135, 55);
            this.btnTranslate5.TabIndex = 9;
            this.btnTranslate5.UseVisualStyleBackColor = true;
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(468, 12);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(75, 23);
            this.btnContador.TabIndex = 10;
            this.btnContador.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 421);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.btnTranslate5);
            this.Controls.Add(this.btnWord5);
            this.Controls.Add(this.btnTranslate4);
            this.Controls.Add(this.btnWord4);
            this.Controls.Add(this.btnTranslate3);
            this.Controls.Add(this.btnWord3);
            this.Controls.Add(this.btnTranslate2);
            this.Controls.Add(this.btnWord2);
            this.Controls.Add(this.btnTranslate1);
            this.Controls.Add(this.btnWord1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWord1;
        private System.Windows.Forms.Button btnTranslate1;
        private System.Windows.Forms.Button btnWord2;
        private System.Windows.Forms.Button btnTranslate2;
        private System.Windows.Forms.Button btnWord3;
        private System.Windows.Forms.Button btnTranslate3;
        private System.Windows.Forms.Button btnWord4;
        private System.Windows.Forms.Button btnTranslate4;
        private System.Windows.Forms.Button btnWord5;
        private System.Windows.Forms.Button btnTranslate5;
        private System.Windows.Forms.Button btnContador;
    }
}

