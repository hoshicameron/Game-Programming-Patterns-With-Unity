using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingPattern.StatePatern
{
    public interface IBikeState
    {
        void Handle(BikeController bikeController);
    }
}
