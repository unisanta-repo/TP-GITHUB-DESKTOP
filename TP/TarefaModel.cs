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
            return tarefas;
        }
    }
}
