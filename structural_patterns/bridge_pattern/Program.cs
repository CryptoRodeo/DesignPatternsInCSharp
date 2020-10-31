using System;
using bridge_pattern.abstract_implementor;
using bridge_pattern.concrete_implementor;
using bridge_pattern.refined_abstraction;

namespace bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv myTv = new SmartTv();
            Console.WriteLine("Select a source to get TV guide and play");
            Console.WriteLine("1. Local Cable Tv\n2. Local Dish Tv\n3. IP TV");
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalCableTv();
                    break;

                case '2':
                    myTv.VideoSource = new LocalDishTv();
                    break;

                case '3':
                    myTv.VideoSource = new IPTvService();
                    break;
            }
            Console.WriteLine();

            myTv.ShowTvGuide();
            myTv.PlayTV();
            Console.WriteLine();
        }
    }
}
