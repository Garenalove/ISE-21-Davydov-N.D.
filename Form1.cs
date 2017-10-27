using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
	public partial class FormAerodrome : Form
	{
		Parking parking;



		public FormAerodrome()
		{
			InitializeComponent();
            parking = new Parking(5);
			for (int i = 1; i < 6; i++)
			{
				listBoxLevels.Items.Add("Уровень " + i);
			}
			listBoxLevels.SelectedIndex = parking.getCurentLvl;
			
			draw();
		}

		public void draw()
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
				Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
				pictureBoxAerodrome.Image = bmp;
			}
		}



		private void butSetPlane_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var plane = new MotorShip(1000, 100, 30, dialog.Color);
                int place = parking.PutShipInParking(plane);
				draw();
				MessageBox.Show("Вашеместо: " + place);

			}
		}

		private void butSetFigther_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var plane = new UltaMegaBuffSuperMotorShip(1000, 100, 30, dialog.Color, true, true, dialogDop.Color);
                    int place = parking.PutShipInParking(plane);

                    draw();
                    MessageBox.Show("Вашеместо: " + (place + 1));

				}
			}
		}
		
		private void butTake_Click(object sender, EventArgs e)
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();

				if (maskedTextBox1.Text != "")
				{
                    var plane = parking.GetShipInParking(Convert.ToInt32(maskedTextBox1.Text) -1 );
					Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width, pictureBoxTakePlane.Height);
					Graphics gr = Graphics.FromImage(bmp);
					plane.sePosition(45, 50);
					plane.drawShip(gr);
					pictureBoxTakePlane.Image = bmp;
					draw();
				}
			}
		}

		private void btnLevelDown_Click(object sender, EventArgs e)
		{
            parking.lvlDown();
			listBoxLevels.SelectedIndex = parking.getCurentLvl;
			draw();

		}

		private void btnLevelUp_Click(object sender, EventArgs e)
		{
            parking.lvlUp();
			listBoxLevels.SelectedIndex = parking.getCurentLvl;
			draw();

		}
	}
}
