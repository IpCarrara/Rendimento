
namespace Rendimento;

public class Programa
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("DIGITE O QUANTO QUER INVESTIR:");
        double dinheiro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("DIGITE O VALOR ATUAL DO CDI:");
        double cdi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("DIGITE A PORCENTAGEM DO CDI OFERECIDA PELO LCI:");
        double lciEntrada = Convert.ToDouble(Console.ReadLine());

        // Poupanca

        double taxaRendimentoPoupanca = 6.17;
        double somaPoupanca = (dinheiro / 100) * taxaRendimentoPoupanca;
        double mesPoupanca = somaPoupanca / 12;

        // Iti

        double somaCdb = (dinheiro / 100) * cdi;
        double mesCdb = somaCdb / 12;
        

        // Imposto

        int taxaImposto = 20;
        double impostoAno = somaCdb / 100 * taxaImposto;
        double impostoMes = impostoAno / 12;

        // LCI

        double lci = (cdi / 100) * lciEntrada;
        double somaLci = (dinheiro / 100) * lci;
        double mesLci = somaLci / 12;

        // Prejuizo
        double prejuizoAno = somaCdb - somaPoupanca - impostoAno;
        double prejuizoMes = mesCdb - mesPoupanca - impostoMes;
        double cdbRendimentoIrfAno = somaCdb - impostoAno;
        double cdbRendimentoIrfMes = mesCdb - impostoMes;
        double prjuizoAnoCdb = somaLci - cdbRendimentoIrfAno;
        double prjuizoAnoLci = cdbRendimentoIrfAno - somaLci;

        Console.WriteLine();
        Console.WriteLine(" Poupança Antiga (2012)");
        Console.WriteLine(" ======================");
        Console.WriteLine(" Lucro Mês: R" + string.Format("{0:c}", mesPoupanca));
        Console.WriteLine(" Lucro Ano: R" + string.Format("{0:c}", somaPoupanca));
        Console.WriteLine();
        Console.WriteLine(" CDB 100% do CDI  **Impostos já descontados**");
        Console.WriteLine(" ===============");
        Console.WriteLine(" Lucro Mês: R" + string.Format("{0:c}", cdbRendimentoIrfMes));
        Console.WriteLine(" Lucro Ano: R" + string.Format("{0:c}", cdbRendimentoIrfAno));
        Console.WriteLine();
        Console.WriteLine(" LCI " + lciEntrada + "% do CDI");
        Console.WriteLine(" ===============");
        Console.WriteLine(" Lucro Mês: R" + string.Format("{0:c}", mesLci));
        Console.WriteLine(" Lucro Ano: R" + string.Format("{0:c}", somaLci));
        Console.WriteLine();
        
        

        if (somaLci > cdbRendimentoIrfAno && somaLci > somaPoupanca ) {
            Console.WriteLine(" Prejuízo ANO ao investir na Poupança: R" + string.Format("{0:c}", prejuizoAno));
            Console.WriteLine(" Prejuízo ANO ao investir no CDB: R" + string.Format("{0:c}", prjuizoAnoCdb));
            Console.WriteLine();
            Console.WriteLine("  #######################");
            Console.WriteLine("  # Melhor Investimento #");
            Console.WriteLine("  #         LCI         #");
            Console.WriteLine("  #######################");
        }else if (cdbRendimentoIrfAno > somaLci && cdbRendimentoIrfAno > somaPoupanca ) {
            Console.WriteLine(" Prejuízo ANO ao investir na Poupança: R" + string.Format("{0:c}", prejuizoAno));
            Console.WriteLine(" Prejuízo ANO ao investir no LCI: R" + string.Format("{0:c}", prjuizoAnoLci));
            Console.WriteLine();
            Console.WriteLine("  #######################");
            Console.WriteLine("  # Melhor Investimento #");
            Console.WriteLine("  #         CDB         #");
            Console.WriteLine("  #######################");
        }else {
            Console.WriteLine("  ########################");
            Console.WriteLine("  # Melhor Investimento  #");
            Console.WriteLine("  # Poupança Antiga 2012 #");
            Console.WriteLine("  ########################");
        }

        Console.ReadLine();    

    }
}
    

    






