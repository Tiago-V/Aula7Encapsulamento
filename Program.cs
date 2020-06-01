using System;

namespace Aula_07_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();

            Mastercard master = new Mastercard();
            master.parcelas = 6;
            master.ComprarComDescontoMastercard(45f);

        }
    }
}
