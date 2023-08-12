namespace Atividade{


class Program
{
    static void Main(string[] args)
    {
        Pessoa_Fisica pf = new Pessoa_Fisica();
        float val_pag;
        Console.WriteLine("Informar Nome");
        string var_Nome = Console.ReadLine();
         Console.WriteLine("Informar endereço");
        string var_endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
        string var_tipo = Console.ReadLine();
        if(var_tipo == "f")
        {
            // --- Pessoa Física ----
            pf.Nome = var_Nome;
            pf.Endereco = var_endereco;
            Console.WriteLine("informar CPF:");
            pf.Cpf = Console.ReadLine();
            Console.WriteLine("informar RG:");
            pf.Rg = Console.ReadLine();
            Console.WriteLine("informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Física --------");
            Console.WriteLine("Nome ..........: " + pf.Nome);
            Console.WriteLine("Endereço ......: " + pf.Endereco);
            Console.WriteLine("CPF ...........: " + pf.Cpf);
            Console.WriteLine("RG ............: " + pf.Rg);
            Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pf.Valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar  : " + pf.Total.ToString("C"));
        }
        if(var_tipo == "j")
        {
            // Pessoa Jurídica
            Pessoa_Juridica pj = new Pessoa_juridica();
            pj.Nome = var_Nome;
            pj.Endereco = var_endereco;
            Console.WriteLine("Informar CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Jurídica --------");
            Console.WriteLine("Nome ..........: " + pj.Nome);
            Console.WriteLine("Endereço ......: " + pj.Endereco);
            Console.WriteLine("CNPJ ..........: " + pj.cnpj);
            Console.WriteLine("IE ............: " + pj.ie);
            Console.WriteLine("Valor de compra: " + pj.Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pj.Valor_imposto.ToString("C"));
            Console.WriteLine("Total a pagar  : " + pj.Total.ToString("C"));
        }
    }
}

    internal class Pessoa_juridica : Pessoa_Juridica
    {
    }
}

