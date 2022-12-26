using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Vector
{
    class vector
    {
        private int _Ui;
        private int _Uj;
        private int _Uk;
        private int _Vi;
        private int _Vj;
        private int _Vk;

        public int Ui
        {
            get { return _Ui; }
            set { _Ui = value; }
        }

        public int Ui
        {
            get { return _Uj; }
            set { _Uj = value; }
        }

        public int Ui
        {
            get { return _Uk; }
            set { _Uk = value; }
        }

        public int Vi
        {
            get { return _Vi; }
            set { _Vi = value; }
        }

        public int Vj
        {
            get { return _Vj; }
            set { _Vj = value; }
        }

        public int Vk
        {
            get { return _Vk; }
            set { _Vk = value; }
        }

        // ADDITION (1,2,3)

        // value i
        public double Value1()
        {
            return _Ui + _Vi;
        }

        // value j
        public double Value2()
        {
            return _Uj + _Vj;
        }

        // value k
        public double Value3()
        {
            return _Uk + _Vk;
        }

        // SUBTRACTION (4,5,6)

        // value i
        public double Value4()
        {
            return _Ui - _Vi;
        }

        // value j
        public double Value5()
        {
            return _Uj - _Vj;
        }

        // value k
        public double Value6()
        {
            return _Uk - _Vk;
        }

        // DOT PRODUCT (7)
        public double Value7()
        {
            return (_Ui * _Vi) + (_Uj * _Vj) + (_Uk * _Vk);
        }

        // CROSS PRODUCT (8,9,10)

        // value i
        public double Value8()
        {
            return (_Uj * _Vk) - (_Vj * _Uk);
        }

        // value j
        public double Value9()
        {
            return ((_Ui * _Vk) - (_Vi * _Uk)) * -1;
        }

        // value k
        public double Value10()
        {
            return (_Ui * _Vj) - (_Vi * _Uj);
        }
    }
}
