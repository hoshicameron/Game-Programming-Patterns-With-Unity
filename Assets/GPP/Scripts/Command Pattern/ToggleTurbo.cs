namespace GameProgrammingPattern.CommandPattern
{
    public class ToggleTurbo: Command
    {
        private BikeController _bikeController;

        public ToggleTurbo(BikeController controller)
        {
            _bikeController = controller;
        }

        public override void Execute()
        {
            _bikeController.ToggleTurbo();
        }
    }
}