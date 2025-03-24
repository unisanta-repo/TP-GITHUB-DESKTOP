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

            Tarefa tarefa = new Tarefa();
            tarefa.Id = id;
            tarefa.Nome = NometextBox.Text;
            tarefa.Prioridade = ComplexidadecomboBox.Text;
            tarefa.DataVencimento = dateTimePicker1.Text;
            tarefa.Status = StatuscomboBox.Text;
            id++;

            model.AdicionarTarefa(tarefa);
            this.RefreshDGV();
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
    }
}
