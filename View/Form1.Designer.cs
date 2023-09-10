namespace Trabalho_Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_raca = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_totalRegistro = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.Cb_filter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_rel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Animais";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 130);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(162, 187);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(425, 22);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raça do Animal:";
            // 
            // txt_raca
            // 
            this.txt_raca.Location = new System.Drawing.Point(153, 267);
            this.txt_raca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_raca.Name = "txt_raca";
            this.txt_raca.Size = new System.Drawing.Size(295, 22);
            this.txt_raca.TabIndex = 8;
            this.txt_raca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_raca_KeyPress);
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(153, 309);
            this.txt_cor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(207, 22);
            this.txt_cor.TabIndex = 10;
            this.txt_cor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor do Animal:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(153, 349);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(135, 22);
            this.txt_peso.TabIndex = 12;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso do Animal:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 226);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(391, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Propietario do Aninal:";
            // 
            // lbl_totalRegistro
            // 
            this.lbl_totalRegistro.AutoSize = true;
            this.lbl_totalRegistro.BackColor = System.Drawing.Color.LightGray;
            this.lbl_totalRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalRegistro.Location = new System.Drawing.Point(9, 5);
            this.lbl_totalRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalRegistro.Name = "lbl_totalRegistro";
            this.lbl_totalRegistro.Size = new System.Drawing.Size(195, 27);
            this.lbl_totalRegistro.TabIndex = 15;
            this.lbl_totalRegistro.Text = "Total de Registros";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorTotal.Location = new System.Drawing.Point(-1, 4);
            this.lbl_valorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(85, 33);
            this.lbl_valorTotal.TabIndex = 16;
            this.lbl_valorTotal.Text = "0";
            this.lbl_valorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_valorTotal.TextChanged += new System.EventHandler(this.lbl_valorTotal_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 437);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(786, 347);
            this.dataGridView1.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 13);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 22);
            this.textBox3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_totalRegistro);
            this.panel2.Location = new System.Drawing.Point(32, 796);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 42);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_valorTotal);
            this.panel3.Location = new System.Drawing.Point(261, 796);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 42);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.Cb_filter);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.btn_pesquisar);
            this.panel4.Location = new System.Drawing.Point(11, 381);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 50);
            this.panel4.TabIndex = 28;
            // 
            // Cb_filter
            // 
            this.Cb_filter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_filter.FormattingEnabled = true;
            this.Cb_filter.Items.AddRange(new object[] {
            "Código",
            "Nome Animal",
            "Nome Proprietário"});
            this.Cb_filter.Location = new System.Drawing.Point(601, 12);
            this.Cb_filter.Name = "Cb_filter";
            this.Cb_filter.Size = new System.Drawing.Size(175, 25);
            this.Cb_filter.TabIndex = 25;
            this.Cb_filter.Text = "Nome Animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Procurar:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(11, 134);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(788, 243);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btn_rel);
            this.panel6.Location = new System.Drawing.Point(13, 788);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 52);
            this.panel6.TabIndex = 32;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trabalho_Desktop.Properties.Resources.simbolo_de_ferramenta_preenchido_com_filtro;
            this.pictureBox3.Location = new System.Drawing.Point(563, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Image = global::Trabalho_Desktop.Properties.Resources.simbolo_de_interface_de_lupa_de_pesquisa;
            this.btn_pesquisar.Location = new System.Drawing.Point(484, 3);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(42, 41);
            this.btn_pesquisar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Pesquisar");
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkGray;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Enabled = false;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Image = global::Trabalho_Desktop.Properties.Resources.excluir__1_;
            this.btn_excluir.Location = new System.Drawing.Point(735, 794);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(46, 41);
            this.btn_excluir.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.EnabledChanged += new System.EventHandler(this.btn_excluir_EnabledChanged);
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::Trabalho_Desktop.Properties.Resources.sem_animais;
            this.btn_cancelar.Location = new System.Drawing.Point(671, 794);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(46, 41);
            this.btn_cancelar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.EnabledChanged += new System.EventHandler(this.btn_cancelar_EnabledChanged);
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Enabled = false;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::Trabalho_Desktop.Properties.Resources.salve_;
            this.btn_salvar.Location = new System.Drawing.Point(606, 794);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(46, 41);
            this.btn_salvar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btn_salvar, "Salvar");
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.EnabledChanged += new System.EventHandler(this.btn_salvar_EnabledChanged);
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar.Image = global::Trabalho_Desktop.Properties.Resources.clinica_de_cuidado_de_animais_domesticos;
            this.btn_criar.Location = new System.Drawing.Point(538, 794);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(46, 41);
            this.btn_criar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btn_criar, "Adicionar Animal");
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.EnabledChanged += new System.EventHandler(this.btn_criar_EnabledChanged);
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Trabalho_Desktop.Properties.Resources.cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(378, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Trabalho_Desktop.Properties.Resources.adicionar_foto__1_;
            this.button1.Location = new System.Drawing.Point(695, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 29;
            this.toolTip1.SetToolTip(this.button1, "Adicionar Foto");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.EnabledChanged += new System.EventHandler(this.button1_EnabledChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Trabalho_Desktop.Properties.Resources.excluir;
            this.button2.Location = new System.Drawing.Point(642, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 41);
            this.button2.TabIndex = 30;
            this.toolTip1.SetToolTip(this.button2, "Remover Foto");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.EnabledChanged += new System.EventHandler(this.button2_EnabledChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Trabalho_Desktop.Properties.Resources.cao;
            this.pictureBox2.Location = new System.Drawing.Point(601, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btn_rel
            // 
            this.btn_rel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_rel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rel.Image = global::Trabalho_Desktop.Properties.Resources.impressao__1_;
            this.btn_rel.Location = new System.Drawing.Point(339, 6);
            this.btn_rel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rel.Name = "btn_rel";
            this.btn_rel.Size = new System.Drawing.Size(46, 41);
            this.btn_rel.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_rel, "Excluir");
            this.btn_rel.UseVisualStyleBackColor = false;
            this.btn_rel.Click += new System.EventHandler(this.btn_rel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 851);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_raca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_raca;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_totalRegistro;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox Cb_filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_rel;
    }
}

