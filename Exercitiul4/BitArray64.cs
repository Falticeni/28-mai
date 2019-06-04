using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul4
{
    public class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; private set; } // u= usigned = strict pozitiv
        private uint[] number = new uint[64];
        uint z = 63;
        public int Length { get; } = 64;

        public BitArray64(ulong number)
        {
            // transformam din baza 10 in baza 2
            Number = number;
            b10ToB2(number, ref this.number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (uint bitValue in number)
            {
                yield return (int)bitValue;      // yeld-ul nu permite iesirea din functie (datorita return) pana nu se executa blocul de cod
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();// intoarce rezultatul de mai sus. Metoda obligatorie in IEnumerable
        }

        public uint this[int index] // oveerride la []
        {
            get { return number[index]; }
            set
            {
                if (index < 0 || index >= 64)
                    throw new IndexOutOfRangeException("Index must be from 0 to 63");

                if (value < 0 || value > 1)
                    throw new InvalidOperationException("Bit values can have only 0 and 1");

                number[index] = value;
                b2ToB10();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int bitvalue in number)
                sb.Append(bitvalue);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (Number == (obj as BitArray64).Number && GetHashCode() == (obj as BitArray64).GetHashCode())
            {
                for (int i = 0; i < number.Length; i++)
                    if (this[i] != (obj as BitArray64)[i])
                        return false;

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 0;

            for (int i = 0; i < 64; i++)
            {
                hash += (int)((this[i]) * i);
            }

            return hash;
        }

        public static bool operator == (BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator != (BitArray64 a, BitArray64 b)
        {
            return !a.Equals(b);
        }

        private void b2ToB10()
        {
            int i = number.Length - 1, px = 1;
            Number = 0;

            while (i >= 0)
            {
                Number = Number + (ulong)number[i] * (ulong)px;
                px *= 2;
                i--;
            }
        }

        private void b10ToB2(ulong x, ref uint[] number)
        {
            for (int i = 0; i < number.Length; i++)
                number[i] = 0;

            while (x > 0)
            {
                this.number[z--] = (uint)(x % 2);
                x /= 2;
            }
        }
    }
}
