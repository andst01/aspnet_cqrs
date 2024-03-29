using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Utils
{
    public class Mensagens
    {
        public static string ValidaDataInicio
        { 
            get { return "A Data Início é obrigatório"; }
        }

        public static string ValidaDataFim
        {
            get { return "A Data Final é obrigatório"; }
        }

        public static string ValidaObrigatorio
        {
            get { return "o {0} é obrigatório"; }
        }

        public static string ValidaUnidadeVenda
        {
            get { return "o Unidade de venda é obrigatório"; }
        }

        public static string ValidaIdAgendamento
        {
            get { return "o {0} é obrigatório"; }
        }

        public static string ValidaIdUserResponsavel
        {
            get { return "o {0} é obrigatório"; }
        }

        public static string ValidaNuloOuVazio
        {
            get { return "o {0} está nulo ou vazio"; }
        }

        public static string ValidaData
        {
            get { return "o {0} está incorreta"; }
        }
    }
}
