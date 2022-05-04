using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda2._0WinFormsApp1
{
    [Serializable]
    public class Tarefa
    {
        public List<ItemTarefa> itens = new List<ItemTarefa>();
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int p, string t, DateTime i)
        {
            Prioridad = p;
            Titulo = t;
            DataCriacao = i;
            
            DataConclusao = null;
                                                                              
        }

        public int Prioridad { get; set; }
        public string Titulo { get; set; }

       

        public DateTime DataCriacao { get; set; }

        public DateTime? DataConclusao { get; set; }

        public List<ItemTarefa> Itens { get{ return itens; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Numero: {Prioridad} Titulo: {Titulo}, Percentual: {percentual}, Concluida: {DataConclusao.Value.ToShortDateString()}";
            }
                
            return $"Numero: {Prioridad} Titulo: {Titulo}, Percentual: {percentual}"; 
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
            itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();


            var percentual = CalcularPercentualConcluido();
            if(percentual == 100)
            {
                DataConclusao = DateTime.Now;
            }
        }
        public decimal CalcularPercentualConcluido()
        {
           if(itens.Count == 0)
                return 0;
           
             int qtdConcluidas = itens.Count(x => x.Concluido );

             var percentualConcluido =  (qtdConcluidas / (decimal)itens.Count()) * 100;
             
            return Math.Round(percentualConcluido, 2);
            
        }

        public void MarcarPendente(ItemTarefa item)
        {
            
            
                ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

                if (itemTarefa != null)
                    itemTarefa?.MarcarPendente();
            
           
        }
    }
}
