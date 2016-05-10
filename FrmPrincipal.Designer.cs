namespace Loto
{
    partial class frmPrincipal
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.openFileDialogLoto = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl14pontos = new System.Windows.Forms.Label();
            this.lbl13pontos = new System.Windows.Forms.Label();
            this.lbl12pontos = new System.Windows.Forms.Label();
            this.lbl11pontos = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnConferir = new System.Windows.Forms.Button();
            this.lbl15pontos = new System.Windows.Forms.Label();
            this.lbl5pontos = new System.Windows.Forms.Label();
            this.lbl3pontos = new System.Windows.Forms.Label();
            this.lbl4pontos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(606, 445);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // openFileDialogLoto
            // 
            this.openFileDialogLoto.FileName = "Escolha arquivo";
            this.openFileDialogLoto.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 500);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCarregar);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aposta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(603, 448);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Le";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(675, 431);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl4pontos);
            this.tabPage3.Controls.Add(this.lbl3pontos);
            this.tabPage3.Controls.Add(this.lbl5pontos);
            this.tabPage3.Controls.Add(this.lbl15pontos);
            this.tabPage3.Controls.Add(this.lbl14pontos);
            this.tabPage3.Controls.Add(this.lbl13pontos);
            this.tabPage3.Controls.Add(this.lbl12pontos);
            this.tabPage3.Controls.Add(this.lbl11pontos);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btnConferir);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(689, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conferencia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl14pontos
            // 
            this.lbl14pontos.AutoSize = true;
            this.lbl14pontos.Location = new System.Drawing.Point(250, 417);
            this.lbl14pontos.Name = "lbl14pontos";
            this.lbl14pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl14pontos.TabIndex = 7;
            this.lbl14pontos.Text = "label3";
            // 
            // lbl13pontos
            // 
            this.lbl13pontos.AutoSize = true;
            this.lbl13pontos.Location = new System.Drawing.Point(6, 451);
            this.lbl13pontos.Name = "lbl13pontos";
            this.lbl13pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl13pontos.TabIndex = 6;
            this.lbl13pontos.Text = "label2";
            // 
            // lbl12pontos
            // 
            this.lbl12pontos.AutoSize = true;
            this.lbl12pontos.Location = new System.Drawing.Point(6, 434);
            this.lbl12pontos.Name = "lbl12pontos";
            this.lbl12pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl12pontos.TabIndex = 5;
            this.lbl12pontos.Text = "label1";
            // 
            // lbl11pontos
            // 
            this.lbl11pontos.AutoSize = true;
            this.lbl11pontos.Location = new System.Drawing.Point(6, 417);
            this.lbl11pontos.Name = "lbl11pontos";
            this.lbl11pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl11pontos.TabIndex = 4;
            this.lbl11pontos.Text = "label1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(675, 411);
            this.dataGridView3.TabIndex = 3;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(606, 445);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(75, 23);
            this.btnConferir.TabIndex = 0;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // lbl15pontos
            // 
            this.lbl15pontos.AutoSize = true;
            this.lbl15pontos.Location = new System.Drawing.Point(250, 434);
            this.lbl15pontos.Name = "lbl15pontos";
            this.lbl15pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl15pontos.TabIndex = 8;
            this.lbl15pontos.Text = "label3";
            // 
            // lbl5pontos
            // 
            this.lbl5pontos.AutoSize = true;
            this.lbl5pontos.Location = new System.Drawing.Point(446, 451);
            this.lbl5pontos.Name = "lbl5pontos";
            this.lbl5pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl5pontos.TabIndex = 9;
            this.lbl5pontos.Text = "label3";
            // 
            // lbl3pontos
            // 
            this.lbl3pontos.AutoSize = true;
            this.lbl3pontos.Location = new System.Drawing.Point(446, 417);
            this.lbl3pontos.Name = "lbl3pontos";
            this.lbl3pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl3pontos.TabIndex = 10;
            this.lbl3pontos.Text = "label3";
            // 
            // lbl4pontos
            // 
            this.lbl4pontos.AutoSize = true;
            this.lbl4pontos.Location = new System.Drawing.Point(446, 434);
            this.lbl4pontos.Name = "lbl4pontos";
            this.lbl4pontos.Size = new System.Drawing.Size(35, 13);
            this.lbl4pontos.TabIndex = 11;
            this.lbl4pontos.Text = "label3";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Estatistica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnConferir;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbl14pontos;
        private System.Windows.Forms.Label lbl13pontos;
        private System.Windows.Forms.Label lbl12pontos;
        private System.Windows.Forms.Label lbl11pontos;
        private System.Windows.Forms.Label lbl15pontos;
        private System.Windows.Forms.Label lbl5pontos;
        private System.Windows.Forms.Label lbl4pontos;
        private System.Windows.Forms.Label lbl3pontos;
    }
}

