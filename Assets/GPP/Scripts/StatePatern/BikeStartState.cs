using UnityEngine;

namespace GameProgrammingPattern.StatePatern
{
    public class BikeStartState:MonoBehaviour,IBikeState
    {
        private BikeController _bikeController;

        public void Handle(BikeController bikeController)
        {
            if (_bikeController == null)
                _bikeController = bikeController;

            _bikeController.CurrentSpeed = _bikeController.maxSpeed;
        }

        void Update()
        {
            if (_bikeController)
            {
                if (_bikeController.CurrentSpeed > 0)
                {
                    _bikeController.transform.Translate(
                        Vector3.forward * (
                            _bikeController.CurrentSpeed *
                            Time.deltaTime));
                }
            }
        }
    }
}