using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tb_savingsyearly_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_ms_TextChanged(object sender, EventArgs e)
        {
            this.tb_savingsaccount.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_income.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_expenses.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_ms.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_savingsyearly.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg1.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg2.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg3.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg4.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);

            String A = tb_savingsaccount.Text;
            String B = tb_income.Text;
            String C = tb_expenses.Text;
            String D = tb_sg.Text;
            String E = tb_ms.Text;
            String F = tb_savingsyearly.Text;
            String G = tb_sg1.Text;
            String H = tb_sg2.Text;
            String I = tb_sg3.Text;
            String J = tb_sg4.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);

            //String AdditionTotal = (QQ - (AA + BB + CC + DD + EE + FF + GG + HH + II + JJ)).ToString();
            String YearlySavings = (EE * 12).ToString();

            //tb_total.Text = AdditionTotal;
            tb_savingsyearly.Text = YearlySavings;
        }

        private void tb_sg_TextChanged(object sender, EventArgs e)
        {
            this.tb_savingsaccount.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_income.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_expenses.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_ms.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_savingsyearly.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg1.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg2.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg3.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg4.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);

            String A = tb_savingsaccount.Text;
            String B = tb_income.Text;
            String C = tb_expenses.Text;
            String D = tb_sg.Text;
            String E = tb_ms.Text;
            String F = tb_savingsyearly.Text;
            String G = tb_sg1.Text;
            String H = tb_sg2.Text;
            String I = tb_sg3.Text;
            String J = tb_sg4.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);

            //String AdditionTotal = (QQ - (AA + BB + CC + DD + EE + FF + GG + HH + II + JJ)).ToString();

            String ExpInc2 = (BB - CC).ToString();

            //convert string to int
            int intMonthlySavings = Int32.Parse(ExpInc2);

            String SavingGoal4 = (DD - AA - EE - intMonthlySavings).ToString();
            int intSavingGoal4 = Int32.Parse(SavingGoal4);

            String SavingGoal3 = ((intSavingGoal4 / 2) + (intSavingGoal4 / 4)).ToString();
            int intSavingGoal3 = Int32.Parse(SavingGoal3);

            String SavingGoal1 = (intSavingGoal4 / 4).ToString();

            int intSavingGoal1 = Int32.Parse(SavingGoal1);
            String SavingGoal2 = (intSavingGoal4 / 2).ToString();

            int intSavingGoal2 = Int32.Parse(SavingGoal1);


            tb_sg1.Text = SavingGoal1;
            tb_sg2.Text = SavingGoal2;
            tb_sg3.Text = SavingGoal3;
            tb_sg4.Text = SavingGoal4;
        }

        private void tb_income_TextChanged(object sender, EventArgs e)
        {
            this.tb_savingsaccount.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_income.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_expenses.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_ms.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_savingsyearly.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg1.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg2.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg3.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg4.TextChanged += new EventHandler(tb_ms_TextChanged);

            String A = tb_savingsaccount.Text;
            String B = tb_income.Text;
            String C = tb_expenses.Text;
            String D = tb_sg.Text;
            String E = tb_ms.Text;
            String F = tb_savingsyearly.Text;
            String G = tb_sg1.Text;
            String H = tb_sg2.Text;
            String I = tb_sg3.Text;
            String J = tb_sg4.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);

            //income is BB
            //expenses is CC

            //sub expenses from income then convert to string
            String ExpInc = ((BB - CC)/10).ToString();

            //convert string to int
            int intMonthlySavings = Int32.Parse(ExpInc);

            //convert int to string for the textbox
            String MonthlySavings = intMonthlySavings.ToString();
            //change monthly cost textboxt the answer
            tb_ms.Text = MonthlySavings;
        }

        private void tb_expenses_TextChanged(object sender, EventArgs e)
        {
            this.tb_savingsaccount.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_income.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_expenses.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_ms.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_savingsyearly.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg1.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg2.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg3.TextChanged += new EventHandler(tb_ms_TextChanged);
            this.tb_sg4.TextChanged += new EventHandler(tb_ms_TextChanged);

            String A = tb_savingsaccount.Text;
            String B = tb_income.Text;
            String C = tb_expenses.Text;
            String D = tb_sg.Text;
            String E = tb_ms.Text;
            String F = tb_savingsyearly.Text;
            String G = tb_sg1.Text;
            String H = tb_sg2.Text;
            String I = tb_sg3.Text;
            String J = tb_sg4.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);

            //income is BB
            //expenses is CC

            //sub expenses from income then convert to string
            String ExpInc = ((BB - CC) / 10).ToString();

            //convert string to int
            int intMonthlySavings = Int32.Parse(ExpInc);

            //convert int to string for the textbox
            String MonthlySavings = intMonthlySavings.ToString();
            //change monthly cost textboxt the answer
            tb_ms.Text = MonthlySavings;
        }

        private void tb_savingsaccount_TextChanged(object sender, EventArgs e)
        {
            this.tb_savingsaccount.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_income.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_expenses.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_ms.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_savingsyearly.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg1.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg2.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg3.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);
            this.tb_sg4.TextChanged += new EventHandler(tb_savingsyearly_TextChanged);

            String A = tb_savingsaccount.Text;
            String B = tb_income.Text;
            String C = tb_expenses.Text;
            String D = tb_sg.Text;
            String E = tb_ms.Text;
            String F = tb_savingsyearly.Text;
            String G = tb_sg1.Text;
            String H = tb_sg2.Text;
            String I = tb_sg3.Text;
            String J = tb_sg4.Text;

            int AA = Int32.Parse(A);
            int BB = Int32.Parse(B);
            int CC = Int32.Parse(C);
            int DD = Int32.Parse(D);
            int EE = Int32.Parse(E);
            int FF = Int32.Parse(F);
            int GG = Int32.Parse(G);
            int HH = Int32.Parse(H);
            int II = Int32.Parse(I);
            int JJ = Int32.Parse(J);

            //String AdditionTotal = (QQ - (AA + BB + CC + DD + EE + FF + GG + HH + II + JJ)).ToString();

            String ExpInc2 = (BB - CC).ToString();

            //convert string to int
            int intMonthlySavings = Int32.Parse(ExpInc2);

            String SavingGoal4 = (DD - AA - EE - intMonthlySavings).ToString();
            int intSavingGoal4 = Int32.Parse(SavingGoal4);

            String SavingGoal3 = ((intSavingGoal4 / 2) + (intSavingGoal4 / 4)).ToString();
            int intSavingGoal3 = Int32.Parse(SavingGoal3);

            String SavingGoal1 = (intSavingGoal4 / 4).ToString();

            int intSavingGoal1 = Int32.Parse(SavingGoal1);
            String SavingGoal2 = (intSavingGoal4 / 2).ToString();

            int intSavingGoal2 = Int32.Parse(SavingGoal1);


            tb_sg1.Text = SavingGoal1;
            tb_sg2.Text = SavingGoal2;
            tb_sg3.Text = SavingGoal3;
            tb_sg4.Text = SavingGoal4;
        }
    }
}