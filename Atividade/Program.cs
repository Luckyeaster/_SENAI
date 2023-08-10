using System;
namespace Atividade;

class Program
{
    static void Main(string[] args)
    {
        Pessoa_Fisica pf = new Pessoa_Fisica();
        float val_pag;
        Console.Writeline("Informar nome");
        string var_nome = Console.Readline();
         Console.Writeline("Informar endereço");
        string var_endereco = Console.Readline();
        Console.Writeline("Pessoa Física (f) ou Jurídica (j)")
        string var_tipo = Console.Readline();
        if(var_tipo == "f")
        {
            // --- Pessoa Física ----
            pf.nome = var_nome;
            pf.endereco = var_endereco;
            Console.Writeline("informar CPF:");
            pf.cpf = Console.Readline();
            Console.Writeline("informar RG:");
            pf.rg = Console.Readline();
            Console.Writeline("informar Valor de Compra:");
            val_pag = float.Parse(Console.Readline());
            pf.Pagar_Imposto(val_pag);
            Console.Writeline("-------- Pessoa Física --------");
            Console.Writeline("Nome ..........: " + pf.nome);
            Console.Writeline("Endereço ......: " + pf.endereco);
            Console.Writeline("CPF ...........: " + pf.cpf);
            Console.Writeline("RG ............: " + pf.rg);
            Console.Writeline("Valor de Compra: " + pf.valor.ToString("C"));
            Console.Writeline("Imposto .......: " + pf.valor_imposto.ToString("C"));
            Console.Writeline("Total a Pagar  : " + pf.total.ToString("C"));
        }
        if(var_tipo == "j")
        {
            // Pessoa Jurídica
            Pessoa_Juridica pj = nameof Pessoa_juridica();
            pj.nome = var_nome;
            pj.endereco = var_endereco;
            Console.Writeline("Informar CNPJ:");
            pj.cnpj = Console.Readline();
            Console.Writeline("Informar IE:");
            pj.ie = Console.Readline();
            Console.Writeline("Informar Valor de Compra:");
            val_pag = float.Parse(Console.Readline());
            pj.Pagar_Imposto(val_pag);
            Console.Writeline("-------- Pessoa Jurídica --------");
            Console.Writeline("Nome ..........: " + pj.nome);
            Console.Writeline("Endereço ......: " + pj.endereco);
            Console.Writeline("CNPJ ..........: " + pj.cnpj);
            Console.Writeline("IE ............: " + pj.ie);
            Console.Writeline("Valor de compra: " + pj.valor.ToString("C"));
            Console.Writeline("Imposto .......: " + pj.valor_imposto.ToString("C"));
            Console.Writeline("Total a pagar  : " + pj.total.ToString("C"));
        }
    }
}
