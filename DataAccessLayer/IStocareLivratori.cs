using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareLivratori : IStocareFactory
    {
        List<Employee> GetLivatori(int firmaId);
        Employee GetLivrator(int id);
        bool AddLivrator(Employee c);

        bool UpdateLivrator(Employee c);
    }
}
