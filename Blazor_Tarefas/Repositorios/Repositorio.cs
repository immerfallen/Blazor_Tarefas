using Blazor_Tarefas.Entidades;
using System.Collections.Generic;
using System;

namespace Blazor_Tarefas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
                {
                new Tarefa{
                    ID = new Guid(),
                    Descricao = "Fazer curso de Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2022-08-11")
                },
                new Tarefa{
                    ID = new Guid(),
                    Descricao = "Estudar Blazor",
                    Concluida = true,
                    DataCriacao = Convert.ToDateTime("2022-04-03")
                }

            };

        }
    }
}
