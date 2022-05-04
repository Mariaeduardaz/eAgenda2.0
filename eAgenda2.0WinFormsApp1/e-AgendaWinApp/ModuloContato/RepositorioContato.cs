using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0WinFormsApp1
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();

        public List<Contato> SelecionarTodos()
        {
            return contatos;




        }
        public string Inserir(Contato novoContato)
        {
            string resultado = novoContato.Validar();
            if(resultado.Trim() != "REGISTRO VALIDO")
            {
                return resultado;
            }
            contatos.Add(novoContato);
            return "REGISTRO VALIDO";
            

        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
            }
        }
        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }

        internal void Inserir(object contato)
        {
            throw new NotImplementedException();
        }
       
    }
}
