using System;
using System.Windows.Forms;
using Elevator;
namespace ElevatorConsumerWinForm
{
    public partial class Elevator : Form
    { 
        IBuilding building = null;
        public Elevator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        } 
        private void GetElevator(int floorId, Direction direction)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxFloorId.Text))
                {
                    labelError.Text = "Fill the data";
                    return;
                }

                labelElevatorResult.Text = "";

                var result = Utility.PressButtonFromAFloor(building, floorId, direction);
                labelElevatorResult.Text = "The Optimal Elevator is : " + result;

                displayElevatorInfo(building);
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Message: {0}; StackTrace: {1}", ex.Message, ex.StackTrace), LogType.Error);
            }
        }

        private void displayElevatorInfo(IBuilding building)
        {
            labelElevatorsInfo.Text = "";

            foreach (IElevator elevator in building.GetElevators())
                labelElevatorsInfo.Text = labelElevatorsInfo.Text +
                                            Environment.NewLine + 
                                            Environment.NewLine + 
                                            "Elevator Id : " + elevator.ElevatorName.ToString() + 
                                            "        Direction : " + elevator.CurrentDirection + 
                                            "        Current Floor : " + elevator.CurrentFloorId.ToString();

        }

        private void displayFloorInfo(IBuilding building)
        {
            labelFloorsInfo.Text = "";
            foreach (IFloor floor in building.GetFloors())
                labelFloorsInfo.Text = labelFloorsInfo.Text + Environment.NewLine + "Floor Id : " + floor.FloorId.ToString();

        }

        private void btnInitializeBuilding_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            InitBuilding();
        }

        private void InitBuilding()
        {
            try
            {
                if(!ValidateConfigInputData()) return;

                building = new Building(Convert.ToInt32(textBoxLowestFloor.Text), Convert.ToInt32(textBoxHighestFloor.Text), Convert.ToInt32(textBoxElevatorCount.Text));
                Utility.SetSampleFloorElevatorValues(building);

                displayFloorInfo(building);
                displayElevatorInfo(building);
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Message: {0}; StackTrace: {1}", ex.Message, ex.StackTrace), LogType.Error);
            }
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputData()) return;

            GetElevator(Convert.ToInt32(textBoxFloorId.Text), Direction.Up);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if(!ValidateInputData()) return;
            GetElevator(Convert.ToInt32(textBoxFloorId.Text), Direction.Down);
        }
        private bool ValidateConfigInputData()
        {
            if (string.IsNullOrEmpty(textBoxLowestFloor.Text) ||
                    string.IsNullOrEmpty(textBoxHighestFloor.Text) ||
                    string.IsNullOrEmpty(textBoxElevatorCount.Text))
            {
                labelError.Text = "Fill the data";
                return false;
            }

            int data = 0;
            if (!Int32.TryParse(textBoxLowestFloor.Text, out data))
            {
                labelError.Text = "Fill the right LowestFloor";
                return false;
            }
            if (!Int32.TryParse(textBoxHighestFloor.Text, out data))
            {
               
                labelError.Text = "Fill the right HighestFloor";
                return false;
            }
            if (!Int32.TryParse(textBoxElevatorCount.Text, out data))
            {
                labelError.Text = "Fill the right ElevatorCount";
                return false;
            }

            if (Convert.ToInt32(textBoxHighestFloor.Text) < Convert.ToInt32(textBoxLowestFloor.Text))
            {
                labelError.Text = "Fill the right Floor data";
                return false;
            }


            return true;
        }
        private bool ValidateInputData()
        {
            labelError.Text = "";
            if (string.IsNullOrEmpty(textBoxFloorId.Text))
            {
                labelError.Text = "Fill the data";
                return false;
            }
            int floorId = 0;
            if (!Int32.TryParse(textBoxFloorId.Text, out floorId))
            {
                labelError.Text = "Fill the right FloorId";
                return false;
            }

            if (Int32.TryParse(textBoxFloorId.Text, out floorId))
            {
                if (floorId > Convert.ToInt32(textBoxHighestFloor.Text))
                {
                    labelError.Text = "Fill the right FloorId";
                    return false;
                }
            }
            return true;
        }
    }
}
