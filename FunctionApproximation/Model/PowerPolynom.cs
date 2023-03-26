using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApproximation.Model
{
    public class PowerPolynom
    {
        private float[] coefficients;
        public PowerPolynom(float[] _coefficients) {
            if (_coefficients == null)
                throw new ArgumentNullException(nameof(_coefficients));

            coefficients= _coefficients;
        }

        public float Calculate(float x)
        {
            float value = 0;

            for (int i = 0; i < coefficients.Length; i++)
                value += coefficients[i] * (float) Math.Pow(x, i);

            return value;
        }
    }
}
