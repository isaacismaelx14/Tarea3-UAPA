namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] empties = [];
        string[] invalid = [];
        TextBox[] texboxList = [];

        public Form1()
        {
            InitializeComponent();
        }

        private int parseInt(TextBox tb)
        {
            string str = tb.Text;
            if (string.IsNullOrEmpty(str))
            {
                empties = addUniqueToList(empties, tb);
                return 0;
            };

            try
            {
                return int.Parse(str);
            }
            catch
            {
                invalid = addUniqueToList(invalid, tb);
                return 0;
            }
        }

        private string[] addUniqueToList(string[] arr, TextBox tb)
        {
            string value = tb.Text;
            bool exist = false;

            foreach (var item in arr)
            {
                if (item == value)
                {
                    exist = true;
                    break;
                }
            }

            if (!exist) arr.Append(value);

            return arr;
        }

        private string[] removeIfExist(string[] arr, TextBox tb)
        {
            string[] newList = [];
            string value = tb.Text;

            foreach (var item in arr)
            {
                if (item != value)
                {
                    newList.Append(item);
                }
            }

            return newList;
        }

        private int CalcScore()
        {
            int exam = parseInt(tbExam);
            int actitudes = parseInt(tbActitudes);
            int platform = parseInt(tbPlatform);
            int production = parseInt(tbProduction);
            int activities = parseInt(tbActivities);

            return exam + actitudes + platform + production + activities;
        }

        private void showError(string msg)
        {
            lblError.Text = msg;
        }

        private void clearError()
        {
            lblError.Text = "";
        }

        private void checkMax(TextBox tb, Label lb, int max)
        {
            int num = parseInt(tb);
            string errMsg = "El valor maximo para " + lb.Text + " es " + max;

            if (num > max)
            {
                showError(errMsg);
                btnCalc.Enabled = false;
                tb.Focus();
                return;
            }

            if (!btnCalc.Enabled)
            {
                btnCalc.Enabled = true;
                clearError();
            }
        }

        private string getResult(int total)
        {
            if (total >= 70) return "Aprobado";
            else return "Reprobado";
        }

        private string getLiteral(int total)
        {
            if (total >= 90) return "A";
            else if (total >= 80) return "B";
            else if (total >= 70) return "C";
            else if (total >= 60) return "D";
            else return "F";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int total = CalcScore();
            string toPrint = total.ToString();

            tbFinalCalification.Text = toPrint;
            tbResult.Text = getResult(total);
            tbLiteral.Text = getLiteral(total);
        }

        private void tbExam_TextChanged(object sender, EventArgs e)
        {
            checkMax(tbExam, lblExam, 40);
        }

        private void tbActitudes_TextChanged(object sender, EventArgs e)
        {
            checkMax(tbActitudes, lblActitudes, 5);
        }

        private void tbPlatform_TextChanged(object sender, EventArgs e)
        {
            checkMax(tbPlatform, lblPlatform, 30);
        }

        private void tbProduction_TextChanged(object sender, EventArgs e)
        {
            checkMax(tbProduction, lblProduction, 15);
        }

        private void tbActivities_TextChanged(object sender, EventArgs e)
        {
            checkMax(tbActivities, lblActivities, 10);
        }
    }
};