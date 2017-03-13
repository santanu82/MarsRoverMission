using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverForwardMovementServices: IRoverForwardMovementServices
    {
        public int GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate+1;
            return roverXCoordinate;
        }

        public int GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate - 1;
            return roverXCoordinate;
        }

        public int GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate + 1;
            return roverYCoordinate;
        }

        public int GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate - 1;
            return roverYCoordinate;
        }

       
    }
}
