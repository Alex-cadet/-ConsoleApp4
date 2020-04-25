using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Reffery rf = new Reffery("Судит", "Иванов", 39, "Главный");
            rf.About();
            rf.Accesss();
            Coach tre = new Coach("Тренирует", "Говоров", 51, 18);
            tre.About();
            Player pl = new Player("Играет", "Судокин", 27, 6);
            pl.About();
            FieldPl fi = new FieldPl("Играет", "Пименов", 23, 9, "Полузащитник");
            fi.goals = 5;
            fi.pass = 10;
            fi.golpas = 8;
            fi.About();
            Goalkeeper gl = new Goalkeeper("Играет", "Субботин", 32, 13, "Запасной вратарь");
            gl.shoots = 27;
            gl.offG = 9;
            gl.Saves = 15;
            gl.About();
        }
    }
}
