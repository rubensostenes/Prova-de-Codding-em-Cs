using System;

namespace PROVA___CODING___C_
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaPadrao Basica = new SalaPadrao(15, "Perto do Bobs", 5);
            SalaChique Chique = new SalaChique();
            SalaClasseMedia Media = new SalaClasseMedia();
            SalaClasseRica Rica = new SalaClasseRica();
        }
    }
}
