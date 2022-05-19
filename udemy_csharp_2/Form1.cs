using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_csharp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Cars car1=new Cars();
            Cars car2 = new Cars();
            Cars car3 = new Cars();

            car1.CarBrand = "Audi";
            car1.CarModel = "A4";
            car1.GearType = "Otomatik";

            car2.CarBrand = "Bmw";
            car2.CarModel = "X3";
            car2.GearType = "Otomatik";

            car3.CarBrand = "Dacia";
            car3.CarModel = "Stepway";
            car3.GearType = "Manuel";

            List<Cars> cars = new List<Cars>() { car1, car2, car3 };
            
            foreach (var car in cars)
            {
                lbxCars.Items.Add(car.CarBrand);
            }
            dgrwCars.DataSource=cars;


        }
     
    }
}
