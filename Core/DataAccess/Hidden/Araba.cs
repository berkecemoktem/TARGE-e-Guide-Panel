using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Hidden
{
    public class Kamyon : IArac
    {
        public void Dur()
        {
            Console.WriteLine("Kamyon durduruldu");
        }

        public void Sur()
        {
            Console.WriteLine("Kamyon sürüldü");
        }
    }

    public class Otomobil : IArac
    {
        public void Dur()
        {
            Console.WriteLine("Araba durduruldu");
        }

        public void Sur()
        {
            Console.WriteLine("Araba sürüldü");
        }
    }

    public interface IArac
    {
        public void Sur();
        public void Dur();
    }
}
