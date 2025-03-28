﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Prioridade{ get; set; }
        public string DataVencimento { get; set; }
        public string Status { get; set; }

        public Tarefa() { }

        public Tarefa(int id, string nome, string prioridade, string dataVencimento, string status)
        {
            Id = id;
            Nome = nome;
            Prioridade = prioridade;
            DataVencimento = dataVencimento;
            Status = status;
        }
    }
}
