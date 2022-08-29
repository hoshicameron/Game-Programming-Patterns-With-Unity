using UnityEngine;

namespace GameProgrammingPattern.StatePatern
{
    public class BikeStopState:MonoBehaviour,IBikeState
    {
        private BikeController _bikeController;
        public void Handle(BikeController bikeController)
        {
            if (_bikeController == null)
                _bikeController = bikeController;

            _bikeController.CurrentSpeed = 0;
        }
    }
}



