using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverAlignmentService: IRoverAlignmentService
    {
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "S";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "E";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "N";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "W";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "W";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "N";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "E";
        }

        public string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "S";
        }
    }
}
