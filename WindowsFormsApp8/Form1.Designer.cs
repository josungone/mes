namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(736, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문관리";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "신규";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "복사";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(659, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "인쇄";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(704, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "도움말";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "회사";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "주문서 등록일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(576, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 21);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "상태";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(60, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 20);
            this.comboBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "최종상태";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(203, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "최종버전";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "전체버전";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "사용유무";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(396, 89);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(72, 20);
            this.comboBox3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "거래처";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 21);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 21);
            this.textBox3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "품목";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(323, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 21);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(385, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 21);
            this.textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(600, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 21);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(538, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 21);
            this.textBox7.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "담당자";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(89, 149);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(124, 21);
            this.textBox9.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "주문서번호";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(27, 421);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(736, 149);
            this.dataGridView2.TabIndex = 37;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Column1";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "목록";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "상세";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 361);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(520, 21);
            this.textBox8.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "합계:";
            // 
            // button11
            // 
            this.button11.Image = global::WindowsFormsApp8.Properties.Resources.refresh;
            this.button11.Location = new System.Drawing.Point(396, 9);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 38);
            this.button11.TabIndex = 36;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::WindowsFormsApp8.Properties.Resources.캡처;
            this.button10.Location = new System.Drawing.Point(655, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 35);
            this.button10.TabIndex = 33;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::WindowsFormsApp8.Properties.Resources.캡처;
            this.button9.Location = new System.Drawing.Point(440, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 35);
            this.button9.TabIndex = 29;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::WindowsFormsApp8.Properties.Resources.캡처;
            this.button8.Location = new System.Drawing.Point(243, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 35);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::WindowsFormsApp8.Properties.Resources.캡처;
            this.button7.Location = new System.Drawing.Point(243, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 35);
            this.button7.TabIndex = 22;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(256, 165);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 43;
            this.button12.Text = "인쇄";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 582);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button12;
    }
}

