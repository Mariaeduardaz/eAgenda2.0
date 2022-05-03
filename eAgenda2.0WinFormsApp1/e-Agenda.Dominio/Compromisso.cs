using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0WinFormsApp1
{
    public class Compromisso : EntidadeBase
    {
        
        public Contato contato = new();
        public string Assunto { get; set; }
        public string Local { get; set; }
        public Contato Contato { get { return contato; } set { contato = value; } }
        public DateTime? DataCompromisso { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
       

        public override string ToString()
        {
            if (Contato != null)
            {
                return $"ID: {id} Assunto: {Assunto}  Data: {DataCompromisso} Local: {Local} Hora início: {HoraInicio} Hora fim: {HoraFim} Contato: {Contato}";
            }
            return $"ID: {id} Assunto: {Assunto} Data: {DataCompromisso} Local: {Local}  Hora início: {HoraInicio} Hora fim: {HoraFim}";
        }
        public override string Validar()
        {
            StringBuilder stringbuilder = new();

            if (string.IsNullOrEmpty(Assunto))
                stringbuilder.AppendLine("assunto é obrigatório!");
            if (!DataCompromisso.HasValue)
                stringbuilder.AppendLine("A data é obrigatória!");
            if (string.IsNullOrEmpty(Local))
                stringbuilder.AppendLine("O local do seu compromisso é obrigatório!");
            if (HoraInicio > HoraFim)
                stringbuilder.AppendLine("A data inicial do seu compromisso não pode ser menor que a final");
            if (DataCompromisso < DateTime.Now)
                stringbuilder.AppendLine("A data do seu compromisso não pode ser os dias que ja aconteceram!!");
            if (stringbuilder.Length == 0)
                stringbuilder.AppendLine("REGISTRO_VALIDO");

            return stringbuilder.ToString();
        }

    }
}
