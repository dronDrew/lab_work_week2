using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_week2
{
    class complex_number
    {
        public int real_part { get; set; }
        public int imegion_part { get; set; }
        public complex_number() {
            real_part = 0;
            imegion_part = 0;
        }
        public complex_number(int real, int imag) {
            this.real_part = real;
            this.imegion_part = imag;
        }
        static public complex_number operator -(complex_number a,complex_number b) {
            return new complex_number(a.real_part - b.real_part, a.imegion_part - b.imegion_part);
        
        }
        static public complex_number operator +(complex_number a, complex_number b)
        {
            return new complex_number(a.real_part + b.real_part, a.imegion_part + b.imegion_part);

        }
        static public complex_number operator *(complex_number a, complex_number b)
        {
            return new complex_number((a.real_part * b.real_part) - (a.imegion_part * b.imegion_part),(a.real_part*b.imegion_part)+(a.imegion_part*b.real_part));

        }
        static public complex_number operator /(complex_number a, complex_number b)
        {
            return new complex_number(((a.real_part*b.real_part)+(a.imegion_part*b.imegion_part))/Convert.ToInt32(Math.Pow(b.real_part,2)+Math.Pow(b.imegion_part,2)),((b.real_part*a.imegion_part)-(b.imegion_part*a.real_part))/ Convert.ToInt32(Math.Pow(b.real_part, 2) + Math.Pow(b.imegion_part, 2)));

        }
        public override string ToString()
        {
            if (this.imegion_part < 0)
            {
                return $"{real_part} {imegion_part}i";
            }
            else {
                return this.real_part + "+" + this.imegion_part + "i";

            }
            
        }

    }
}
