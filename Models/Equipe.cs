using Ejogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace Ejogos.Models
{
    public class Equipe : EjogosBase, IEquipe
    {
        int IdEquipe { get; set; }
        string Nome { get; set; }
        string Imagem { get; set; }
        private const string path = "Database/Equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }


        public string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";

        }
        public List<Equipe> ReadAll()
        {


            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);
            foreach (string line in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(line.Split(';')[0]);
                equipe.Nome = line.Split(';')[1];
                equipe.Imagem = line.Split(';')[2];
                equipes.Add(equipe);


            }
            return equipes;

        }


        void IEquipe.Create(Equipe e)
        {
            string[] linha = { Prepare(e) };
            File.AppendAllLines(path, linha);
        }
        void IEquipe.Update(Equipe e)
        {
            throw new System.NotImplementedException();
        }

        void IEquipe.Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
