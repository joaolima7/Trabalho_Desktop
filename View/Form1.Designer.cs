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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_raca = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_propietario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_totalRegistro = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_addFoto = new System.Windows.Forms.Button();
            this.btn_excluirFoto = new System.Windows.Forms.Button();
            this.btn_rel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Cb_filter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pb_fotoAnimal = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAnimal)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Animais";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 106);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(71, 119);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 20);
            this.txt_id.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(122, 152);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 20);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raça do Animal:";
            // 
            // txt_raca
            // 
            this.txt_raca.Location = new System.Drawing.Point(115, 217);
            this.txt_raca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_raca.Name = "txt_raca";
            this.txt_raca.Size = new System.Drawing.Size(222, 20);
            this.txt_raca.TabIndex = 8;
            this.txt_raca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_raca_KeyPress);
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(115, 251);
            this.txt_cor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(156, 20);
            this.txt_cor.TabIndex = 10;
            this.txt_cor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor do Animal:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(115, 284);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(2);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(102, 20);
            this.txt_peso.TabIndex = 12;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso do Animal:";
            // 
            // txt_propietario
            // 
            this.txt_propietario.Location = new System.Drawing.Point(145, 184);
            this.txt_propietario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_propietario.Name = "txt_propietario";
            this.txt_propietario.Size = new System.Drawing.Size(294, 20);
            this.txt_propietario.TabIndex = 14;
            this.txt_propietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Propietario do Aninal:";
            // 
            // lbl_totalRegistro
            // 
            this.lbl_totalRegistro.AutoSize = true;
            this.lbl_totalRegistro.BackColor = System.Drawing.Color.LightGray;
            this.lbl_totalRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalRegistro.Location = new System.Drawing.Point(7, 4);
            this.lbl_totalRegistro.Name = "lbl_totalRegistro";
            this.lbl_totalRegistro.Size = new System.Drawing.Size(159, 22);
            this.lbl_totalRegistro.TabIndex = 15;
            this.lbl_totalRegistro.Text = "Total de Registros";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorTotal.Location = new System.Drawing.Point(-1, 3);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(64, 27);
            this.lbl_valorTotal.TabIndex = 16;
            this.lbl_valorTotal.Text = "0";
            this.lbl_valorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_valorTotal.TextChanged += new System.EventHandler(this.lbl_valorTotal_TextChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(72, 11);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(286, 20);
            this.txt_buscar.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_totalRegistro);
            this.panel2.Location = new System.Drawing.Point(24, 647);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 35);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_valorTotal);
            this.panel3.Location = new System.Drawing.Point(196, 647);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 35);
            this.panel3.TabIndex = 25;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Image = global::Trabalho_Desktop.Properties.Resources.simbolo_de_interface_de_lupa_de_pesquisa;
            this.btn_pesquisar.Location = new System.Drawing.Point(363, 2);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(32, 33);
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
            this.btn_excluir.Location = new System.Drawing.Point(551, 645);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(34, 33);
            this.btn_excluir.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::Trabalho_Desktop.Properties.Resources.cancelar_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(503, 645);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(34, 33);
            this.btn_cancelar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Enabled = false;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::Trabalho_Desktop.Properties.Resources.salve_;
            this.btn_salvar.Location = new System.Drawing.Point(454, 645);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(34, 33);
            this.btn_salvar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btn_salvar, "Salvar");
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar.Image = global::Trabalho_Desktop.Properties.Resources.adicionar_icon;
            this.btn_criar.Location = new System.Drawing.Point(404, 645);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(34, 33);
            this.btn_criar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btn_criar, "Adicionar Animal");
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_addFoto
            // 
            this.btn_addFoto.BackColor = System.Drawing.Color.DarkGray;
            this.btn_addFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addFoto.Enabled = false;
            this.btn_addFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFoto.Image = global::Trabalho_Desktop.Properties.Resources.adicionar_foto__1_;
            this.btn_addFoto.Location = new System.Drawing.Point(521, 153);
            this.btn_addFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addFoto.Name = "btn_addFoto";
            this.btn_addFoto.Size = new System.Drawing.Size(32, 33);
            this.btn_addFoto.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btn_addFoto, "Adicionar Foto");
            this.btn_addFoto.UseVisualStyleBackColor = false;
            this.btn_addFoto.Click += new System.EventHandler(this.btn_addFoto_Click);
            // 
            // btn_excluirFoto
            // 
            this.btn_excluirFoto.BackColor = System.Drawing.Color.DarkGray;
            this.btn_excluirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirFoto.Enabled = false;
            this.btn_excluirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluirFoto.Image = global::Trabalho_Desktop.Properties.Resources.excluir;
            this.btn_excluirFoto.Location = new System.Drawing.Point(478, 153);
            this.btn_excluirFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excluirFoto.Name = "btn_excluirFoto";
            this.btn_excluirFoto.Size = new System.Drawing.Size(32, 33);
            this.btn_excluirFoto.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btn_excluirFoto, "Remover Foto");
            this.btn_excluirFoto.UseVisualStyleBackColor = false;
            this.btn_excluirFoto.Click += new System.EventHandler(this.btn_excluirFoto_Click);
            // 
            // btn_rel
            // 
            this.btn_rel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_rel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rel.Image = global::Trabalho_Desktop.Properties.Resources.impressao__1_;
            this.btn_rel.Location = new System.Drawing.Point(254, 5);
            this.btn_rel.Name = "btn_rel";
            this.btn_rel.Size = new System.Drawing.Size(34, 33);
            this.btn_rel.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_rel, "Excluir");
            this.btn_rel.UseVisualStyleBackColor = false;
            this.btn_rel.Click += new System.EventHandler(this.btn_rel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.Cb_filter);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_buscar);
            this.panel4.Controls.Add(this.btn_pesquisar);
            this.panel4.Location = new System.Drawing.Point(8, 310);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 41);
            this.panel4.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(422, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // Cb_filter
            // 
            this.Cb_filter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_filter.FormattingEnabled = true;
            this.Cb_filter.Items.AddRange(new object[] {
            "Código",
            "Nome Animal",
            "Nome Proprietário"});
            this.Cb_filter.Location = new System.Drawing.Point(451, 10);
            this.Cb_filter.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_filter.Name = "Cb_filter";
            this.Cb_filter.Size = new System.Drawing.Size(132, 23);
            this.Cb_filter.TabIndex = 25;
            this.Cb_filter.Text = "Nome Animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Procurar:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btn_addFoto);
            this.panel5.Controls.Add(this.btn_excluirFoto);
            this.panel5.Controls.Add(this.pb_fotoAnimal);
            this.panel5.Location = new System.Drawing.Point(8, 109);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 198);
            this.panel5.TabIndex = 31;
            // 
            // pb_fotoAnimal
            // 
            this.pb_fotoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_fotoAnimal.Image = global::Trabalho_Desktop.Properties.Resources.cao;
            this.pb_fotoAnimal.Location = new System.Drawing.Point(451, 9);
            this.pb_fotoAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.pb_fotoAnimal.Name = "pb_fotoAnimal";
            this.pb_fotoAnimal.Size = new System.Drawing.Size(132, 139);
            this.pb_fotoAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_fotoAnimal.TabIndex = 27;
            this.pb_fotoAnimal.TabStop = false;
            this.pb_fotoAnimal.Click += new System.EventHandler(this.pb_fotoAnimal_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btn_rel);
            this.panel6.Location = new System.Drawing.Point(10, 640);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(592, 43);
            this.panel6.TabIndex = 32;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Trabalho_Desktop.Properties.Resources.cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(284, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 279);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Trabalho_Desktop.Model.Animal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.txt_propietario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_raca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAnimal)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_raca;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_propietario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_totalRegistro;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.PictureBox pb_fotoAnimal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox Cb_filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addFoto;
        private System.Windows.Forms.Button btn_excluirFoto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_rel;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

