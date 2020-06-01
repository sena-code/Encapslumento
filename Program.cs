using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard master = new MasterCard();
            master.titular = "Vinicius";
            master.ComprarComDescontoMastercard(46f);
            master.parcelas = 6;
        }
    }
}
