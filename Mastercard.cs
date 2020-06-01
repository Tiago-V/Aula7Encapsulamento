using System;

namespace Aula_07_Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto){

            // Protected
            cvc = 456;

            Console.WriteLine($"Aplicado desconto de {desconto}%, no total de {parcelas} parcelas");

        }
    }
}