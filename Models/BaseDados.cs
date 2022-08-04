using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotaAlunoMvc.Models
{
    public static class BaseDados
    {
        private static List<Aluno> alunos = new List<Aluno>();
    
      public static void Incluir(Aluno aluno)
       {
           alunos.Add(aluno);
       }
       public static List<Aluno> Listar()
       {
           return alunos;
       }
    }
}