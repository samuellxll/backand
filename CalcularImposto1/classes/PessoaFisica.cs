using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        
        public string? cpf{get; set;}

        
        public DateTime dataNasc{get; set;}

                
        public override float CalcularImposto(float rendimento)
        {
            if(rendimento <=1500){

                float resultado = (rendimento / 100) * 2;

                return resultado;

            }else if(rendimento > 1500 && rendimento < 3000){

                float resultado = (rendimento / 100) * 3.5f;

                return resultado;

            }else{

                float resultado = (rendimento/ 100) * 5;

                return resultado;

            }

        }

        public bool ValidarDataNacimento(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}