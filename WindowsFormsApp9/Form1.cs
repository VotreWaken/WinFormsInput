using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp9.MainForm;

namespace WindowsFormsApp9
{
    public partial class MainForm : Form
    {
        int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Date Dates = new Date();

        public class Date
        {
            private int days_;
            private int month_;
            private int year_;
            private int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Constructor By Parametres
            public Date(int day, int month, int year)
            {
                try
                {
                    days_ = day;
                    month_ = month;
                    year_ = year;

                    if ((days_ > 31) || (month_ > 12))
                    {
                        throw new Exception("Incorrect Date");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            public void SetStringMonth(string monthStr)
            {

                int monthInt = 0;
                string[] Month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                for (int i = 0; i < 12; i++)
                {
                    if (Month[i] == monthStr)
                    {
                        monthInt = i + 1;
                        break;
                    }
                }
                // Set the date values
                month_ = monthInt;
            }

            // Default Constructor ( Initialize Current Time )
            public Date()
            {
                days_ = DateTime.Now.Day;
                month_ = DateTime.Now.Month;
                year_ = DateTime.Now.Year;
            }

            // Get Count of Days In Specific Month
            public int GetDaysInMonth(int index)
            {
                return days[index - 1];
            }
            // Get Day
            public int GetDay()
            {
                return days_;
            }

            // Get Month
            public int GetMonth()
            {
                return month_;
            }

            // Get Year
            public int GetYear()
            {
                return year_;
            }

            // Set Year
            public void SetYear(int Year)
            {
                this.year_ = Year;
            }
            // Set Month
            public void SetMonth(int Month)
            {
                this.year_ = Month;
            }
            // Set Day
            public void SetDay(int Day)
            {
                this.year_ = Day;
            }

            // Is year leap 
            public bool isLeap()
            {
                if ((year_ % 4 == 0 && year_ % 100 != 0) && year_ % 400 == 0)
                {
                    return true;
                }
                return false;
            }

            public string ShowAllMonth(int index)
            {
                string[] Month =
                    { "January","February","March","April","May","June","July","August","September","October","November","December" };
                return Month[index];
            }
        }
        public MainForm()
        {
            InitializeComponent();
            UserGender.Items.Add("Женский");
            UserGender.Items.Add("Мужской");
            UserFamilyStatus.Items.Add("Женат");
            UserFamilyStatus.Items.Add("Не Женат");
            UserFamilyStatus.Items.Add("В Активном Поиске");
        }

        private void UserMonth_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                UserMonth.Items.Add(Dates.ShowAllMonth(i));
            }
        }

        private void UserMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dates.SetStringMonth(UserMonth.SelectedItem.ToString());
        }

        private void UserMonth_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                UserMonth.Items.Remove(Dates.ShowAllMonth(i));
            }
        }

        private void UserDay_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < Dates.GetDaysInMonth(Dates.GetMonth()); i++)
            {
                UserDay.Items.Add(i.ToString());
            }
        }

        private void UserDay_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 1; i < Dates.GetDaysInMonth(Dates.GetMonth()); i++)
            {
                UserDay.Items.Remove(i.ToString());
            }
        }

        private void UserYear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                UserYear.Items.Add(Dates.GetYear() - i);
            }
        }

        public class SendInfo
        {
            public string Name;
            public string Surname;
            public string Patrynomic;
            public string Gender;
            public string FamilyStatus;
            public string AdditionalInfo;
            public string DateDay;
            public string DateMonth;
            public string DateYear;
            public SendInfo(string name, string surname, string patrynomic, string Day, string Month, string Year, string gender, string familyStatus, string additionalInfo)
            {
                Name = name;
                Surname = surname;
                Patrynomic = patrynomic;
                Gender = gender;
                DateDay = Day;
                DateMonth = Month;
                DateYear = Year;
                FamilyStatus = familyStatus;
                AdditionalInfo = additionalInfo;
            }

            public SendInfo()
            {

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            XmlSerializer serializer = null;
            SendInfo a = new SendInfo(UserName.Text, UserSurname.Text, UserPatronymic.Text, this.UserDay.Text, this.UserMonth.Text, this.UserYear.Text ,UserGender.Text, UserFamilyStatus.Text, UserAdditionalInformation.Text);
            stream = new FileStream("../../data.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(SendInfo));
            serializer.Serialize(stream, a);
            stream.Close();
            MessageBox.Show("Сериализация успешно выполнена!");
        }

        private void UserName_Click(object sender, EventArgs e)
        {

            UserName.Text = String.Empty;
        }

        private void UserSurname_Click(object sender, EventArgs e)
        {
            UserSurname.Text = String.Empty;
        }

        private void UserPatronymic_Click(object sender, EventArgs e)
        {
            UserPatronymic.Text = String.Empty;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("../../data.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(SendInfo));
            SendInfo h = (SendInfo)serializer.Deserialize(stream);
            UserName.Text = h.Name;
            UserSurname.Text = h.Surname;
            UserPatronymic.Text = h.Patrynomic;
            UserDay.Text = h.DateDay;
            UserMonth.Text = h.DateMonth;
            UserYear.Text = h.DateYear;
            UserGender.Text = h.Gender;
            UserFamilyStatus.Text = h.FamilyStatus;
            UserAdditionalInformation.Text = h.AdditionalInfo;
            MessageBox.Show("Десериализация успешно выполнена!");
            stream.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "Select one of the answers";
            }
            else
            {
                UserName.Text = UserName.Text;
            }
        }
    }
}
