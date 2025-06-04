
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
            btnAjouter = new Button();
            btnModifer = new Button();
            btnSupprimer = new Button();
            btnAbsence = new Button();
            Ajouter = new GroupBox();
            lstAffectationAjouter = new ListBox();
            btnEnregistrerAjouter = new Button();
            txtMailAjouter = new TextBox();
            txtTelAjouter = new TextBox();
            txtPrenomAjouter = new TextBox();
            txtNomAjouter = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnEnregistrerModification = new Button();
            lstAffectationModification = new ListBox();
            txtMailModification = new TextBox();
            txtTelModification = new TextBox();
            txtPrenomModification = new TextBox();
            txtNomModification = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dtpDateFinAjout = new DateTimePicker();
            dtpDateDebAjout = new DateTimePicker();
            btnEnregistrerAjoutAbs = new Button();
            txtMotifAjout = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            dtpDateFinModif = new DateTimePicker();
            dtpDateDebModif = new DateTimePicker();
            btnEnregistrerModifAbs = new Button();
            txtMotifModif = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            btnAnnuler = new Button();
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
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 265);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += button1_Click;
            // 
            // btnModifer
            // 
            btnModifer.Location = new Point(112, 265);
            btnModifer.Name = "btnModifer";
            btnModifer.Size = new Size(94, 29);
            btnModifer.TabIndex = 3;
            btnModifer.Text = "Modifier";
            btnModifer.UseVisualStyleBackColor = true;
            btnModifer.Click += button2_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(212, 265);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 4;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAbsence
            // 
            btnAbsence.Location = new Point(312, 265);
            btnAbsence.Name = "btnAbsence";
            btnAbsence.Size = new Size(94, 29);
            btnAbsence.TabIndex = 5;
            btnAbsence.Text = "Absence";
            btnAbsence.UseVisualStyleBackColor = true;
            btnAbsence.Click += btnAbsence_Click;
            // 
            // Ajouter
            // 
            Ajouter.Controls.Add(lstAffectationAjouter);
            Ajouter.Controls.Add(btnEnregistrerAjouter);
            Ajouter.Controls.Add(txtMailAjouter);
            Ajouter.Controls.Add(txtTelAjouter);
            Ajouter.Controls.Add(txtPrenomAjouter);
            Ajouter.Controls.Add(txtNomAjouter);
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
            // lstAffectationAjouter
            // 
            lstAffectationAjouter.FormattingEnabled = true;
            lstAffectationAjouter.Location = new Point(98, 187);
            lstAffectationAjouter.Name = "lstAffectationAjouter";
            lstAffectationAjouter.Size = new Size(125, 84);
            lstAffectationAjouter.TabIndex = 9;
            lstAffectationAjouter.SelectedIndexChanged += lstAffectationAjouter_SelectedIndexChanged;
            // 
            // btnEnregistrerAjouter
            // 
            btnEnregistrerAjouter.Location = new Point(178, 290);
            btnEnregistrerAjouter.Name = "btnEnregistrerAjouter";
            btnEnregistrerAjouter.Size = new Size(94, 29);
            btnEnregistrerAjouter.TabIndex = 10;
            btnEnregistrerAjouter.Text = "enregistrer";
            btnEnregistrerAjouter.UseVisualStyleBackColor = true;
            // 
            // txtMailAjouter
            // 
            txtMailAjouter.Location = new Point(98, 154);
            txtMailAjouter.Name = "txtMailAjouter";
            txtMailAjouter.Size = new Size(125, 27);
            txtMailAjouter.TabIndex = 8;
            // 
            // txtTelAjouter
            // 
            txtTelAjouter.Location = new Point(98, 114);
            txtTelAjouter.Name = "txtTelAjouter";
            txtTelAjouter.Size = new Size(125, 27);
            txtTelAjouter.TabIndex = 7;
            // 
            // txtPrenomAjouter
            // 
            txtPrenomAjouter.Location = new Point(98, 72);
            txtPrenomAjouter.Name = "txtPrenomAjouter";
            txtPrenomAjouter.Size = new Size(125, 27);
            txtPrenomAjouter.TabIndex = 6;
            // 
            // txtNomAjouter
            // 
            txtNomAjouter.Location = new Point(98, 33);
            txtNomAjouter.Name = "txtNomAjouter";
            txtNomAjouter.Size = new Size(125, 27);
            txtNomAjouter.TabIndex = 5;
            txtNomAjouter.TextChanged += txtNomAjouter_TextChanged;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 157);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "mail :";
            label4.Click += label4_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "prénom :";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnregistrerModification);
            groupBox1.Controls.Add(lstAffectationModification);
            groupBox1.Controls.Add(txtMailModification);
            groupBox1.Controls.Add(txtTelModification);
            groupBox1.Controls.Add(txtPrenomModification);
            groupBox1.Controls.Add(txtNomModification);
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
            // btnEnregistrerModification
            // 
            btnEnregistrerModification.Location = new Point(166, 277);
            btnEnregistrerModification.Name = "btnEnregistrerModification";
            btnEnregistrerModification.Size = new Size(94, 29);
            btnEnregistrerModification.TabIndex = 11;
            btnEnregistrerModification.Text = "enregistrer";
            btnEnregistrerModification.UseVisualStyleBackColor = true;
            btnEnregistrerModification.Click += btnEnregistrerModification_Click;
            // 
            // lstAffectationModification
            // 
            lstAffectationModification.FormattingEnabled = true;
            lstAffectationModification.Location = new Point(109, 171);
            lstAffectationModification.Name = "lstAffectationModification";
            lstAffectationModification.Size = new Size(125, 84);
            lstAffectationModification.TabIndex = 9;
            // 
            // txtMailModification
            // 
            txtMailModification.Location = new Point(109, 134);
            txtMailModification.Name = "txtMailModification";
            txtMailModification.Size = new Size(125, 27);
            txtMailModification.TabIndex = 8;
            txtMailModification.TextChanged += txtMailModification_TextChanged;
            // 
            // txtTelModification
            // 
            txtTelModification.Location = new Point(109, 98);
            txtTelModification.Name = "txtTelModification";
            txtTelModification.Size = new Size(125, 27);
            txtTelModification.TabIndex = 7;
            // 
            // txtPrenomModification
            // 
            txtPrenomModification.Location = new Point(109, 63);
            txtPrenomModification.Name = "txtPrenomModification";
            txtPrenomModification.Size = new Size(125, 27);
            txtPrenomModification.TabIndex = 6;
            // 
            // txtNomModification
            // 
            txtNomModification.Location = new Point(109, 26);
            txtNomModification.Name = "txtNomModification";
            txtNomModification.Size = new Size(125, 27);
            txtNomModification.TabIndex = 5;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 141);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 3;
            label9.Text = "mail :";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 1;
            label7.Text = "prénom :";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDateFinAjout);
            groupBox2.Controls.Add(dtpDateDebAjout);
            groupBox2.Controls.Add(btnEnregistrerAjoutAbs);
            groupBox2.Controls.Add(txtMotifAjout);
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
            // dtpDateFinAjout
            // 
            dtpDateFinAjout.Location = new Point(100, 65);
            dtpDateFinAjout.Name = "dtpDateFinAjout";
            dtpDateFinAjout.Size = new Size(156, 27);
            dtpDateFinAjout.TabIndex = 5;
            // 
            // dtpDateDebAjout
            // 
            dtpDateDebAjout.Location = new Point(100, 32);
            dtpDateDebAjout.Name = "dtpDateDebAjout";
            dtpDateDebAjout.Size = new Size(156, 27);
            dtpDateDebAjout.TabIndex = 4;
            // 
            // btnEnregistrerAjoutAbs
            // 
            btnEnregistrerAjoutAbs.Location = new Point(192, 142);
            btnEnregistrerAjoutAbs.Name = "btnEnregistrerAjoutAbs";
            btnEnregistrerAjoutAbs.Size = new Size(94, 29);
            btnEnregistrerAjoutAbs.TabIndex = 3;
            btnEnregistrerAjoutAbs.Text = "enregistrer";
            btnEnregistrerAjoutAbs.UseVisualStyleBackColor = true;
            btnEnregistrerAjoutAbs.Click += btnEnregistrerAjoutAbs_Click;
            // 
            // txtMotifAjout
            // 
            txtMotifAjout.Location = new Point(100, 102);
            txtMotifAjout.Name = "txtMotifAjout";
            txtMotifAjout.Size = new Size(156, 27);
            txtMotifAjout.TabIndex = 2;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpDateFinModif);
            groupBox3.Controls.Add(dtpDateDebModif);
            groupBox3.Controls.Add(btnEnregistrerModifAbs);
            groupBox3.Controls.Add(txtMotifModif);
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
            // dtpDateFinModif
            // 
            dtpDateFinModif.Location = new Point(102, 65);
            dtpDateFinModif.Name = "dtpDateFinModif";
            dtpDateFinModif.Size = new Size(158, 27);
            dtpDateFinModif.TabIndex = 6;
            // 
            // dtpDateDebModif
            // 
            dtpDateDebModif.Location = new Point(102, 32);
            dtpDateDebModif.Name = "dtpDateDebModif";
            dtpDateDebModif.Size = new Size(158, 27);
            dtpDateDebModif.TabIndex = 5;
            // 
            // btnEnregistrerModifAbs
            // 
            btnEnregistrerModifAbs.Location = new Point(180, 142);
            btnEnregistrerModifAbs.Name = "btnEnregistrerModifAbs";
            btnEnregistrerModifAbs.Size = new Size(91, 29);
            btnEnregistrerModifAbs.TabIndex = 4;
            btnEnregistrerModifAbs.Text = "enregistrer";
            btnEnregistrerModifAbs.UseVisualStyleBackColor = true;
            // 
            // txtMotifModif
            // 
            txtMotifModif.Location = new Point(102, 102);
            txtMotifModif.Name = "txtMotifModif";
            txtMotifModif.Size = new Size(158, 27);
            txtMotifModif.TabIndex = 3;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 65);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 1;
            label15.Text = "date fin :";
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
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(412, 265);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(94, 29);
            btnAnnuler.TabIndex = 10;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 939);
            Controls.Add(btnAnnuler);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Ajouter);
            Controls.Add(btnAbsence);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifer);
            Controls.Add(btnAjouter);
            Controls.Add(vScrollBar1);
            Controls.Add(dataGridView1);
            Name = "form2";
            Text = "form2";
            Load += form2_Load;
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

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
        private Button btnAjouter;
        private Button btnModifer;
        private Button btnSupprimer;
        private Button btnAbsence;
        private GroupBox Ajouter;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMailAjouter;
        private TextBox txtTelAjouter;
        private TextBox txtPrenomAjouter;
        private TextBox txtNomAjouter;
        private ListBox lstAffectationAjouter;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtMailModification;
        private TextBox txtTelModification;
        private TextBox txtPrenomModification;
        private TextBox txtNomModification;
        private ListBox lstAffectationModification;
        private Button btnEnregistrerAjouter;
        private Button btnEnregistrerModification;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label16;
        private Label label15;
        private DateTimePicker dtpDateDebAjout;
        private Button btnEnregistrerAjoutAbs;
        private TextBox txtMotifAjout;
        private Button btnEnregistrerModifAbs;
        private TextBox txtMotifModif;
        private DateTimePicker dtpDateFinAjout;
        private DateTimePicker dtpDateFinModif;
        private DateTimePicker dtpDateDebModif;
        private Button btnAnnuler;
    }
}