using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverFinalPositionServices: IRoverFinalPositionServices
    {
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate + 1;
            return roverInitialYCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate + 1;
            return roverInitialXCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate - 1;
            return roverInitialYCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate - 1;
            return roverInitialXCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate - 1;
            return roverInitialYCoordinate; 
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate + 1;
            return roverInitialXCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate - 1;
            return roverInitialXCoordinate;
        }

        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate + 1;
            return roverInitialYCoordinate;
        }
    }
}
