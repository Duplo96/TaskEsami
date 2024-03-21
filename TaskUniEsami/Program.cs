using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TaskUniEsami.Models;

namespace TaskUniEsami
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using (var ctx = new TaskEsamiContext())

            {



                Studente stu = ctx.Studentes.Include(s => s.EsameRifs).Single(s => s.StudenteId == 1);
                if (stu != null)
                {
                    Console.WriteLine($"Elenco degli esami per lo studente {stu.Nominativo}:");
                    foreach (var esame in stu.EsameRifs)
                    {
                        Console.WriteLine(esame.Titolo);
                    }
                }
                else
                {
                    Console.WriteLine("Lo studente non è stato trovato.");
                }


                Esame? esa = ctx.Esames.Include(esa => esa.StudenteRifs).FirstOrDefault(esa => esa.Titolo.Trim().ToLower() == "Basi di dati");
                if (esa != null)
                {

                    Console.WriteLine($"Elenco degli studenti iscritti all'esame {esa.Titolo}:");
                    {

                        foreach (var student in esa.StudenteRifs)
                        {
                            if (student != null)

                                Console.WriteLine(student.Nominativo);


                            else Console.WriteLine($"Nessuno studente è iscritto all'esame");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Non esistono esami con quel nome");
                }
            }
        }
    }
}
    

