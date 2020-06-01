namespace Aula_07_Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get; set; }
        protected int cvc { get; set; }
        public string AprovarCompra(){
            return "Compra Aprovada";
        }
        private bool ValidarToken(string tokenValidacao){
            if(tokenValidacao != null && tokenValidacao != ""){
                return true;
            }

            return false;
            
        }
        protected bool ValidarCompra(string compraValidacao){
            return true;
        
        }

    }
}