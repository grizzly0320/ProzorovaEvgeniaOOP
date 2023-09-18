namespace ProzorovaEvgeniaOOP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            SignInToolStripMenuItem = new ToolStripMenuItem();
            NameSignIn = new ToolStripTextBox();
            PasswordSignIn = new ToolStripTextBox();
            SignInButton = new ToolStripMenuItem();
            SignUpToolStripMenuItem = new ToolStripMenuItem();
            NameSighUp = new ToolStripTextBox();
            PasswordSignUp = new ToolStripTextBox();
            SignUpButton = new ToolStripMenuItem();
            AccountInfoToolStripMenuItem = new ToolStripMenuItem();
            ToSolveButton = new Button();
            panel1 = new Panel();
            b3 = new TextBox();
            label7 = new Label();
            a33 = new TextBox();
            label8 = new Label();
            a32 = new TextBox();
            label9 = new Label();
            a31 = new TextBox();
            b2 = new TextBox();
            label4 = new Label();
            a23 = new TextBox();
            label5 = new Label();
            a22 = new TextBox();
            label6 = new Label();
            a21 = new TextBox();
            b1 = new TextBox();
            label3 = new Label();
            a13 = new TextBox();
            label2 = new Label();
            a12 = new TextBox();
            label1 = new Label();
            a11 = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { SignInToolStripMenuItem, SignUpToolStripMenuItem, AccountInfoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(708, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // SignInToolStripMenuItem
            // 
            SignInToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NameSignIn, PasswordSignIn, SignInButton });
            SignInToolStripMenuItem.Name = "SignInToolStripMenuItem";
            SignInToolStripMenuItem.Size = new Size(56, 24);
            SignInToolStripMenuItem.Text = "Вход";
            // 
            // NameSignIn
            // 
            NameSignIn.Name = "NameSignIn";
            NameSignIn.Size = new Size(224, 27);
            NameSignIn.Text = "Имя";
            // 
            // PasswordSignIn
            // 
            PasswordSignIn.Name = "PasswordSignIn";
            PasswordSignIn.Size = new Size(298, 27);
            PasswordSignIn.Text = "Пароль";
            // 
            // SignInButton
            // 
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(372, 26);
            SignInButton.Text = "Войти";
            SignInButton.Click += SignIn;
            // 
            // SignUpToolStripMenuItem
            // 
            SignUpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NameSighUp, PasswordSignUp, SignUpButton });
            SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem";
            SignUpToolStripMenuItem.Size = new Size(110, 24);
            SignUpToolStripMenuItem.Text = "Регистрация";
            // 
            // NameSighUp
            // 
            NameSighUp.Name = "NameSighUp";
            NameSighUp.Size = new Size(233, 27);
            NameSighUp.Text = "Имя";
            // 
            // PasswordSignUp
            // 
            PasswordSignUp.Name = "PasswordSignUp";
            PasswordSignUp.Size = new Size(307, 27);
            PasswordSignUp.Text = "Пароль";
            // 
            // SignUpButton
            // 
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(381, 26);
            SignUpButton.Text = "Зарегестрироваться";
            SignUpButton.Click += SignUp;
            // 
            // AccountInfoToolStripMenuItem
            // 
            AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem";
            AccountInfoToolStripMenuItem.Size = new Size(196, 24);
            AccountInfoToolStripMenuItem.Text = "ID: 123 Prozorova Evgenia";
            // 
            // ToSolveButton
            // 
            ToSolveButton.Location = new Point(583, 59);
            ToSolveButton.Name = "ToSolveButton";
            ToSolveButton.Size = new Size(94, 101);
            ToSolveButton.TabIndex = 2;
            ToSolveButton.Text = "Решить";
            ToSolveButton.UseVisualStyleBackColor = true;
            ToSolveButton.Click += ToSolveButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(b3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(a33);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(a32);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(a31);
            panel1.Controls.Add(b2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(a23);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(a22);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(a21);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(a13);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(a12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(a11);
            panel1.Location = new Point(59, 59);
            panel1.Margin = new Padding(50);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 101);
            panel1.TabIndex = 4;
            // 
            // b3
            // 
            b3.Location = new Point(411, 69);
            b3.Name = "b3";
            b3.Size = new Size(75, 27);
            b3.TabIndex = 20;
            b3.Enter += textBox_Enter;
            b3.KeyPress += textBox_KeyPress;
            b3.Leave += textBox_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(356, 71);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 19;
            label7.Text = "x3 = ";
            // 
            // a33
            // 
            a33.Location = new Point(275, 69);
            a33.Name = "a33";
            a33.Size = new Size(75, 27);
            a33.TabIndex = 18;
            a33.Enter += textBox_Enter;
            a33.KeyPress += textBox_KeyPress;
            a33.Leave += textBox_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(220, 71);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 17;
            label8.Text = "x2 + ";
            // 
            // a32
            // 
            a32.Location = new Point(139, 69);
            a32.Name = "a32";
            a32.Size = new Size(75, 27);
            a32.TabIndex = 16;
            a32.Enter += textBox_Enter;
            a32.KeyPress += textBox_KeyPress;
            a32.Leave += textBox_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(84, 70);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 15;
            label9.Text = "x1 + ";
            // 
            // a31
            // 
            a31.Location = new Point(3, 70);
            a31.Name = "a31";
            a31.Size = new Size(75, 27);
            a31.TabIndex = 14;
            a31.Enter += textBox_Enter;
            a31.KeyPress += textBox_KeyPress;
            a31.Leave += textBox_Leave;
            // 
            // b2
            // 
            b2.Location = new Point(411, 36);
            b2.Name = "b2";
            b2.Size = new Size(75, 27);
            b2.TabIndex = 13;
            b2.Enter += textBox_Enter;
            b2.KeyPress += textBox_KeyPress;
            b2.Leave += textBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(356, 38);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 12;
            label4.Text = "x3 = ";
            // 
            // a23
            // 
            a23.Location = new Point(275, 36);
            a23.Name = "a23";
            a23.Size = new Size(75, 27);
            a23.TabIndex = 11;
            a23.Enter += textBox_Enter;
            a23.KeyPress += textBox_KeyPress;
            a23.Leave += textBox_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(220, 38);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 10;
            label5.Text = "x2 + ";
            // 
            // a22
            // 
            a22.Location = new Point(139, 36);
            a22.Name = "a22";
            a22.Size = new Size(75, 27);
            a22.TabIndex = 9;
            a22.Enter += textBox_Enter;
            a22.KeyPress += textBox_KeyPress;
            a22.Leave += textBox_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(84, 37);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 8;
            label6.Text = "x1 + ";
            // 
            // a21
            // 
            a21.Location = new Point(3, 37);
            a21.Name = "a21";
            a21.Size = new Size(75, 27);
            a21.TabIndex = 7;
            a21.Enter += textBox_Enter;
            a21.KeyPress += textBox_KeyPress;
            a21.Leave += textBox_Leave;
            // 
            // b1
            // 
            b1.Location = new Point(411, 3);
            b1.Name = "b1";
            b1.Size = new Size(75, 27);
            b1.TabIndex = 6;
            b1.Enter += textBox_Enter;
            b1.KeyPress += textBox_KeyPress;
            b1.Leave += textBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(356, 5);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 5;
            label3.Text = "x3 = ";
            // 
            // a13
            // 
            a13.Location = new Point(275, 3);
            a13.Name = "a13";
            a13.Size = new Size(75, 27);
            a13.TabIndex = 4;
            a13.Enter += textBox_Enter;
            a13.KeyPress += textBox_KeyPress;
            a13.Leave += textBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 5);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 3;
            label2.Text = "x2 + ";
            // 
            // a12
            // 
            a12.Location = new Point(139, 3);
            a12.Name = "a12";
            a12.Size = new Size(75, 27);
            a12.TabIndex = 2;
            a12.Enter += textBox_Enter;
            a12.KeyPress += textBox_KeyPress;
            a12.Leave += textBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 4);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 1;
            label1.Text = "x1 + ";
            // 
            // a11
            // 
            a11.Location = new Point(3, 4);
            a11.Name = "a11";
            a11.Size = new Size(75, 27);
            a11.TabIndex = 0;
            a11.Enter += textBox_Enter;
            a11.KeyPress += textBox_KeyPress;
            a11.Leave += textBox_Leave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 187);
            Controls.Add(panel1);
            Controls.Add(ToSolveButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SignInToolStripMenuItem;
        private ToolStripMenuItem SignUpToolStripMenuItem;
        private Button ToSolveButton;
        private ToolStripTextBox NameSignIn;
        private ToolStripTextBox PasswordSignIn;
        private ToolStripMenuItem SignInButton;
        private ToolStripMenuItem AccountInfoToolStripMenuItem;
        private ToolStripMenuItem SignUpButton;
        private ToolStripTextBox NameSighUp;
        private ToolStripTextBox PasswordSignUp;
        private Panel panel1;
        private TextBox a11;
        private Label label1;
        private TextBox b3;
        private Label label7;
        private TextBox a33;
        private Label label8;
        private TextBox a32;
        private Label label9;
        private TextBox a31;
        private TextBox b2;
        private Label label4;
        private TextBox a23;
        private Label label5;
        private TextBox a22;
        private Label label6;
        private TextBox a21;
        private TextBox b1;
        private Label label3;
        private TextBox a13;
        private Label label2;
        private TextBox a12;
    }
}