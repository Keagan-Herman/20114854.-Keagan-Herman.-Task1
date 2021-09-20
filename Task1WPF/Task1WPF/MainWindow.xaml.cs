using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task1;

namespace Task1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassLibModules i = new ClassLibModules();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //(W3schools Online Web Tutorials, 2021)
        {
            lstShow.Items.Clear();
            lstShow.Items.Add("MODULE INFORMATION");
            lstShow.Items.Add("**********************************");
            for (int x = 0; x < i.getCounter(); x++)
            {
                lstShow.Items.Add("Module Name: " + i.getName(x));
                lstShow.Items.Add("Module code: " + i.getCode(x));
                lstShow.Items.Add("Module credits: " + i.getNumofCredits(x));
                lstShow.Items.Add("Class hours per week: " + i.getClassHours(x));

                lstShow.Items.Add("*******************************");
                lstShow.Items.Add("SELF STUDY");
                lstShow.Items.Add("Number of weeks in the semester: " + i.getiSemesterWeeks(x));
                
                double SelfStudyCalc =
                    ((Convert.ToDouble(i.getNumofCredits(x)) * 10) / Convert.ToDouble(i.getiSemesterWeeks(x))
                    - Convert.ToDouble(i.getClassHours(x)));

                lstShow.Items.Add("Module Name: " + i.getName(x));
                lstShow.Items.Add("Self-study hours needed: " + SelfStudyCalc);
                lstShow.Items.Add("*******************************");

                lstShow.Items.Add("REMAINING SELF STUDY HOURS");
                lstShow.Items.Add("Hours spent on each module: " + i.getModuleHours(x));

                double remainCalc = 
                    SelfStudyCalc - i.getModuleHours(x);
                if (remainCalc > 0)
                {
                    lstShow.Items.Add("Remaining hours needed to study: " + remainCalc);
                }
                else if (remainCalc <= 0)
                {
                    lstShow.Items.Add("No self study needed");
                }

                lstShow.Items.Add("*******************************");
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            i.setArray(Convert.ToInt32(txtModuleCount.Text));
            MessageBox.Show("Please enter your module information on the next page");
            txtModuleCount.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtModuleName.Clear();
            txtModuleCode.Clear();
            txtNumOfCredits.Clear();
            txtClassHours.Clear();
            txtNumHours.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            String Name = Convert.ToString(txtModuleName.Text);
            String Code = Convert.ToString(txtModuleCode.Text);
            int NumCredit = Convert.ToInt32(txtNumOfCredits.Text);
            int classHours = Convert.ToInt32(txtClassHours.Text);
            int moduleHours = Convert.ToInt32(txtNumHours.Text);
            int SemesterWeeks = Convert.ToInt32(txtNumWeeks.Text);

            if (i.AddToArray(Name, Code, NumCredit, classHours, moduleHours, SemesterWeeks) == false)
            {
                MessageBox.Show("You have exceeded your selected module count");
            }
            else
            {
                MessageBox.Show("Your module information has been added");
            }
        }
    }
}
