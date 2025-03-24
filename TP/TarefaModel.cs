using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class TarefaModel
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        public void FinalizarTarefa(Tarefa tarefa)
        {
            tarefa.Status = "Concluída";
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public List<Tarefa> getTarefas()
        {
            List<Tarefa> tarefasRetornadas = new List<Tarefa>();
            foreach (Tarefa tarefa in tarefas) 
            {
                if (tarefa.TarefaDeletada != true) 
                { 
                    tarefasRetornadas.Add(tarefa);
                }
            }
            return tarefasRetornadas;
        }
    }
}
