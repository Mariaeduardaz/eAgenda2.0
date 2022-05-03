﻿using System;
using System.Collections.Generic;

namespace eAgenda2._0WinFormsApp1
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();


        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;




        }

        public void Inserir(Tarefa novaTarefa)
        {

            tarefas.Add(novaTarefa);
            
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Prioridad == tarefa.Prioridad)
                {
                    
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
           foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
        }

        public void VisualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }
            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }
        }
    }   }