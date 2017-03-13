using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverBackwardMovementServices : IRoverBackwardMovementServices
    {
        public int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate - 1;
            return roverXCoordinate;
        }

        public int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate + 1;
            return roverXCoordinate;
        }

        public int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate - 1;
            return roverYCoordinate;
        }

        public int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate + 1;
            return roverYCoordinate;
        }
    }
}
