using Skelp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Skelp
{
    public partial class MainForm : Form
    {
        public Random _ran;
        List<Product> _products;
        public MainForm()
        {
            _ran = new Random();
            _products = new List<Product>();

            InitializeComponent();
            CreateProducts();
        }

        private void CreateProducts()
        {
            CreateHDD(_ran.Next(20));
            CreateProcessor(_ran.Next(15));
            CreateKeyboard(_ran.Next(25));
            CreateMouse(_ran.Next(40));
        }
        private void CreateHDD(int hDDCount)
        {
            for (int i = 0; i < hDDCount; i++)
            {
                HDD disk = new HDD();
                disk.manufacturer = "Disk" + i;
                disk.title = "NewDisk" + i;
                disk.price = _ran.Next(250, 400);
                disk.id_number = _ran.Next(1, 25324);
                disk.stock_amount = _ran.Next(15);
                disk.capacity = _ran.Next(250, 750);
                disk.rotation_speed = _ran.Next(2400, 20000);
                _products.Add(disk);
            }
        }
        private void CreateProcessor(int processorCount)
        {
            for (int i = 0; i < processorCount; i++)
            {
                Processor proc = new Processor();
                proc.manufacturer = "Processor" + i;
                proc.title = "SuperProcessor" + 2 * i;
                proc.price = _ran.Next(200, 500);
                proc.id_number = _ran.Next(1, 25324);
                proc.stock_amount = _ran.Next(0, 9);
                proc.cores_amount = _ran.Next(2, 8);
                proc.clock_rate = _ran.Next(2, 5);//wyrażone w GHz
                _products.Add(proc);
            }
        }
        private void CreateKeyboard(int keyboardCount)
        {
            for (int i = 0; i < keyboardCount; i++)
            {
                Keyboard kb = new Keyboard();
                kb.manufacturer = "KeyboardManufacturer" + i;
                kb.title = "QuietKeyboard" + 2 * i;
                kb.price = _ran.Next(69, 210);
                kb.id_number = _ran.Next(100, 300);
                kb.stock_amount = _ran.Next(0, 3);
                kb.buttons = _ran.Next(80, 140);
                _products.Add(kb);
            }
        }
        private void CreateMouse(int mouseCount)
        {
            for (int i = 0; i < mouseCount; i++)
            {
                Mouse mouse = new Mouse();
                mouse.manufacturer = "MM" + i;
                mouse.title = "GamingMouse" + i;
                mouse.price = _ran.Next(29, 99);
                mouse.id_number = _ran.Next(1000, 9999);
                mouse.stock_amount = _ran.Next(0, 7);
                mouse.buttons = _ran.Next(2, 12);
                mouse.dpi = _ran.Next(800, 2400);
                mouse.weight = _ran.Next(120, 370);
                _products.Add(mouse);
            }
        }


        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
