using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class MiVector
    {
        private int[] _vec;

        /// <summary>
        /// cuando se crea la clase se crea tambien un vector del tamaño especificado
        /// </summary>
        /// <param name="tam"></param>
        public MiVector(int tam)
        {
            _vec = new int[tam];
        }
        public void  LlenarVector( int valorinicial )
        {

            for (int i = 0; i < _vec.Length; i++)
            {
                _vec[i] = valorinicial;
                valorinicial++;
            }
            
        }
        public string Mostrar()
        {
            string c = " ";
            for (int i=0;i<_vec.Length;i++)
            {
                c += "[" + i + "]" + _vec[i]+Environment.NewLine;
                
            }
            return c;
        }
        /// <summary>
        /// Girar una posicion hacia arriba el vector
        /// </summary>
        public void GirarArriba()
        {
            int t = _vec[_vec.Length-1];
            for(int i = _vec.Length - 1; i >= 1; i--)
            {
                _vec[i] = _vec[i-1];
            }
            _vec[0] = t;
        }
        public void Invertir()
        {
            int t, medio;
            medio = _vec.Length / 2;
            for(int i = 0; i < medio; i++)
            {
                t = _vec[i];
                _vec[i] = _vec[_vec.Length - 1 - i];
                _vec[_vec.Length - 1 - i] = t;
            }

        }

        
            
    }
}
