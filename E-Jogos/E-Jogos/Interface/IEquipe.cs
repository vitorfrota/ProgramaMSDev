using E_Jogos.Models;
using System.Collections.Generic;

namespace E_Jogos.Interface
{

    // responsável por determinar quais métodos uma classe terá (contrato da classe).
    public interface IEquipe
    {
        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();
        void Update(Equipe equipe);
        void Delete(int id);
    }
}
