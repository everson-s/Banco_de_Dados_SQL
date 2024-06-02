using Microsoft.Data.Sqlite;
using System.Text;

namespace Banco_Dados
{
    public partial class Form1 : Form
    {
        string caminhoBD = Path.Combine(Application.LocalUserAppDataPath, "data.db");

        public Form1()
        {
            InitializeComponent();
        }

        private void CriarBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open ();

                StringBuilder sb = new StringBuilder();
                sb.Append("CREATE TABLE IF NOT EXISTS Cliente (");
                sb.Append("IdCliente INTEGER PRIMARY KEY, ");
                sb.Append("Nome VARCHAR(50) NOT NULL, ");
                sb.Append("LimiteCredito DECIMAL (18,2), ");
                sb.Append("DataNascimento DATE, ");
                sb.Append("DataHoraUltimaCompra DATETIME, ");
                sb.Append("Bloqueado BOOLEAN);");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();
            }
        }




        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarBancoDeDados(caminhoBD);
        }
    }
}
