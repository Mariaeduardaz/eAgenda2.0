using System;
using System.Collections.Generic;

namespace eAgenda2._0WinFormsApp1
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromisso = new List<Compromisso>();

        public List<Compromisso> SelecionarTodos()
        {
            return compromisso; 




        }
        public void Inserir(Compromisso novoCompromisso)
        {

            compromisso.Add(novoCompromisso);

        }

        public void Editar(Compromisso compromissos)
        {
            foreach (var item in compromisso)
            {
            }
        }
        public void Excluir(Compromisso compromissos)
        {
            compromisso.Remove(compromissos);
        }

       

       
        public List<Compromisso> FiltrarCompromissos(Predicate<Compromisso> condicao)
        {
            List<Compromisso> registrosFiltrados = new List<Compromisso>();

            foreach (Compromisso registro in compromisso)
                if (condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

        internal string Inserir(object compromisso)
        {
            throw new NotImplementedException();
        }
        public bool RegistroExistente()
        {
            int quantidade = compromisso.Count;
            if(quantidade == 0)
                return false;
            else
                return true;
        }
    }
}
