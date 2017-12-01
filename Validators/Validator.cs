using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validators
{
    public static class Validator
    {
        public static bool NotNull(String value)
        {
            return !String.IsNullOrEmpty(value);
        }

        public static bool HasTwoCarsWithStartWithA(Persona persona)
        {
            return persona.Coches.Count(c => c.StartsWith("a")) == 2;
        }
    }
}
