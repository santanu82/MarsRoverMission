using NasaRoverMissionApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp
{
    class Program
    {
        RoverForwardMovementServices myRoverForwardMovement = new RoverForwardMovementServices();
        RoverBackwardMovementServices myRoverBackwardMovement = new RoverBackwardMovementServices();
        RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
        RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("=========Welcome to Nasa Rover Mission========");
            Console.WriteLine("Please provide rover x-coordinate :");
            int roverXCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Please provide rover y-coordinate :");
            int roverYCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Please provide rover alignment :");
            string roverAlignment = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Now please provide the rover move command below");
            Console.WriteLine("Please provide first move command");
            string myRoverFistMoveCommand = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Please provide second move command");
            string myRoverSecondMoveCommand = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Please provide third move command");
            string myRoverThirdMoveCommand = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Please provide fourth move command");
            string myRoverFourthMoveCommand = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Please provide fifth move command");
            string myRoverFifthMoveCommand = Console.ReadLine();
            Console.Beep();
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

               
            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            if (true)
            {

            }
            Console.ReadLine();
        }
    }
}
