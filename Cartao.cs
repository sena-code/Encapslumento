namespace Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        private string token = "Meu Token";
        protected int cvc { get; set; } 

        /// <summary>
        /// Aprovar a ação de compra do usuário
        /// </summary>
        /// <returns>Aprovar compra</returns>

        public string AprovarCompra(){
            return "Compra Aprovada";
        }

        /// <summary>
        /// Validação do Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Validar Token</returns>

        private bool ValidarToken(){

            if(token != null && token != ""){
                return true;
            }

            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}