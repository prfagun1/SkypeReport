using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RelatoriosSkype.Models{
    public class Conversa  {

        [Key]
        public int id { get; set; }
        public String Date { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public String Message { get; set; }
    }
}