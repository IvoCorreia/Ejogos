using Ejogos.Models;
using System.Collections.Generic;

namespace Ejogos.Interface
{
    public interface IEquipe
    {

        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update( Equipe e);
        void Delete(int idEquipe);

    }
}
