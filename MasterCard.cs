using System;

namespace Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMastercard(float desconto){
            //Protect
            cvc = 468;
            //Void não precisa de um return 
            Console.WriteLine($"Aplicado desconto de {desconto}, no total de {parcelas} parcelas ");
        }
    }
}