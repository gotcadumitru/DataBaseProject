using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareLivratori : IStocareFactory
    {
        List<Livrator> GetLivatori(int firmaId);
        Livrator GetLivrator(int id);
        bool AddLivrator(Livrator c);
        bool DeleteLivrator(int id);

        bool UpdateLivrator(Livrator c);
    }
}
