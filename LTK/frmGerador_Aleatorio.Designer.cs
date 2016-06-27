namespace LTK
{
    partial class frmGerador_Aleatorio
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkPar_Impar = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAposta_Quantidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAposta_com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJogo_Tipo = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grJogos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.bgLtk = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 579);
            this.panel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(771, 579);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbAposta_Quantidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbAposta_com);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbJogo_Tipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 128);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chkPar_Impar);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribuição:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(585, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Não repetir o número que saiu nos concursos anteriores, enquanto houver número ai" +
    "nda não sorteado. (recomendado)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkPar_Impar
            // 
            this.chkPar_Impar.AutoSize = true;
            this.chkPar_Impar.Location = new System.Drawing.Point(6, 19);
            this.chkPar_Impar.Name = "chkPar_Impar";
            this.chkPar_Impar.Size = new System.Drawing.Size(74, 17);
            this.chkPar_Impar.TabIndex = 11;
            this.chkPar_Impar.Text = "Par; Impar";
            this.chkPar_Impar.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(684, 23);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade de jogos:";
            // 
            // cmbAposta_Quantidade
            // 
            this.cmbAposta_Quantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAposta_Quantidade.FormattingEnabled = true;
            this.cmbAposta_Quantidade.Location = new System.Drawing.Point(412, 25);
            this.cmbAposta_Quantidade.Name = "cmbAposta_Quantidade";
            this.cmbAposta_Quantidade.Size = new System.Drawing.Size(105, 21);
            this.cmbAposta_Quantidade.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apostas com:";
            // 
            // cmbAposta_com
            // 
            this.cmbAposta_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAposta_com.FormattingEnabled = true;
            this.cmbAposta_com.Location = new System.Drawing.Point(268, 23);
            this.cmbAposta_com.Name = "cmbAposta_com";
            this.cmbAposta_com.Size = new System.Drawing.Size(68, 21);
            this.cmbAposta_com.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jogo:";
            // 
            // cmbJogo_Tipo
            // 
            this.cmbJogo_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJogo_Tipo.FormattingEnabled = true;
            this.cmbJogo_Tipo.Location = new System.Drawing.Point(12, 25);
            this.cmbJogo_Tipo.Name = "cmbJogo_Tipo";
            this.cmbJogo_Tipo.Size = new System.Drawing.Size(177, 21);
            this.cmbJogo_Tipo.TabIndex = 1;
            this.cmbJogo_Tipo.SelectedIndexChanged += new System.EventHandler(this.cmbJogo_Tipo_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grJogos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.btnImportar);
            this.splitContainer2.Panel2.Controls.Add(this.btnExportar);
            this.splitContainer2.Panel2.Controls.Add(this.btnCopiar);
            this.splitContainer2.Size = new System.Drawing.Size(771, 446);
            this.splitContainer2.SplitterDistance = 663;
            this.splitContainer2.TabIndex = 0;
            // 
            // grJogos
            // 
            this.grJogos.AllowUserToAddRows = false;
            this.grJogos.AllowUserToDeleteRows = false;
            this.grJogos.AllowUserToOrderColumns = true;
            this.grJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grJogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grJogos.Location = new System.Drawing.Point(0, 0);
            this.grJogos.Name = "grJogos";
            this.grJogos.Size = new System.Drawing.Size(663, 446);
            this.grJogos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoEllipsis = true;
            this.button2.Location = new System.Drawing.Point(17, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Apagar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.AutoEllipsis = true;
            this.btnImportar.Location = new System.Drawing.Point(17, 64);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "&Importar...";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(17, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "&Exportar...";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiar.Location = new System.Drawing.Point(17, 3);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "&Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // bgLtk
            // 
            this.bgLtk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLtk_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "números.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "números.";
            // 
            // frmGerador_Aleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 579);
            this.Controls.Add(this.panel3);
            this.Name = "frmGerador_Aleatorio";
            this.Text = "Gerador aleatório";
            this.Load += new System.EventHandler(this.frmGerador_Aleatorio_Load);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkPar_Impar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAposta_Quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAposta_com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJogo_Tipo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView grJogos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCopiar;
        private System.ComponentModel.BackgroundWorker bgLtk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}