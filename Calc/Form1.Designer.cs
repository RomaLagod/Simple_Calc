namespace Calc
{
    partial class f_calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_calc));
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.btn_cool = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_substruct = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_sing = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_separator = new System.Windows.Forms.Button();
            this.btn_rez = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_triada = new System.Windows.Forms.CheckBox();
            this.rbtn_grad = new System.Windows.Forms.RadioButton();
            this.rbtn_rad = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_data
            // 
            this.tb_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_data.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_data.Location = new System.Drawing.Point(0, 0);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(309, 20);
            this.tb_data.TabIndex = 0;
            this.tb_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.tb_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.SystemColors.Window;
            this.tb_input.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_input.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input.Location = new System.Drawing.Point(0, 20);
            this.tb_input.Name = "tb_input";
            this.tb_input.ReadOnly = true;
            this.tb_input.Size = new System.Drawing.Size(309, 37);
            this.tb_input.TabIndex = 1;
            this.tb_input.Tag = "1";
            this.tb_input.Text = "0";
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_input.ModifiedChanged += new System.EventHandler(this.tb_input_ModifiedChanged);
            this.tb_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.tb_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mode.Location = new System.Drawing.Point(2, 60);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(71, 13);
            this.lbl_mode.TabIndex = 2;
            this.lbl_mode.Text = "Mode: Simple";
            // 
            // btn_cool
            // 
            this.btn_cool.Location = new System.Drawing.Point(195, 58);
            this.btn_cool.Name = "btn_cool";
            this.btn_cool.Size = new System.Drawing.Size(32, 23);
            this.btn_cool.TabIndex = 3;
            this.btn_cool.Tag = "1";
            this.btn_cool.Text = ">>";
            this.btn_cool.UseVisualStyleBackColor = true;
            this.btn_cool.Click += new System.EventHandler(this.btn_cool_Click);
            this.btn_cool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_cool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            this.btn_cool.MouseHover += new System.EventHandler(this.btn_cool_MouseHover);
            // 
            // btn_ce
            // 
            this.btn_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ce.Location = new System.Drawing.Point(5, 87);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(51, 43);
            this.btn_ce.TabIndex = 4;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            this.btn_ce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_ce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_c.Location = new System.Drawing.Point(62, 87);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(51, 43);
            this.btn_c.TabIndex = 5;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            this.btn_c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(119, 87);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(51, 43);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "←";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            this.btn_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_del.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_divide.Location = new System.Drawing.Point(176, 87);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(51, 43);
            this.btn_divide.TabIndex = 7;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            this.btn_divide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_divide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_seven.Location = new System.Drawing.Point(5, 136);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(51, 43);
            this.btn_seven.TabIndex = 8;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            this.btn_seven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_eight.Location = new System.Drawing.Point(62, 136);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(52, 43);
            this.btn_eight.TabIndex = 9;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            this.btn_eight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_nine.Location = new System.Drawing.Point(119, 137);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(51, 42);
            this.btn_nine.TabIndex = 10;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            this.btn_nine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_multiply.Location = new System.Drawing.Point(176, 137);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(51, 42);
            this.btn_multiply.TabIndex = 11;
            this.btn_multiply.Text = "x";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            this.btn_multiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_four.Location = new System.Drawing.Point(5, 185);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(51, 43);
            this.btn_four.TabIndex = 12;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            this.btn_four.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_five.Location = new System.Drawing.Point(62, 185);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(52, 43);
            this.btn_five.TabIndex = 13;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            this.btn_five.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_six.Location = new System.Drawing.Point(119, 185);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(51, 43);
            this.btn_six.TabIndex = 14;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            this.btn_six.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_substruct
            // 
            this.btn_substruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_substruct.Location = new System.Drawing.Point(176, 185);
            this.btn_substruct.Name = "btn_substruct";
            this.btn_substruct.Size = new System.Drawing.Size(51, 43);
            this.btn_substruct.TabIndex = 15;
            this.btn_substruct.Text = "-";
            this.btn_substruct.UseVisualStyleBackColor = true;
            this.btn_substruct.Click += new System.EventHandler(this.btn_substruct_Click);
            this.btn_substruct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_substruct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_three.Location = new System.Drawing.Point(5, 234);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(51, 43);
            this.btn_three.TabIndex = 16;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            this.btn_three.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_two.Location = new System.Drawing.Point(62, 234);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(52, 43);
            this.btn_two.TabIndex = 17;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            this.btn_two.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_one.Location = new System.Drawing.Point(119, 234);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(51, 43);
            this.btn_one.TabIndex = 18;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            this.btn_one.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.Location = new System.Drawing.Point(176, 234);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(51, 43);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            this.btn_plus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_sing
            // 
            this.btn_sing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sing.Location = new System.Drawing.Point(5, 283);
            this.btn_sing.Name = "btn_sing";
            this.btn_sing.Size = new System.Drawing.Size(51, 43);
            this.btn_sing.TabIndex = 20;
            this.btn_sing.Text = "±";
            this.btn_sing.UseVisualStyleBackColor = true;
            this.btn_sing.Click += new System.EventHandler(this.btn_sing_Click);
            this.btn_sing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_sing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zero.Location = new System.Drawing.Point(62, 283);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(52, 43);
            this.btn_zero.TabIndex = 21;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            this.btn_zero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_separator
            // 
            this.btn_separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_separator.Location = new System.Drawing.Point(119, 283);
            this.btn_separator.Name = "btn_separator";
            this.btn_separator.Size = new System.Drawing.Size(51, 43);
            this.btn_separator.TabIndex = 22;
            this.btn_separator.Text = ",";
            this.btn_separator.UseVisualStyleBackColor = true;
            this.btn_separator.Click += new System.EventHandler(this.btn_separator_Click);
            this.btn_separator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_separator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_rez
            // 
            this.btn_rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rez.Location = new System.Drawing.Point(176, 283);
            this.btn_rez.Name = "btn_rez";
            this.btn_rez.Size = new System.Drawing.Size(51, 43);
            this.btn_rez.TabIndex = 23;
            this.btn_rez.Tag = "";
            this.btn_rez.Text = "=";
            this.btn_rez.UseVisualStyleBackColor = true;
            this.btn_rez.Click += new System.EventHandler(this.btn_rez_Click);
            this.btn_rez.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_rez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_sin
            // 
            this.btn_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sin.Location = new System.Drawing.Point(244, 185);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(51, 42);
            this.btn_sin.TabIndex = 24;
            this.btn_sin.Text = "SIN";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            this.btn_sin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_sin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_cos
            // 
            this.btn_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cos.Location = new System.Drawing.Point(244, 233);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(51, 43);
            this.btn_cos.TabIndex = 25;
            this.btn_cos.Text = "COS";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            this.btn_cos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_cos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // btn_tan
            // 
            this.btn_tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_tan.Location = new System.Drawing.Point(244, 282);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(51, 43);
            this.btn_tan.TabIndex = 26;
            this.btn_tan.Text = "TAN";
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
            this.btn_tan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.btn_tan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_rad);
            this.groupBox1.Controls.Add(this.rbtn_grad);
            this.groupBox1.Location = new System.Drawing.Point(233, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(69, 68);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // cb_triada
            // 
            this.cb_triada.AutoSize = true;
            this.cb_triada.Location = new System.Drawing.Point(238, 161);
            this.cb_triada.Name = "cb_triada";
            this.cb_triada.Size = new System.Drawing.Size(59, 17);
            this.cb_triada.TabIndex = 28;
            this.cb_triada.Text = "Тріади";
            this.cb_triada.UseVisualStyleBackColor = true;
            this.cb_triada.CheckedChanged += new System.EventHandler(this.cb_triada_CheckedChanged);
            this.cb_triada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.cb_triada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // rbtn_grad
            // 
            this.rbtn_grad.AutoSize = true;
            this.rbtn_grad.Checked = true;
            this.rbtn_grad.Location = new System.Drawing.Point(7, 18);
            this.rbtn_grad.Name = "rbtn_grad";
            this.rbtn_grad.Size = new System.Drawing.Size(56, 17);
            this.rbtn_grad.TabIndex = 0;
            this.rbtn_grad.TabStop = true;
            this.rbtn_grad.Text = "GRAD";
            this.rbtn_grad.UseVisualStyleBackColor = true;
            this.rbtn_grad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.rbtn_grad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // rbtn_rad
            // 
            this.rbtn_rad.AutoSize = true;
            this.rbtn_rad.Location = new System.Drawing.Point(7, 42);
            this.rbtn_rad.Name = "rbtn_rad";
            this.rbtn_rad.Size = new System.Drawing.Size(48, 17);
            this.rbtn_rad.TabIndex = 1;
            this.rbtn_rad.Text = "RAD";
            this.rbtn_rad.UseVisualStyleBackColor = true;
            this.rbtn_rad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.rbtn_rad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            // 
            // f_calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 333);
            this.Controls.Add(this.cb_triada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_rez);
            this.Controls.Add(this.btn_separator);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_sing);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_substruct);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_cool);
            this.Controls.Add(this.lbl_mode);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.tb_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "f_calc";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_calc_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_calc_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Button btn_cool;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_substruct;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_sing;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_separator;
        private System.Windows.Forms.Button btn_rez;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_rad;
        private System.Windows.Forms.RadioButton rbtn_grad;
        private System.Windows.Forms.CheckBox cb_triada;
    }
}

