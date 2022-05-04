using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eAgenda2._0WinFormsApp1
{
    public class Contato : EntidadeBase, IEnumerable
    {

       
        private string nome;
        private string email;
        private string telefone;
        

        public List<ItemTarefa> itens = new List<ItemTarefa>();

        public Contato()
        {

        }


        
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        

       

        
        public override string ToString()
        {



            return $"Telefone: {Telefone} Nome: {Nome}, Email: {Email}, Empresa: {Empresa} Cargo: {Cargo}";



        }
        public override string Validar()
        {
            StringBuilder stringbuilder = new();

            if (string.IsNullOrEmpty(Nome))
                stringbuilder.AppendLine("O nome é obrigatório");
            if (string.IsNullOrEmpty(Telefone))
                stringbuilder.AppendLine("O telefone é obrigatório");
            if (string.IsNullOrEmpty(Email))
                stringbuilder.AppendLine("O e-mail é obrigatório");
            


                EmailAddressAttribute email = new();
            if (!email.IsValid(Email))
                stringbuilder.AppendLine("E-mail não válido");

            string telefonePadrao = @"^\([1-9]{2}\) (?:[2-8]|9 [1-9])[0-9]{3}\-[0-9]{4}$";
            if (!Regex.Match(Telefone, telefonePadrao).Success)
                stringbuilder.AppendLine("Telefone não válido (xx) x xxxx-xxxx");

            if (stringbuilder.Length == 0)
                stringbuilder.AppendLine("REGISTRO_VALIDO");

            return stringbuilder.ToString().Trim();


        }

        public string RetornarNome()
        {
            string nome = Nome;
            return nome;
        }


        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
      

        
       

    }
}