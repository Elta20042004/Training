using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalculation
{
    public partial class Calculation : System.Web.UI.Page
    {
        public List<DayTiming> DayTimings;
        private List<KeyValuePair<int, string>> _hours;
        private List<KeyValuePair<int, string>> _minutes;
        private List<KeyValuePair<int, string>> _baseSallary;
        private List<KeyValuePair<DayKind, string>> _holiday;
        private double zarplata;
        public double rezult;
        private SalaryEntities _salaryEntities;

        protected void Page_Load(object sender, EventArgs e)
        {
            InitHours();
            InitMinutes();
            InitddlBaseSellary();
            InitHoliday();

            if (!IsPostBack)
            {
                ddlBaseSellary.DataSource = _baseSallary;
                ddlBaseSellary.DataBind();
            }

            _salaryEntities = new SalaryEntities();
        }

        public DayTiming GetDayTiming(int day)
        {
            return DayTimings.First(t => t.Day == day);
        }



        protected void GodMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayTimings = InitDayTimings();
            lvDayTimings.DataSource = DayTimings;
            lvDayTimings.DataBind();
        }      

        private List<DayTiming> InitDayTimings()
        {
            int month = int.Parse(ddlMonth.SelectedValue);
            int god = int.Parse(ddlGod.SelectedValue);
            int dayCount = DateTime.DaysInMonth(god, month);
            var result = new List<DayTiming>();
            for (int i = 1; i <= dayCount; i++)
            {
                result.Add(new DayTiming(i));
            }
            return result;
        }

        private void SalaryDbTests()
        {

            _salaryEntities.OneDayDatas.Add(new OneDayData()
            {
                Date = new DateTime(2015, 6, 14),
                EndTime = new DateTime(2015,6, 14, 18, 15, 0),
                StartTime = new DateTime(2015, 6, 14, 8, 16, 0),
                DayKind = 0,
                Id=0,
                UserId = 0
            });

            _salaryEntities.SaveChanges();
        }

        protected void Calculation_Click(object sender, EventArgs e)
        {
            SalaryDbTests();


            DayTimings = ConvertTimings(lvDayTimings.Items);
            double baseSallary = double.Parse(ddlBaseSellary.SelectedValue);
            for (int i = 0; i < DayTimings.Count; i++)
            {
                double firstHalf = (double)DayTimings[i].StartHour * 60;
                double secondHalf = (double)DayTimings[i].EndHour * 60;
                double razdnicaChasov = (secondHalf - firstHalf) / 60;               
                double razdnicaMinut = Math.Abs((double)DayTimings[i].EndMinute - (double)DayTimings[i].StartMinute);
                
                if ((razdnicaChasov == 1) && (razdnicaMinut > 0))
                {
                    zarplata = ((60 - razdnicaMinut)*baseSallary)/60;
                }
                else if (razdnicaChasov < 8)
                {
                    rezult = (razdnicaChasov * baseSallary) + ((razdnicaMinut * baseSallary) / 60);
                }
                else if ((razdnicaChasov >= 8) && (razdnicaChasov < 10))
                {
                    double procent = baseSallary * 125 / 100;
                    rezult = (8 * baseSallary) + ((razdnicaChasov - 8) * procent) + ((razdnicaMinut * procent) / 60);
                }
                else
                {
                    double procent = baseSallary * 150 / 100;
                    rezult = (8 * baseSallary) + (2 * (baseSallary * 125 / 100)) + ((razdnicaChasov - 10) * procent) + ((razdnicaMinut * procent) / 60);
                }

                if (DayTimings[i].DayKind == DayKind.Normal)
                {
                    zarplata = zarplata + rezult;
                }
                else if (DayTimings[i].DayKind == DayKind.Full)
                {
                    zarplata = zarplata + rezult*1.5;
                }
            }

            lblRezult.Text = zarplata.ToString();

        }

        private List<DayTiming> ConvertTimings(IList<ListViewDataItem> items)
        {
            List<DayTiming> result = new List<DayTiming>();
            foreach (var item in items)
            {
                Label dayCtrl = item.FindControl("Day") as Label;
                int day = int.Parse(dayCtrl.Text);
                DayTiming timing = new DayTiming(day)
                {
                    StartHour = GetInt(item, "StartHour"),
                    StartMinute = GetInt(item, "StartMinute"),
                    EndHour = GetInt(item, "EndHour"),
                    EndMinute = GetInt(item, "EndMinute"),
                    DayKind = GetDayKind(item, "Holidays")
                };
                result.Add(timing);
            }
            return result;
        }

        private static int GetInt(ListViewDataItem item, string name)
        {
            var ctrl = item.FindControl(name) as DropDownList;
            return int.Parse(ctrl.SelectedValue);
        }

        private static DayKind GetDayKind(ListViewDataItem item, string name)
        {
            var ctrl = item.FindControl(name) as DropDownList;
            return (DayKind)Enum.Parse(typeof(DayKind), ctrl.SelectedValue);
        }

        private void InitHours()
        {
            _hours = new List<KeyValuePair<int, string>>();
            for (int i = 0; i <= 23; i++)
            {
                string k = i.ToString();
                if (i < 10)
                {
                    k = "0" + i.ToString();
                }

                _hours.Add(new KeyValuePair<int, string>(i, k));
            }
        }

        private void InitHoliday()
        {
            _holiday = new List<KeyValuePair<DayKind, string>>();

            _holiday.Add(new KeyValuePair<DayKind, string>(DayKind.Normal, "обычный"));
           // _holiday.Add(new KeyValuePair<DayKind, string>(DayKind.Half, "пол выходного"));
            _holiday.Add(new KeyValuePair<DayKind, string>(DayKind.Full, "выходной"));

        }


        private void InitddlBaseSellary()
        {
            _baseSallary = new List<KeyValuePair<int, string>>();
            for (int i = 20; i <= 80; i++)
            {
                _baseSallary.Add(new KeyValuePair<int, string>(i, i.ToString()));
            }


        }


        private void InitMinutes()
        {
            _minutes = new List<KeyValuePair<int, string>>();
            for (int i = 0; i <= 59; i++)
            {
                string k = i.ToString();
                if (i < 10)
                {
                    k = "0" + i.ToString();
                }
                _minutes.Add(new KeyValuePair<int, string>(i, k));
            }
        }

        protected void DayTimings_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                //Find the DropDownList in the Row
                DropDownList t = (e.Item.FindControl("StartHour") as DropDownList);
                t.DataSource = _hours;
                t.DataBind();
                string tmp = (e.Item.FindControl("LabelStartHour") as Label).Text;
                t.Items.FindByValue(tmp).Selected = true;

                t = (e.Item.FindControl("StartMinute") as DropDownList);
                t.DataSource = _minutes;
                t.DataBind();
                tmp = (e.Item.FindControl("LabelStartMinute") as Label).Text;
                t.Items.FindByValue(tmp).Selected = true;

                t = (e.Item.FindControl("EndHour") as DropDownList);
                t.DataSource = _hours;
                t.DataBind();
                tmp = (e.Item.FindControl("LabelEndHour") as Label).Text;
                t.Items.FindByValue(tmp).Selected = true;

                t = (e.Item.FindControl("EndMinute") as DropDownList);
                t.DataSource = _minutes;
                t.DataBind();
                tmp = (e.Item.FindControl("LabelEndMinute") as Label).Text;
                t.Items.FindByValue(tmp).Selected = true;

                t = (e.Item.FindControl("Holidays") as DropDownList);
                t.DataSource = _holiday;
                t.DataBind();
                tmp = (e.Item.FindControl("LabelHoliday") as Label).Text;
                t.Items.FindByValue(tmp).Selected = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }




    public class DayTiming
    {
        public int Day { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
        public DayKind DayKind { get; set; }

        public DayTiming(int day)
        {
            Day = day;
            StartHour = 0;
            StartMinute = 0;
            EndHour = 0;
            EndMinute = 0;
            DayKind = DayKind.Normal;
        }
    }

    public enum DayKind
    {
        Normal,
        Half,
        Full
    }
}