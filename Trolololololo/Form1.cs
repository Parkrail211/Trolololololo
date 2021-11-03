using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace Trolololololo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Troll();
            
        }

        private string Troll()
        {
            while (true)
            {
                XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            }
            return "FUCK";
        }


    }

   
}


