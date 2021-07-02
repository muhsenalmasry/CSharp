using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus
{
    interface IAlennus
    {
        void LisääAlennus(float prosenttia);
        void MuutaAlennus(float alkuperäinen, float uusiAlennus);
    }
}
