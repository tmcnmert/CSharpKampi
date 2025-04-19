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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
         EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {

           lbllocationcount.Text = db.Location.Count().ToString();
           lblSumcapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();
           lblGuidecount.Text = db.Guide.Count().ToString();
           lblavgcapacity.Text = (db.Location.Average(x => x.Capacity)).ToString();
           lblavglocationprice.Text = (db.Location.Average(x => x.Price))?.ToString("0.00");
           int lastcountryid = db.Location.Max(x => x.LocationId);
            lbllastcountry.Text = db.Location.Where(x => x.LocationId == lastcountryid).Select(y => y.Country).FirstOrDefault();
            lblcappadocialocation.Text = db.Location.Where(x => x.City == "Kapadokya").Select(z=>z.Capacity).FirstOrDefault().ToString();
            lblTürkiyecapacityavg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var romeguideid = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblromeguidename.Text = db.Guide.Where(x => x.GuideId == romeguideid).Select(z => z.GuideName+" "+z.GuideSurname).FirstOrDefault().ToString();
            var maxcapacity= db.Location.Max(x => x.Capacity);
            lblmaxcapacity.Text = db.Location.Where(x => x.Capacity == maxcapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxprice = db.Location.Max(x => x.Price);
            lblmaxpricelocation.Text = db.Location.Where(x => x.Price == maxprice).Select(y => y.City).FirstOrDefault().ToString();
            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblaysegulcinarlocationcount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();


        }
    }
}
