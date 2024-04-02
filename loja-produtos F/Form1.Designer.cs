namespace loja_produtos_F
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonADICIONAR = new System.Windows.Forms.Button();
            this.buttonFINALIZAR = new System.Windows.Forms.Button();
            this.buttonCANCELAR = new System.Windows.Forms.Button();
            this.textBoxTOTAL = new System.Windows.Forms.TextBox();
            this.textBoxUNIDADE = new System.Windows.Forms.TextBox();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.labelQUANTIDADE = new System.Windows.Forms.Label();
            this.labelLISTA = new System.Windows.Forms.Label();
            this.labelVALORUNIDADE = new System.Windows.Forms.Label();
            this.labelNOVAVENDA = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buttonADICIONAR
            // 
            this.buttonADICIONAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADICIONAR.Location = new System.Drawing.Point(55, 319);
            this.buttonADICIONAR.Name = "buttonADICIONAR";
            this.buttonADICIONAR.Size = new System.Drawing.Size(75, 45);
            this.buttonADICIONAR.TabIndex = 1;
            this.buttonADICIONAR.Text = "Adicionar";
            this.buttonADICIONAR.UseVisualStyleBackColor = true;
            this.buttonADICIONAR.Click += new System.EventHandler(this.buttonADICIONAR_Click);
            // 
            // buttonFINALIZAR
            // 
            this.buttonFINALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFINALIZAR.Location = new System.Drawing.Point(136, 319);
            this.buttonFINALIZAR.Name = "buttonFINALIZAR";
            this.buttonFINALIZAR.Size = new System.Drawing.Size(75, 45);
            this.buttonFINALIZAR.TabIndex = 2;
            this.buttonFINALIZAR.Text = "Finalizar";
            this.buttonFINALIZAR.UseVisualStyleBackColor = true;
            this.buttonFINALIZAR.Click += new System.EventHandler(this.buttonFINALIZAR_Click);
            // 
            // buttonCANCELAR
            // 
            this.buttonCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCANCELAR.Location = new System.Drawing.Point(217, 319);
            this.buttonCANCELAR.Name = "buttonCANCELAR";
            this.buttonCANCELAR.Size = new System.Drawing.Size(75, 45);
            this.buttonCANCELAR.TabIndex = 3;
            this.buttonCANCELAR.Text = "Cancelar";
            this.buttonCANCELAR.UseVisualStyleBackColor = true;
            this.buttonCANCELAR.Click += new System.EventHandler(this.buttonCANCELAR_Click);
            // 
            // textBoxTOTAL
            // 
            this.textBoxTOTAL.Location = new System.Drawing.Point(610, 406);
            this.textBoxTOTAL.Name = "textBoxTOTAL";
            this.textBoxTOTAL.Size = new System.Drawing.Size(165, 20);
            this.textBoxTOTAL.TabIndex = 5;
            // 
            // textBoxUNIDADE
            // 
            this.textBoxUNIDADE.Location = new System.Drawing.Point(560, 149);
            this.textBoxUNIDADE.Name = "textBoxUNIDADE";
            this.textBoxUNIDADE.Size = new System.Drawing.Size(120, 20);
            this.textBoxUNIDADE.TabIndex = 6;
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOTAL.Location = new System.Drawing.Point(556, 404);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(48, 20);
            this.labelTOTAL.TabIndex = 7;
            this.labelTOTAL.Text = "Total:";
            // 
            // labelQUANTIDADE
            // 
            this.labelQUANTIDADE.AutoSize = true;
            this.labelQUANTIDADE.Location = new System.Drawing.Point(489, 114);
            this.labelQUANTIDADE.Name = "labelQUANTIDADE";
            this.labelQUANTIDADE.Size = new System.Drawing.Size(65, 13);
            this.labelQUANTIDADE.TabIndex = 8;
            this.labelQUANTIDADE.Text = "Quantidade:";
            // 
            // labelLISTA
            // 
            this.labelLISTA.AutoSize = true;
            this.labelLISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLISTA.Location = new System.Drawing.Point(24, 15);
            this.labelLISTA.Name = "labelLISTA";
            this.labelLISTA.Size = new System.Drawing.Size(204, 25);
            this.labelLISTA.TabIndex = 10;
            this.labelLISTA.Text = "Lista de Produtos ";
            // 
            // labelVALORUNIDADE
            // 
            this.labelVALORUNIDADE.AutoSize = true;
            this.labelVALORUNIDADE.Location = new System.Drawing.Point(478, 152);
            this.labelVALORUNIDADE.Name = "labelVALORUNIDADE";
            this.labelVALORUNIDADE.Size = new System.Drawing.Size(77, 13);
            this.labelVALORUNIDADE.TabIndex = 9;
            this.labelVALORUNIDADE.Text = "Valor Unidade:";
            // 
            // labelNOVAVENDA
            // 
            this.labelNOVAVENDA.AutoSize = true;
            this.labelNOVAVENDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOVAVENDA.Location = new System.Drawing.Point(549, 9);
            this.labelNOVAVENDA.Name = "labelNOVAVENDA";
            this.labelNOVAVENDA.Size = new System.Drawing.Size(173, 29);
            this.labelNOVAVENDA.TabIndex = 11;
            this.labelNOVAVENDA.Text = "NOVA VENDA ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(560, 112);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelNOVAVENDA);
            this.Controls.Add(this.labelLISTA);
            this.Controls.Add(this.labelVALORUNIDADE);
            this.Controls.Add(this.labelQUANTIDADE);
            this.Controls.Add(this.labelTOTAL);
            this.Controls.Add(this.textBoxUNIDADE);
            this.Controls.Add(this.textBoxTOTAL);
            this.Controls.Add(this.buttonCANCELAR);
            this.Controls.Add(this.buttonFINALIZAR);
            this.Controls.Add(this.buttonADICIONAR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1 :";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonADICIONAR;
        private System.Windows.Forms.Button buttonFINALIZAR;
        private System.Windows.Forms.Button buttonCANCELAR;
        private System.Windows.Forms.TextBox textBoxTOTAL;
        private System.Windows.Forms.TextBox textBoxUNIDADE;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.Label labelQUANTIDADE;
        private System.Windows.Forms.Label labelLISTA;
        private System.Windows.Forms.Label labelVALORUNIDADE;
        private System.Windows.Forms.Label labelNOVAVENDA;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

