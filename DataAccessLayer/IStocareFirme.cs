using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareFirme: IStocareFactory
    {
        List<Firma> GetFirme();
        Firma GetFirma(int id);
        bool AddFirma(Firma c);
        bool DeleteFirma(int id);

        bool UpdateFirma(Firma c);
    }
}
