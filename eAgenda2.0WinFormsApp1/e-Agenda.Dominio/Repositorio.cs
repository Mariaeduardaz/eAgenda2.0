using System;
using System.Collections.Generic;

namespace eAgenda2._0WinFormsApp1
{
    public class Repositorio<T>
    {
        protected readonly List<T> registros;

        public List<T> SelecionarTodos()
        {
            return registros;
        }

    }
}