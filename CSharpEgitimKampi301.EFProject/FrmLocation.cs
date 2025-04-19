using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            location.City = txtcity.Text;
            location.Country = txtcountry.Text;
            location.Price = decimal.Parse(txtprice.Text);
            location.DayNight = txtdaynight.Text;
            location.GuideId=int.Parse(comboBox1.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location Başarıyla Eklendi");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load_1(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "GuideId";
            comboBox1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deleteValue = db.Location.Find(id);
            db.Location.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Location Başarıyla Silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.City = txtcity.Text;
            updateValue.Country = txtcountry.Text;
            updateValue.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            updateValue.Price = decimal.Parse(txtprice.Text);
            updateValue.DayNight = txtdaynight.Text;
            updateValue.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Location Başarıyla Güncellendi");

        }
    }
}
