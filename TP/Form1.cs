using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {

        TarefaModel model = new TarefaModel();

        Boolean editando = false;

        int id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void NometextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComplexidadecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            if (!editando)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Id = id;
                tarefa.Nome = NometextBox.Text;
                tarefa.Prioridade = ComplexidadecomboBox.Text;
                tarefa.DataVencimento = dateTimePicker1.Text;
                tarefa.Status = StatuscomboBox.Text;
                tarefa.TarefaDeletada = false;
                id++;

                model.AdicionarTarefa(tarefa);
                this.RefreshDGV();
                this.limparTexto();
            }
            else
            {
                Tarefa tarefaEditada = resgatarTarefa(NometextBox.Text);
                model.AdicionarTarefa(tarefaEditada);
                this.RefreshDGV();
                editando = false;
            }
        }

        public void limparTexto()
        {
            NometextBox.Text = "";
            ComplexidadecomboBox.Text = "";
            dateTimePicker1.Text = "";
            StatuscomboBox.Text = "";
        }

        public void RefreshDGV()
        {
            List<Tarefa> tarefas = model.getTarefas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tarefas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Tarefa resgatarTarefa(String nome) 
        {
            List<Tarefa> tarefas = model.getTarefas();
            String nomeResgatado = NometextBox.Text;
            Tarefa tarefa1 = new Tarefa();

            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.Nome == nomeResgatado)
                {
                    editando = true;
                    tarefa.TarefaDeletada = true;

                    NometextBox.Text = tarefa.Nome;
                    ComplexidadecomboBox.Text = tarefa.Prioridade;
                    dateTimePicker1.Text = tarefa.DataVencimento;
                    StatuscomboBox.Text = tarefa.Status;

                    tarefa1.Id = id;
                    tarefa1.Nome = NometextBox.Text;
                    tarefa1.Prioridade = ComplexidadecomboBox.Text;
                    tarefa1.DataVencimento = dateTimePicker1.Text;
                    tarefa1.Status = StatuscomboBox.Text;
                    tarefa1.TarefaDeletada = false;

                    return tarefa1;

                }
            }
            return tarefa1;
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            bool editando = true;
            Tarefa tarefa = resgatarTarefa(NometextBox.Text);

        }
    }
}
