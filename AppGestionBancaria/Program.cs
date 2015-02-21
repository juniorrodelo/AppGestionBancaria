using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// @ALFREDO RODELO CORONADO T00036721 
// @KEVIN VEGA T000xxxx

namespace AppGestionBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#region "Cuentas bancarias Corrientes"
            Corrientes c = new Corrientes(898889, 9875776266622, 7500.00, 10000.00, 0.02F, 0.04F, 'B');
            Console.WriteLine(c);
            Console.WriteLine("================== TRANSACCIONES (corrientes) ====================" );
            Console.WriteLine("$" + Math.Round(c.retirar(1200)));
            Console.WriteLine("$" + Math.Round(c.retirar(2500)));
            Console.WriteLine("================== CONSULTA DEL BALANCE (corrientes) =======================");
            Console.WriteLine("$" + Math.Round(c.balance_actual()));
            Console.WriteLine("================== DEPOSITAR (corrientes) =======================");
            Console.WriteLine("$"+  Math.Round(c.depositar(5000)));
            #endregion*/

            /*#region "Cuentas bancarias de Ahorros"
            Ahorros a = new Ahorros(898889, 9875776266622, 7500.00, 0.02F);
            Console.WriteLine(a);
            Console.WriteLine("============================= TRANSACCIONES (ahorros) ========================" );
            Console.WriteLine("$" + Math.Round(a.retirar(1200)));
            Console.WriteLine("================== CONSULTA DEL BALANCE (ahorros) =======================");
            Console.WriteLine("$" + Math.Round(a.balance_actual()));
            Console.WriteLine("================== DEPOSITAR (ahorros) =======================");
            Console.WriteLine("$" + Math.Round(a.depositar(3000)));
            #endregion*/

            #region "Cuentas bancarias de Cheques"
            #endregion
            Console.ReadLine();
        }
    }
}
