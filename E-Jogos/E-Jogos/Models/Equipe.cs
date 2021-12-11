using E_Jogos.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{
    public class Equipe : EjogosBase, IEquipe
    {

        private const string path = "Database/esquipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        private void CreateFolderAndFile(string path)
        {
            throw new NotImplementedException();
        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        public void Create(Equipe nova_equipe)
        {
            string[] row = { $"{nova_equipe.IdEquipe};{nova_equipe.Nome};{nova_equipe.Imagem}" };

            File.AppendAllLines(path, row);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] rows = File.ReadAllLines(path);

            foreach(string row in rows)
            {
                Equipe equipe = new Equipe();

                equipe.IdEquipe = int.Parse(row.Split(';')[0]);
                equipe.Nome = row.Split(';')[1];
                equipe.Imagem = row.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
