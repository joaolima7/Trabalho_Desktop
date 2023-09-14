using Trabalho_Desktop.Conexao;
using Trabalho_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Desktop.Controller
{
    internal class ControllerAnimal : I_CRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        private readonly string connectionString = @"Server=.;Database=TRABALHO_DESKTOP_SQL;
                                    Trusted_Connection=True;";


        string sqlInsere = "INSERT INTO ANIMAL (NOMEANIMAL, RACA, COR, PESO, PROPIETARIO, FOTO) " +
                           "VALUES (@Nome, @Raca, @Cor, @Peso, @Propietario, @Foto)";

        string sqlEditar = "UPDATE ANIMAL SET NOMEANIMAL = @Nome, " +
            "RACA = @Raca, COR = @Cor, PESO = @Peso, " +
            "PROPIETARIO = @Propietario " +
            "WHERE codanimal = @Id";

        string sqlEditarSemImagem = "UPDATE ANIMAL SET NOMEANIMAL = @Nome, " +
                        "RACA = @Raca, COR = @Cor, PESO = @Peso, " +
                        "PROPIETARIO = @Propietario " + // Adicione um espaço em branco aqui
                        "WHERE codanimal = @Id";

        string sqlApagar = "DELETE FROM ANIMAL WHERE codanimal = @Id";

        string sqlBuscarId = "select * from animal where codanimal = @Id";

        public void apagarDados(int valor)
        {
            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlApagar, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", valor);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Pet deletado com Sucesso!!!\n" +
                        "Código: " + valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Apagar!\nErro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public Object buscarId(int valor)
        {
            //retornar um model Cliente
            Animal animal = new Animal();

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();

            cmd = new SqlCommand(sqlBuscarId, con);

            //Passando parâmetros para a sentença SQL
            cmd.Parameters.AddWithValue("@Id", valor);
            cmd.CommandType = CommandType.Text;

            SqlDataReader tabAnimal;
            con.Open();


            try
            {
                tabAnimal = cmd.ExecuteReader();
                if (tabAnimal.Read())
                {
                    animal.CodAnimal = Int32.Parse(tabAnimal[0].ToString());
                    animal.NomeAnimal = tabAnimal[1].ToString();
                    animal.RacaAnimal = tabAnimal[2].ToString();
                    animal.CorAnimal = tabAnimal[3].ToString();
                    animal.PesoAnimal = tabAnimal[4].ToString();
                    animal.NomeProprietario = tabAnimal[5].ToString();

                }
            }
            catch (Exception ex)
            {
                
            }
            finally { con.Close(); }

            return animal;
        }
        public void editarDadosSemImagem(Animal animal)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE ANIMAL SET NOMEANIMAL = @Nome, RACA = @Raca, COR = @Cor, PESO = @Peso, PROPIETARIO = @Proprietario WHERE codanimal = @Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", animal.CodAnimal);
                cmd.Parameters.AddWithValue("@Nome", animal.NomeAnimal);
                cmd.Parameters.AddWithValue("@Raca", animal.RacaAnimal);
                cmd.Parameters.AddWithValue("@Cor", animal.CorAnimal);
                cmd.Parameters.AddWithValue("@Peso", animal.PesoAnimal);
                cmd.Parameters.AddWithValue("@Proprietario", animal.NomeProprietario);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro atualizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID do animal.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar registro!\nErro: " + ex.Message);
                }
            }
        }

        public void editarDados(object obj, byte[] imagemBytes)
        {
            Animal animal = (Animal)obj;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE ANIMAL SET NOMEANIMAL = @Nome, RACA = @Raca, COR = @Cor, PESO = @Peso, PROPIETARIO = @Proprietario, FOTO = @Foto WHERE codanimal = @Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", animal.CodAnimal);
                cmd.Parameters.AddWithValue("@Nome", animal.NomeAnimal);
                cmd.Parameters.AddWithValue("@Raca", animal.RacaAnimal);
                cmd.Parameters.AddWithValue("@Cor", animal.CorAnimal);
                cmd.Parameters.AddWithValue("@Peso", animal.PesoAnimal);
                cmd.Parameters.AddWithValue("@Proprietario", animal.NomeProprietario);
                cmd.Parameters.AddWithValue("@Foto", imagemBytes);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro atualizado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar registro com imagem!\nErro: " + ex.Message);
                }
            }
        }


        public void inserirDados(object obj, byte[] imagemBytes)
        {
            Animal animal = (Animal)obj;

            ConectaBanco cb = new ConectaBanco();
            con = cb.conectaSqlServer();
            cmd = new SqlCommand(sqlInsere, con);

            cmd.Parameters.AddWithValue("@Nome", animal.NomeAnimal);
            cmd.Parameters.AddWithValue("@Raca", animal.RacaAnimal);
            cmd.Parameters.AddWithValue("@Cor", animal.CorAnimal);
            cmd.Parameters.AddWithValue("@Peso", animal.PesoAnimal);
            cmd.Parameters.AddWithValue("@Propietario", animal.NomeProprietario);
            cmd.Parameters.AddWithValue("@Foto", imagemBytes);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro incluído com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirDados(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
