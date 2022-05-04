using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace eAgenda2._0WinFormsApp1
{
    public class RepositorioTarefa
    {
        private const string ArquivoTarefas  = @"C:\temp\tarefas.bin";
        List<Tarefa> tarefas;
        
        public RepositorioTarefa()
        {
            tarefas = CarregarTarefasDoArquivo();

            

        }

        public List<Tarefa> SelecionarTodos()
        {
           

            return tarefas;




        }

       

        public void Inserir(Tarefa novaTarefa)
        {

            tarefas.Add(novaTarefa);
          //  GravarTarefasEmArquivo();

        }

        /* private void GravarTarefasEmArquivo()
         {
             BinaryFormatter serializador = new BinaryFormatter();
             MemoryStream ms = new MemoryStream();

             serializador.Serialize(ms, tarefas);

             byte[] bytesTarefas = ms.ToArray();

             File.WriteAllBytes(ArquivoTarefas, bytesTarefas);
        }*/

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
            //GravarTarefasEmArquivo();
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
            //GravarTarefasEmArquivo();
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
           foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
            // GravarTarefasEmArquivo();
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
            //GravarTarefasEmArquivo();
        }
        private List<Tarefa> CarregarTarefasDoArquivo()
        {
            if(File.Exists(ArquivoTarefas) == false)
                return new List<Tarefa>();  

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] bytesTarefas = File.ReadAllBytes(ArquivoTarefas);

            MemoryStream ms = new MemoryStream(bytesTarefas);

            return (List<Tarefa>)serializador.Deserialize(ms);
        }
    }   }
