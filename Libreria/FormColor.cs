using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;

namespace Libreria
{
    class FormColor
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MetroColorStyle MetroColor;

        public FormColor(MaterialForm form)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            switch (Esquema())
            {
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Green400, TextShade.WHITE);
                    MetroColor = MetroColorStyle.Blue;
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Orange500, Accent.Red700, TextShade.WHITE);
                    MetroColor = MetroColorStyle.Orange;
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo700, Primary.Indigo900, Primary.Indigo500, Accent.Pink400, TextShade.WHITE);
                    MetroColor = MetroColorStyle.Magenta;
                    break;
                default:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    MetroColor = MetroColorStyle.Teal;
                    break;
            }
        }

        private int Esquema()
        {
            Datos colores = new Datos("Config.txt");
            string[] config = colores.ObtenerVector("color");
            int color = int.Parse(config[1]);
            return color;
        }
    }
}
