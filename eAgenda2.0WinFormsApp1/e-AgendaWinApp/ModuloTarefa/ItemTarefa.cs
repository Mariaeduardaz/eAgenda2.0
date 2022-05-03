using System;

namespace eAgenda2._0WinFormsApp1
{
    public class ItemTarefa
    {
        public string Titulo { get; set; }
        public bool Concluido { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
