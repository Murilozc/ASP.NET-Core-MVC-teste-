using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaAlunoMvc.Models
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Disciplina {get; set;}
        public double Nota {get; set;}
    
    public bool EstaAprovado()
    {
        return Nota >= 6;
    }
    }
}