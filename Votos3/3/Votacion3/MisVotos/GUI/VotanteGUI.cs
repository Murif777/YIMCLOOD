using MisVotos.BLL;
using MisVotos.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisVotos.GUI
{
    public class VotanteGUI
    {
        private ServicioVotante servicioVotante = new ServicioVotante();
        private ServicioLugVot servicioLugVot = new ServicioLugVot();
        bool find = false;
        public void MenVot()
        {

            int op;
            do
            {
                Console.Clear();//
                Console.SetCursorPosition(40, 7); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar Votante");
                Console.SetCursorPosition(18, 11); Console.Write("2. Modificar un votante");
                Console.SetCursorPosition(18, 13); Console.Write("3. Eliminar un votante");
                Console.SetCursorPosition(18, 15); Console.Write("4. Consulta General");
                Console.SetCursorPosition(18, 17); Console.Write("5. Listado de Mujeres ");
                Console.SetCursorPosition(18, 19); Console.Write("6. salir");
                Console.SetCursorPosition(50, 14); Console.Write("Digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ViewAdd();
                        break;
                    case 2:
                        ViewUpdate();
                        break;
                    case 3:
                        ViewDel();
                        break;
                    case 4:
                        GetAll();
                        break;
                    case 5:
                        GetWoman();
                        Console.Clear();
                        break;
                    default:
                        Console.SetCursorPosition(50, 20); Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (op != 6);
        }
        public void MenLugVot()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(40, 7); Console.Write("GESTION LUGAR DE VOTACION");
                Console.SetCursorPosition(18, 9); Console.Write("1. Agregar lugar de votacion");
                Console.SetCursorPosition(18, 11); Console.Write("2. Modificar lugar de votacion");
                Console.SetCursorPosition(18, 13); Console.Write("3. Eliminar lugar de votacion");
                Console.SetCursorPosition(18, 15); Console.Write("4. Consulta lugar de votacion");
                Console.SetCursorPosition(18, 17); Console.Write("5. salir");
                Console.SetCursorPosition(55, 14); Console.Write("Digite opcion :");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ViewLugarVotAdd();
                        break;
                    case 2:
                        ViewLugarVotUpdate();
                        break;
                    case 3:
                        ViewLugarVotDel();
                        break;
                    case 4:
                        GetAllLugarVot();
                        break;
                    default:
                        Console.SetCursorPosition(50, 20); Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (op != 5);
        }
        public void ViewAdd()
        {
            Console.Clear();
            Votante votante = new Votante();
            Console.SetCursorPosition(5, 4); Console.Write("AGREGAR UN VOTANTE");
            Console.SetCursorPosition(5, 7); Console.Write("Cedula: ");
            Console.SetCursorPosition(5, 9); Console.Write("Nombres: ");
            Console.SetCursorPosition(5, 11); Console.Write("Telefono: ");
            Console.SetCursorPosition(5, 13); Console.Write("Sexo: ");
            Console.SetCursorPosition(5, 15); Console.Write("Edad: ");
            Console.SetCursorPosition(20, 7); votante.Cedula = Console.ReadLine();
            Console.SetCursorPosition(20, 9); votante.Nombre = Console.ReadLine();
            Console.SetCursorPosition(20, 11); votante.Telefono = Console.ReadLine();
            Console.SetCursorPosition(20, 13); votante.Sexo = Console.ReadLine();
            Console.SetCursorPosition(20, 15); votante.Edad = Convert.ToInt16(Console.ReadLine());
            Console.SetCursorPosition(40, 12); Console.Write("¿Seguro que desea guardar? S/N");
            Console.SetCursorPosition(40, 13); string save = Console.ReadLine(); save = save.ToUpper();
            if (save.Equals("S"))
            {
                var mensaje = servicioVotante.Add(votante);
                Console.WriteLine(mensaje);
            }
        }
        public void ViewUpdate()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 7); Console.Write("Diga la cedula del votante a eliminar: ");
            String Cedula = Console.ReadLine();
            var VotanteUpd = servicioVotante.GetByCedula(Cedula);
            Visual(VotanteUpd);
            if (find)
            {
                Console.SetCursorPosition(40, 4); Console.Write("Actualizar VOTANTE");
                Console.SetCursorPosition(40, 9); Console.Write("Nuevos Nombres: ");
                //votante.Nombre = Console.ReadLine();
                Console.SetCursorPosition(40, 11); Console.Write("Nuevo Telefono:");
                //votante.Telefono = Console.ReadLine();
                Console.SetCursorPosition(40, 13); Console.Write("Nuevo Sexo:");
                //votante.Sexo = Console.ReadLine();
                Console.SetCursorPosition(40, 15); Console.Write("Nueva Edad:");
                //votante.Edad = Convert.ToInt16(Console.ReadLine());

                Console.SetCursorPosition(60, 9); VotanteUpd.Nombre = Console.ReadLine();
                Console.SetCursorPosition(60, 11);VotanteUpd.Telefono = Console.ReadLine();
                Console.SetCursorPosition(55, 13);VotanteUpd.Sexo = Console.ReadLine();
                Console.SetCursorPosition(55, 15);VotanteUpd.Edad = int.Parse(Console.ReadLine());

                var mensaje = servicioVotante.Update(VotanteUpd);

                Console.WriteLine(mensaje);
                Console.ReadKey();

            }

        }
        public void ViewDel()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 7); Console.Write("Diga la cedula del votante a eliminar: ");
            String Cedula = Console.ReadLine();
            var VotanteDel = servicioVotante.GetByCedula(Cedula);
            Visual(VotanteDel);
            if (find)
            {
                Console.SetCursorPosition(50, 14); Console.Write("¿Seguro que desea Eliminar? S/N");
                Console.SetCursorPosition(70, 15); string save = Console.ReadLine(); save = save.ToUpper();
                if (save.Equals("S"))
                {
                    var mensaje = servicioVotante.Delete(VotanteDel);
                    Console.SetCursorPosition(50, 20); Console.WriteLine(mensaje);
                }
            }
        }
        public void GetWoman()
        {
            Visualizer(servicioVotante.GetBySex("F"));
        }
        public void GetAll()
        {
            Visualizer(servicioVotante.GetAll());
        }
        public void ViewLugarVotAdd()
        {
            Console.Clear();
            LugarVotacion lugarVotacion = new LugarVotacion();
            Console.SetCursorPosition(5, 4); Console.Write("AGREGAR UN LUGAR DE VOTACION");
            Console.SetCursorPosition(5, 7); Console.Write("Codigo: ");
            Console.SetCursorPosition(5, 9); Console.Write("Descripcion: ");
            Console.SetCursorPosition(5, 11); Console.Write("Direccion: ");
            Console.SetCursorPosition(20, 7); lugarVotacion.Codigo = Console.ReadLine();
            Console.SetCursorPosition(20, 9); lugarVotacion.Descripcion = Console.ReadLine();
            Console.SetCursorPosition(20, 11); lugarVotacion.Direccion= Console.ReadLine();
            Console.SetCursorPosition(40, 12); Console.Write("¿Seguro que desea guardar? S/N");
            Console.SetCursorPosition(40, 13); string save = Console.ReadLine(); save = save.ToUpper();
            if (save.Equals("S"))
            {
                
                var mensaje = servicioLugVot.Add(lugarVotacion);
                Console.WriteLine(mensaje);
            }
        }
        public void ViewLugarVotUpdate()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 7); Console.Write("Diga el codigo del lugar a eliminar: ");
            String Codigo = Console.ReadLine();
            var LugarUpd =servicioLugVot.GetByCode(Codigo);
            VisualLugar(LugarUpd);
            if (find)
            {
                Console.SetCursorPosition(40, 4);Console.Write("Actualizar Lugar de votacion");
                Console.SetCursorPosition(40, 9);Console.Write("Nuevo Codigo: ");
                Console.SetCursorPosition(40, 11);Console.Write("Nueva Descripcion:");
                Console.SetCursorPosition(40, 13);Console.Write("Nueva Direccion:");
                Console.SetCursorPosition(55, 9); LugarUpd.Codigo = Console.ReadLine();
                Console.SetCursorPosition(60, 11);LugarUpd.Descripcion = Console.ReadLine();
                Console.SetCursorPosition(57, 13);LugarUpd.Direccion = Console.ReadLine();
                var mensaje = servicioLugVot.Update(LugarUpd);
                Console.WriteLine(mensaje);
                Console.ReadKey();

            }
        }
        public void ViewLugarVotDel()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 7); Console.Write("Diga el codigo del lugar a eliminar: ");
            String Codigo = Console.ReadLine();
            var LugarDel = servicioLugVot.GetByCode(Codigo);
            VisualLugar(LugarDel);
            if (find)
            {
                Console.SetCursorPosition(50, 14); Console.Write("¿Seguro que desea Eliminar? S/N");
                Console.SetCursorPosition(70, 15); string save = Console.ReadLine(); save = save.ToUpper();
                if (save.Equals("S"))
                {
                    var mensaje = servicioLugVot.Delete(LugarDel);
                    Console.SetCursorPosition(50, 20); Console.WriteLine(mensaje);
                }
            }
        }
        public void GetAllLugarVot()
        {
            VisualizerLugarVot(servicioLugVot.GetLugarVotAll());
        }
        private void Visualizer(List<Votante> lista)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("cedula");
            Console.SetCursorPosition(15, 7); Console.Write("Nombres");
            Console.SetCursorPosition(28, 7); Console.Write("Telefono");
            Console.SetCursorPosition(38, 7); Console.Write("Sexo");
            Console.SetCursorPosition(45, 7); Console.Write("Edad");
            Console.SetCursorPosition(5, 8); Console.Write("--------------------------------------------");

            int i = 0;
            foreach (var item in lista)
            {
                Console.SetCursorPosition(5, 9 + i); Console.Write(item.Cedula);
                Console.SetCursorPosition(15, 9 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(28, 9 + i); Console.Write(item.Telefono);
                Console.SetCursorPosition(38, 9 + i); Console.Write(item.Sexo);
                Console.SetCursorPosition(45, 9 + i); Console.Write(item.Edad);
                //Console.SetCursorPosition(5, 10+i); Console.Write("--------------------------------------------");
                i++;
            }


            Console.ReadKey();
        }
        private void VisualizerLugarVot(List<LugarVotacion> lista)
        {
            Console.Clear();
            Console.SetCursorPosition(5, 7); Console.Write("Codigo");
            Console.SetCursorPosition(15, 7); Console.Write("Descripcion");
            Console.SetCursorPosition(28, 7); Console.Write("Direccion");
            Console.SetCursorPosition(5, 8); Console.Write("--------------------------------------------");

            int i = 0;
            foreach (var item in lista)
            {
                Console.SetCursorPosition(5, 9 + i); Console.Write(item.Codigo);
                Console.SetCursorPosition(15, 9 + i); Console.Write(item.Descripcion);
                Console.SetCursorPosition(28, 9 + i); Console.Write(item.Direccion);
                i++;
            }

            Console.ReadKey();
        }
        private void Visual(Votante vo)
        {
            Console.Clear();
            if (vo != null)
            {
                Console.SetCursorPosition(5, 4); Console.Write("VOTANTE");
                Console.SetCursorPosition(5, 7); Console.Write("Cedula:");
                Console.SetCursorPosition(5, 9); Console.Write("Nombres:");
                Console.SetCursorPosition(5, 11); Console.Write("Telefono:");
                Console.SetCursorPosition(5, 13); Console.Write("Sexo:");
                Console.SetCursorPosition(5, 15); Console.Write("Edad:");
                //Console.SetCursorPosition(5, 17); Console.Write("Codigo:");
                //Console.SetCursorPosition(5, 19); Console.Write("Descripcion:");
                //Console.SetCursorPosition(5, 21); Console.Write("Direccion:");

                Console.SetCursorPosition(20, 7); Console.Write(vo.Cedula);
                Console.SetCursorPosition(20, 9); Console.Write(vo.Nombre);
                Console.SetCursorPosition(20, 11); Console.Write(vo.Telefono);
                Console.SetCursorPosition(20, 13); Console.Write(vo.Sexo);
                Console.SetCursorPosition(20, 15); Console.Write(vo.Edad);
                //Console.SetCursorPosition(20, 17); Console.Write(vo.LugarVotacion.Codigo);
                //Console.SetCursorPosition(20, 19); Console.Write(vo.LugarVotacion.Descripcion);
                //Console.SetCursorPosition(20, 21); Console.Write(vo.LugarVotacion.Direccion);
                find = true;
            }
            else
            {
                Console.SetCursorPosition(20, 20); Console.Write("Votante no encontrado");
            }

            Console.ReadKey();
        }
        private void VisualLugar(LugarVotacion Lu)
        {
            Console.Clear();
            if (Lu != null)
            {
                Console.SetCursorPosition(5, 4); Console.Write("LUGAR DE VOTACION");
                Console.SetCursorPosition(5, 7); Console.Write("Codigo:");
                Console.SetCursorPosition(5, 9); Console.Write("Descripcion:");
                Console.SetCursorPosition(5, 11); Console.Write("Direccion:");
                Console.SetCursorPosition(20, 7); Console.Write(Lu.Codigo);
                Console.SetCursorPosition(20, 9); Console.Write(Lu.Descripcion);
                Console.SetCursorPosition(20, 11); Console.Write(Lu.Direccion);
                find = true;
            }
            else
            {
                Console.SetCursorPosition(20, 20); Console.Write("Lugar no encontrado");
            }

            Console.ReadKey();
        }
    }
}
