using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP
{
    public partial class Form1 : Form
    {

        TarefaModel model = new TarefaModel();

        Boolean editando = false;
        Tarefa tarefaEditando = null;

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
                id++;

                model.AdicionarTarefa(tarefa);

            }
            else
            {
                if(tarefaEditando != null)
                {
                    tarefaEditando.Nome = NometextBox.Text;
                    tarefaEditando.Prioridade= ComplexidadecomboBox.Text;
                    tarefaEditando.DataVencimento= dateTimePicker1.Text;
                    tarefaEditando.Status = StatuscomboBox.Text;
                }
                tarefaEditando = null;
                editando = false;
            }
            this.RefreshDGV();
            this.limparTexto();
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

        //private Tarefa resgatarTarefa(String nome) 
        //{
        //    List<Tarefa> tarefas = model.getTarefas();
        //    String nomeResgatado = NometextBox.Text;
        //    Tarefa tarefa1 = new Tarefa();

        //    foreach (Tarefa tarefa in tarefas)
        //    {
        //        if (tarefa.Nome == nomeResgatado)
        //        {
        //            editando = true;
        //            tarefa.TarefaDeletada = true;

        //            NometextBox.Text = tarefa.Nome;
        //            ComplexidadecomboBox.Text = tarefa.Prioridade;
        //            dateTimePicker1.Text = tarefa.DataVencimento;
        //            StatuscomboBox.Text = tarefa.Status;

        //            tarefa1.Id = id;
        //            tarefa1.Nome = NometextBox.Text;
        //            tarefa1.Prioridade = ComplexidadecomboBox.Text;
        //            tarefa1.DataVencimento = dateTimePicker1.Text;
        //            tarefa1.Status = StatuscomboBox.Text;
        //            tarefa1.TarefaDeletada = false;

        //            return tarefa1;

        //        }
        //    }
        //    return tarefa1;
        //}

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            tarefaEditando = model.getTarefas().Find(t => t.Nome == NometextBox.Text);

            if (tarefaEditando != null)
            {
                editando = true;
                NometextBox.Text = tarefaEditando.Nome;
                ComplexidadecomboBox.Text = tarefaEditando.Prioridade;
                dateTimePicker1.Text = tarefaEditando.DataVencimento;
                StatuscomboBox.Text = tarefaEditando.Status;
            } else
            {
                MessageBox.Show("Erro");
            }
        }

        private void graficobutton_Click(object sender, EventArgs e)
        {
            ArrayList nomes = new ArrayList();
            ArrayList dificuldade = new ArrayList();

            chart1.Series.Clear();
            chart1.Titles.Add("Grafico de Tarefas");
            chart1.ChartAreas[0].AxisX.Title = "Dificuldade";
            chart1.ChartAreas[0].AxisY.Title = "Quantidade";
            Series serieAlta = new Series("Alto")
            {
                ChartType = SeriesChartType.Bar,
                BorderWidth = 2
            };
            Series serieMedia = new Series("Médio")
            {
                ChartType = SeriesChartType.Bar,
                BorderWidth = 2
            };
            Series serieBaixa = new Series("Baixo")
            {
                ChartType = SeriesChartType.Bar,
                BorderWidth = 2
            };

            int alta = 0;
            int media = 0;
            int baixa = 0;

            for (int i = 0; i < model.getTarefas().Count; i++)
            {
                if (model.getTarefas()[i].Prioridade == "Alta") 
                {
                    alta++;
                }
                else if(model.getTarefas()[i].Prioridade == "Media")
                {
                    media++;
                } else
                {
                    baixa++;
                }
            }
            serieAlta.Points.AddXY("Alta", alta);
            serieMedia.Points.AddXY("Média", media);
            serieBaixa.Points.AddXY("Baixa", baixa);

            chart1.Series.Add(serieAlta);
            chart1.Series.Add(serieMedia);
            chart1.Series.Add(serieBaixa);

        }
    }
}
