using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace do0.Models
{
    public class do0Client
    {
        //Classe criada para a configuração inicialização do Banco de Dados e ativação do "Migrations"..

        [Key]
        public int do0ClientId { get; set; }
        public string ClientName { get; set; }
    }
}