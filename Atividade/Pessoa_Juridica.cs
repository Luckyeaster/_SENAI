namespace Atividade
{

    public class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}
        public float valor { get; private set; }
        public float valor_imposto { get; private set; }
        public float total { get; private set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}