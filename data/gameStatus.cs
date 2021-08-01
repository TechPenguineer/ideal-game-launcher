using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igl.data
{
    class gameStatus
    {
        
    }
    class GameStatuses
    {
        public enum Statuses
        {
            Installing,
            Updating,
            Unavalible,
            Start
        }
    }

    class IGLGameStatus
    {
        public dynamic status;
    }
}
