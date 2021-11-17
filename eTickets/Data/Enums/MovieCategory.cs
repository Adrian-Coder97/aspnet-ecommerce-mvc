using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public enum MovieCategory
    {
        Action = 1, //the 1 just defines the start index for the categories so comedy is 2, drama is 3, documentary is 4
        Comedy,
        Drama,
        Documentary,
        Cartoon,
        Horror
    }
}
