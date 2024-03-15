using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoExceções.Entities.Exceptions
{
    internal class DomainExceptions(string massage) : ApplicationException(massage)
    {
    }
}
