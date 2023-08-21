namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5] { 10, 20, 30, 40, 50 };
        int i = 0;
        // for (i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
        // }
        foreach(int value in array){
            Console.WriteLine("Indice = " + i + " & Valor = " + value);
            i++;
        }

        string[] str = new string[3];
        //int iStr;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        // for (iStr = 0; iStr < 3; iStr++)
        // {
        //     Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
        // }
        foreach (string valor in str)
        {
            int indice = Array.IndexOf(str, valor);
            Console.WriteLine("Indice = " + indice + " & Valor = " + valor);
        }
        

        DateTime[] dt = new DateTime[2];
        //int iDate;
        dt[0] = new DateTime(2002, 5, 1);
        dt[1] = new DateTime(2002, 6, 1);
        // for (iDate = 0; iDate < 2; iDate++)
        // {
        //     Console.WriteLine("Indice = " + iDate + " & Data = " + 
        //     dt[iDate].ToShortDateString());
        // }

        foreach (DateTime date in dt)
        {
            int index = Array.IndexOf(dt, date);
            Console.WriteLine("Indice = " + index + " & Valor = " + date);
        }
        
    }
}
