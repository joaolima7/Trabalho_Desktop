using Trabalho_Desktop.Controller;
using Trabalho_Desktop.Model;
using Trabalho_Desktop.View;
using Trabalho_Desktop.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;

namespace Trabalho_Desktop
{
    public partial class Form1 : Form
    {
        private ConectaBanco conexaoBanco = new ConectaBanco(); // Instancie a classe de conexão
        string connectionString = @"Server=.;Database=TRABALHO_DESKTOP_SQL;
                                    Trusted_Connection=True;";
        bool novo;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable animais;
        SqlDataReader tabAnimal;
        DataRow[] linhaAtual;

        private string caminhoFoto;
        int posicao = 0;

        //Carrega as informações no DatagridView1 com os dados dos clientes
        public void carregarTabela()
        {
            //define a instrução SQL
            string strSql = "SELECT * FROM animal order by nomeanimal";

            ConectaBanco conectaBanco = new ConectaBanco();
            con = conectaBanco.conectaSqlServer(); 

            //cria o objeto command para executar a instruçao sql
            cmd = new SqlCommand(strSql, con);
            //abre a conexao
            con.Open();
            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            da = new SqlDataAdapter(cmd);
            //cria um objeto datatable
            animais = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(animais);
            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = animais;

            linhaAtual = animais.Select();

            posicao = Int32.Parse(TotalRegistros()) - 1;
            if (posicao == -1)
            {
                MessageBox.Show("Não Existem Registros!");
            }
            else
            {

                txt_id.Text = linhaAtual[0]["codanimal"].ToString();
                txt_nome.Text = linhaAtual[0]["nomeanimal"].ToString();
                txt_raca.Text = linhaAtual[0]["raca"].ToString();
                txt_cor.Text = linhaAtual[0]["cor"].ToString();
                txt_peso.Text = linhaAtual[0]["peso"].ToString();
                txt_propietario.Text = linhaAtual[0]["propietario"].ToString();
                byte[] imagemBytes = (byte[])linhaAtual[0]["foto"];
                Image imagem = ByteArrayToImage(imagemBytes);

                pb_fotoAnimal.Image = imagem;

            }

        }

        string TotalRegistros()
        {
            //CONSULTA QUE RETORNA A QUANTIDADE DE CLIENTES NO BANCO
            string sqlBuscarId = "select count(nomeanimal) as total from animal";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@nomeanimal", txt_buscar.Text + "%");
            cmd.CommandType = CommandType.Text;

            con.Open();
            string total = "";
            try
            {
                tabAnimal = cmd.ExecuteReader();
                if (tabAnimal.Read())
                {
                    total = (tabAnimal[0].ToString());

                }
                else
                {
                    MessageBox.Show("Pet não Encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar!!!");
            }

            finally
            {
                con.Close();
            }

            return total;
        }

        private void limpaCampos()
        {
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_propietario.Text = "";
            txt_raca.Text = "";
            txt_cor.Text = "";
            txt_peso.Text = "";

            btn_criar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
            btn_excluirFoto.Enabled = false;
            btn_addFoto.Enabled = false;

            txt_nome.Enabled = false;
            txt_propietario.Enabled = false;
            txt_raca.Enabled = false;
            txt_cor.Enabled = false;
            txt_peso.Enabled = false;
        }

        //private void LimparFoto()
        //{
        //    pb_fotoAnimal.Image = null; // Limpa a imagem no PictureBox
        //    caminhoFoto = string.Empty; // Limpa o caminho da foto
        //}

        private bool fechaform = false;

        public Form1()
        {
            InitializeComponent();
            carregarTabela();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_valorTotal_TextChanged(object sender, EventArgs e)
        {
            if (lbl_valorTotal.Text == "0")
            {
                panel3.BackColor = Color.IndianRed;
            }
            else
            {
                panel3.BackColor = Color.CornflowerBlue;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            string sqlBuscarId = "select * from animal where nomeanimal LIKE @nome order by nomeanimal";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@nome", txt_buscar.Text + "%");
            cmd.CommandType = CommandType.Text;

            SqlDataReader tabAnimal;
            con.Open();

            //carregando dataGrid
            //cria um dataadpter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //cria uma objeto datatable
            DataTable animais = new DataTable();
            //preenche o datatable via dataadpter
            da.Fill(animais);
            //atribui o datatable ao datagridview para exibir os resultados
            dataGridView1.DataSource = animais;
            //fim do carregamento do datagrid
            try
            {
                tabAnimal = cmd.ExecuteReader();
                if (tabAnimal.Read())
                {
                    TotalRegistros();
                    txt_id.Text = tabAnimal[0].ToString();
                    txt_nome.Text = tabAnimal[1].ToString();
                    txt_propietario.Text = tabAnimal[5].ToString();
                    txt_raca.Text = tabAnimal[2].ToString();
                    txt_cor.Text = tabAnimal[3].ToString();
                    txt_peso.Text = tabAnimal[4].ToString();

                    //ativar controle dos botões
                    btn_criar.Enabled = false;
                    btn_salvar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_excluirFoto.Enabled = true;
                    btn_addFoto.Enabled = true;

                    txt_nome.Enabled = true;
                    txt_propietario.Enabled = true;
                    txt_raca.Enabled = true;
                    txt_cor.Enabled = true;
                    txt_peso.Enabled = true;
                    txt_nome.Focus();
                    novo = false;
                }
                else
                {
                    MessageBox.Show("Pet Encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar!!!\\n Error:\" + ex.ToString()");
            }

            finally
            {
                con.Close();
            }
            txt_buscar.Text = string.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btn_criar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;

            txt_nome.Enabled = false;
            txt_propietario.Enabled = false;
            txt_raca.Enabled = false;
            txt_cor.Enabled = false;
            txt_peso.Enabled = false;

            lbl_valorTotal.Text = TotalRegistros();

        }



        private void btn_criar_Click(object sender, EventArgs e)
        {


            limpaCampos();
            btn_salvar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_criar.Enabled = false;
            btn_excluirFoto.Enabled = true;
            btn_addFoto.Enabled = true;


            txt_nome.Enabled = true;
            txt_propietario.Enabled = true;
            txt_raca.Enabled = true;
            txt_cor.Enabled = true;
            txt_peso.Enabled = true;
            txt_nome.Focus();
            novo = true;

        }



        private void btn_salvar_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_criar.Enabled = true;
            btn_excluirFoto.Enabled = true;
            btn_addFoto.Enabled = true;

            if (novo)
            {
                if (!string.IsNullOrEmpty(caminhoFoto))
                {
                    Animal animal = new Animal();
                    animal.NomeAnimal = txt_nome.Text;
                    animal.NomeProprietario = txt_propietario.Text;
                    animal.RacaAnimal = txt_raca.Text;
                    animal.CorAnimal = txt_cor.Text;
                    animal.PesoAnimal = txt_peso.Text;

                    // Lê a imagem do arquivo no caminho especificado
                    byte[] imagemBytes = File.ReadAllBytes(caminhoFoto);

                    // Chamar o método inserirDados da ControllerAnimal
                    ControllerAnimal c_Animal = new ControllerAnimal();
                    c_Animal.inserirDados(animal, imagemBytes);

                    // Limpe o campo de caminho da foto após a inserção
                    caminhoFoto = string.Empty;
                    carregarTabela();
                    limpaCampos();
                    TotalRegistros();
                    // Chamar a função para limpar o PictureBox
                    //LimparFoto();
                }
            }
            else // Editar registro existente
            {
                Animal animal = new Animal();
                animal.CodAnimal = Int32.Parse(txt_id.Text);
                animal.NomeAnimal = txt_nome.Text;
                animal.NomeProprietario = txt_propietario.Text;
                animal.RacaAnimal = txt_raca.Text;
                animal.CorAnimal = txt_cor.Text;
                animal.PesoAnimal = txt_peso.Text;

                // Verifica se há uma nova foto selecionada
                if (!string.IsNullOrEmpty(caminhoFoto))
                {
                    // Lê a imagem do arquivo no caminho especificado
                    byte[] imagemBytes = File.ReadAllBytes(caminhoFoto);

                    // Atualiza o animal, incluindo a foto, no banco de dados
                    ControllerAnimal c_Animal = new ControllerAnimal();
                    c_Animal.editarDados(animal, imagemBytes);
                }
                else
                {
                    // Se nenhuma nova foto foi selecionada, atualize apenas os dados do animal
                    ControllerAnimal c_Animal = new ControllerAnimal();
                    c_Animal.editarDadosSemImagem(animal);
                }

                carregarTabela();

                //Coloca a tela no estado inicial
                btn_criar.Enabled = true;
                btn_salvar.Enabled = false;
                btn_cancelar.Enabled = false;
                btn_excluir.Enabled = false;
                btn_pesquisar.Enabled = true;
                btn_excluirFoto.Enabled = false;
                btn_addFoto.Enabled = false;

                txt_nome.Enabled = false;
                txt_propietario.Enabled = false;
                txt_raca.Enabled = false;
                txt_cor.Enabled = false;
                txt_peso.Enabled = false;

                txt_id.Text = "";
                txt_nome.Text = "";
                txt_propietario.Text = "";
                txt_raca.Text = "";
                txt_cor.Text = "";
                txt_peso.Text = "";
            }

            // Limpar o campo de caminho da foto após o uso
            caminhoFoto = string.Empty;
        }




        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Chamar a função para limpar o PictureBox
            //LimparFoto();
            limpaCampos();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                int id;
                if (int.TryParse(txt_id.Text, out id))
                {
                    ControllerAnimal c_Animal= new ControllerAnimal();
                    c_Animal.apagarDados(id);

                    limpaCampos();
                    carregarTabela();
                    TotalRegistros();
                    // Chamar a função para limpar o PictureBox
                    //LimparFoto();
                }
                else
                {
                    MessageBox.Show("ID inválido. Por favor, insira um número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID para excluir.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fechaform)
            {
                DialogResult dr = MessageBox.Show("Deseja sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    fechaform = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_cor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_raca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_rel_Click(object sender, EventArgs e)
        {
           FrmRel report = new FrmRel();
           this.Hide();
            report.ShowDialog();
            this.Show();
        }

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = openFileDialog.FileName;
                // Exiba a foto no PictureBox pb_fotoAnimal
                pb_fotoAnimal.Image = Image.FromFile(caminhoFoto);
            }
        }

        private void btn_excluirFoto_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

                int index = e.RowIndex;

                txt_id.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_nome.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txt_propietario.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txt_raca.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txt_cor.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txt_peso.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                //passar imagem para o picturebox e convertela
                byte[] imagemBytes = (byte[])dataGridView1.Rows[index].Cells[6].Value;
                Image imagem = ByteArrayToImage(imagemBytes);

                pb_fotoAnimal.Image = imagem;
        }

        // Método para converter bytes em uma image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private void pb_fotoAnimal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
