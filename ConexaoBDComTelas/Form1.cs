using System.Security.Cryptography.X509Certificates;

namespace ConexaoBDComTelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void atualizaInterface()
        {
            listTarefas.Clear();
            Tarefa tarefa= new Tarefa();
            List<Tarefa>tarefas=tarefa.buscaTodos();
            foreach(Tarefa t in tarefas)
            {
                listTarefas.Items.Add($"{t.id} - {t.descricao}");
            }
        }
       //---------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            atualizaInterface();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao=txtTarefa.Text;
            bool concluido=cboxConcluido.Checked;

            Tarefa tarefa= new Tarefa();
            tarefa.descricao = descricao;
            tarefa.concluido= concluido;
            tarefa.Insere(tarefa);

            MessageBox.Show("Tarefa cadastrada com sucesso!");
            atualizaInterface();

            txtTarefa.Clear();
            cboxConcluido.Checked = false;
        }
    }
}