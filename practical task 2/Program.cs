using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Керн Александр Владимирович";
            byte age = 30;
            string email = "sasha.kern.@mail.ru";
            double programmingScores = 4.7;
            double mathScores = 4.9;
            double physicsScores = 4.8;
            Console.WriteLine("Ф.И.О: {0} \nВозрас: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}",
                fullName,
                age,
                email,
                programmingScores,
                mathScores,
                physicsScores);
            Console.ReadKey();
            double totalPoints = physicsScores + mathScores + physicsScores;
            double averageScore = totalPoints / 3;
            Console.WriteLine($"Сумма всех баллов: {totalPoints} \nСрнднее арифметическое: {averageScore}");
            Console.ReadKey();

        }
    }
}
