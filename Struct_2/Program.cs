using System;

namespace Struct_2
{
    struct Train
    {
        public string DestinationPoint { get; set; }
        public int TrainNum { get; set; }
        public DateTime DepartureTime { get; set; }
        public Train(string destPoint, int num, DateTime time)
        {
            DestinationPoint = destPoint;
            TrainNum = num;
            DepartureTime = time;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8]; int input; bool checker = false;
            for (int i = 0; i < 8; i++)
            {
                try
                {
                    Console.WriteLine("Введите номер поезда:"); trains[i].TrainNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название пункта назначения:"); trains[i].DestinationPoint = Console.ReadLine();
                    Console.WriteLine("Введите время прибытия(вводите в формате ЧЧ:ММ:СС):"); trains[i].DepartureTime = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно введенные данные"); break;
                }
            }

            Array.Sort(trains, new Comparison<Train>((a, b) => a.TrainNum.CompareTo(b.TrainNum)));
            while (true)
            {
                checker = false;
                Console.WriteLine("Введите номер поезда, информацию о котором вы хотите узнать. Для выхода введите '-1'");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == -1) break;
                else
                {

                    foreach (Train tr in trains)
                    {
                        if (input == tr.TrainNum)
                        {
                            Console.WriteLine("Номер поезда - {0}, пункт назначения - {1}, время прибытия - {2}", tr.TrainNum, tr.DestinationPoint, tr.DepartureTime); checker = true;
                        }

                    }
                    if (!checker) Console.WriteLine("Поезда с таким номером нет.");
                }
            }
        }
    }
}
