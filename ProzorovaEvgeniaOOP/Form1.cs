using System;

namespace ProzorovaEvgeniaOOP
{
    public partial class MainForm : Form
    {
        DBConnector connector;
        Account? account = null;
        Matrix matrix;

        List<TextBox> coefficients;
        List<TextBox> freeMembers;
        public MainForm()
        {
            InitializeComponent();

            this.connector = new DBConnector("(localdb)\\mssqllocaldb", "ProzorovaEvgeniaOOP");

            SignInToolStripMenuItem.Visible = true;
            SignUpToolStripMenuItem.Visible = true;
            AccountInfoToolStripMenuItem.Visible = false;

            List<TextBox> textBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    textBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                    textBoxes.Add((TextBox)Controls.Find("b" + i.ToString(), true)[0]);
                }
            }
            foreach (TextBox textBox in textBoxes)
            {
                textBox_SetText(textBox);
            }
        }

        private void SignIn(object sender, EventArgs e)
        {
            this.account = this.connector.SelectAccount("Name", this.NameSignIn.Text);
            if (this.account != null)
            {
                SignInToolStripMenuItem.Visible = false;
                SignUpToolStripMenuItem.Visible = false;
                AccountInfoToolStripMenuItem.Visible = true;
                AccountInfoToolStripMenuItem.Text = $"ID: {this.account.Id} {this.account.Name}";
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не существует!", "Ошибочка!", MessageBoxButtons.OKCancel);
            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            if (!this.connector.CheckAccount("Name", NameSighUp.Text))
            {
                this.account = this.connector.InsertAccount(NameSighUp.Text, PasswordSignUp.Text);
                SignInToolStripMenuItem.Visible = false;
                SignUpToolStripMenuItem.Visible = false;
                AccountInfoToolStripMenuItem.Visible = true;
                AccountInfoToolStripMenuItem.Text = $"ID: {this.account.Id} {this.account.Name}";
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными уже существует!", "Ошибочка!", MessageBoxButtons.OKCancel);

            }
        }

        private Matrix InitializeMatrix()
        {
            this.coefficients = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    this.coefficients.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            this.freeMembers = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                string index = i.ToString();
                this.coefficients.Add((TextBox)Controls.Find("b" + i.ToString(), true)[0]);
            }
            double[,] coeff = new double[4, 4];
            double[] freeMemb = new double[4];
            int z = 0, k = 0;
            foreach (TextBox textBox in this.coefficients)
            {
                coeff[z, k] = Double.Parse(textBox.Text);
                if (k == 3)
                {
                    k = 0;
                    z++;
                }
                k++;
            }
            k = 0;
            foreach (TextBox textBox in this.freeMembers)
            {
                freeMemb[z] = Double.Parse(textBox.Text);
                k++;
            }
            return new Matrix(coeff, freeMemb);
        }

        private void ToSolveButton_Click(object sender, EventArgs e)
        {
            if (this.account != null)
            {
                matrix = InitializeMatrix();
                double[] result = matrix.ZeidelMethod();
                string result_str = $"x1 = {result[0]}, x2 = {result[1]}, x3 = {result[2]}";
                MessageBox.Show(result_str, "А вот и ответ!", MessageBoxButtons.OKCancel);
                this.connector.InsertMatrix(this.account.Id, this.matrix.ToString(), result_str);
            }
            else
            {
                MessageBox.Show("Чтобы решить СЛАУ, неоходимо сначала зарегестрироваться/войти!", "Ошибочка!", MessageBoxButtons.OKCancel);
            }
        }
        protected void textBox_SetText(TextBox textBox)
        {

            textBox.Text = "0";
            textBox.ForeColor = Color.Gray;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (textBox.ForeColor == Color.Black)
                return;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (textBox.Text.Trim() == "")
                textBox_SetText(textBox);
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}