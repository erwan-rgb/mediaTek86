namespace mediaTek86.View
{
    partial class form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            vScrollBar1 = new VScrollBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Ajouter = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Ajouter.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(604, 247);
            dataGridView1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(590, 12);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 247);
            vScrollBar1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(312, 265);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Absence";
            button4.UseVisualStyleBackColor = true;
            // 
            // Ajouter
            // 
            Ajouter.Controls.Add(listBox1);
            Ajouter.Controls.Add(button5);
            Ajouter.Controls.Add(textBox4);
            Ajouter.Controls.Add(textBox3);
            Ajouter.Controls.Add(textBox2);
            Ajouter.Controls.Add(textBox1);
            Ajouter.Controls.Add(label5);
            Ajouter.Controls.Add(label4);
            Ajouter.Controls.Add(label3);
            Ajouter.Controls.Add(label2);
            Ajouter.Controls.Add(label1);
            Ajouter.Location = new Point(12, 349);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(294, 349);
            Ajouter.TabIndex = 6;
            Ajouter.TabStop = false;
            Ajouter.Text = "Ajouter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "prénom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 114);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "tel : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 157);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "mail :";
            label4.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 203);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Affectation :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(98, 187);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 84);
            listBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(329, 362);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 336);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modification";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 0;
            label6.Text = "nom :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 1;
            label7.Text = "prénom :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 98);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 2;
            label8.Text = "tel :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 141);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 3;
            label9.Text = "mail :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 187);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 4;
            label10.Text = "Affectation :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(109, 63);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(109, 98);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(109, 134);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(109, 171);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(125, 84);
            listBox2.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(178, 290);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "enregistrer";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(166, 277);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "enregistrer";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(14, 720);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 188);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajouter une absence";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker4);
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(329, 720);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 188);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modifier une absence";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 32);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 0;
            label11.Text = "date début :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 68);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 0;
            label12.Text = "date fin :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 109);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 1;
            label13.Text = "Motif :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 32);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 0;
            label14.Text = "date début :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 65);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 1;
            label15.Text = "date fin :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 105);
            label16.Name = "label16";
            label16.Size = new Size(56, 20);
            label16.TabIndex = 2;
            label16.Text = "Motif : ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(102, 102);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(158, 27);
            textBox9.TabIndex = 3;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(100, 102);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(156, 27);
            textBox10.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(192, 142);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "enregistrer";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(180, 142);
            button8.Name = "button8";
            button8.Size = new Size(91, 29);
            button8.TabIndex = 4;
            button8.Text = "enregistrer";
            button8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(100, 65);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(156, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(102, 32);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(158, 27);
            dateTimePicker3.TabIndex = 5;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(102, 65);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(158, 27);
            dateTimePicker4.TabIndex = 6;
            // 
            // button9
            // 
            button9.Location = new Point(412, 265);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 10;
            button9.Text = "Annuler";
            button9.UseVisualStyleBackColor = true;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 939);
            Controls.Add(button9);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Ajouter);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(vScrollBar1);
            Controls.Add(dataGridView1);
            Name = "form2";
            Text = "form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Ajouter.ResumeLayout(false);
            Ajouter.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox Ajouter;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label16;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Button button7;
        private TextBox textBox10;
        private Button button8;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Button button9;
    }
}