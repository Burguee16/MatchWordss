namespace MatchWords
{
    partial class Vocabulary
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Palabra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvWords
            // 
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Translate});
            this.dgvWords.Location = new System.Drawing.Point(12, 12);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.Size = new System.Drawing.Size(243, 327);
            this.dgvWords.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            // 
            // Translate
            // 
            this.Translate.HeaderText = "Translate";
            this.Translate.Name = "Translate";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(315, 74);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Vocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.button1);
            this.Name = "Vocabulary";
            this.Text = "Vocabulary";
            this.Load += new System.EventHandler(this.Vocabulary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translate;
        private System.Windows.Forms.Button btnVolver;
    }
}