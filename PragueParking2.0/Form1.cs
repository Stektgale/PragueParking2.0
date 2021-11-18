namespace PragueParking2._0
{
    public partial class Form1 : Form
    {
        ParkingSpot pSpot = new ParkingSpot();
        Vehicle veh = new Vehicle(4, "ABC123");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddVehicle_Click(object sender, EventArgs e)
        {
            pSpot.AddVehicle(veh);
        }

        private void btn_RemoveVehicle_Click(object sender, EventArgs e)
        {
            pSpot.RemoveVehicle(veh);
        }
    }
}