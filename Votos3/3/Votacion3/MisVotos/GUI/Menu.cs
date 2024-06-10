using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.GUI
{
    public class Menu
    {
        public void MenuPrincipal()
        {
           VotanteGUI votanteGUI = new VotanteGUI();

            int op;
            do
            {
                Console.Clear();//
                Console.SetCursorPosition(20, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Gestionar votantes");
                Console.SetCursorPosition(18, 11); Console.Write("2. Gestionar lugar de votacion");
                Console.SetCursorPosition(18, 13); Console.Write("3. salir");
                Console.SetCursorPosition(60, 11); Console.Write("Digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        votanteGUI.MenVot();
                        break;
                    case 2:
                        votanteGUI.MenLugVot();
                        break;
                    default:
                        Console.SetCursorPosition(50, 15); Console.Write("Opción no válida");
                        break;
                }


            } while (op != 3);
        }
    }
}
