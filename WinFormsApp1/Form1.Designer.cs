namespace WinFormsApp1
{
    partial class Form1
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
            lblExam = new Label();
            lblActitudes = new Label();
            lblPlatform = new Label();
            lblActivities = new Label();
            lblProduction = new Label();
            lblLiteral = new Label();
            lblResult = new Label();
            lblScore = new Label();
            tbExam = new TextBox();
            lblExamPersentaje = new Label();
            lblPersentageActitudes = new Label();
            tbActitudes = new TextBox();
            lblPersentagePlatform = new Label();
            tbPlatform = new TextBox();
            lblPersentageProduction = new Label();
            tbProduction = new TextBox();
            lblPersentageActivities = new Label();
            tbActivities = new TextBox();
            tbFinalCalification = new TextBox();
            tbResult = new TextBox();
            tbLiteral = new TextBox();
            btnCalc = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblExam.Location = new Point(146, 73);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(78, 25);
            lblExam.TabIndex = 0;
            lblExam.Text = "Examen";
            // 
            // lblActitudes
            // 
            lblActitudes.AutoSize = true;
            lblActitudes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblActitudes.Location = new Point(146, 106);
            lblActitudes.Name = "lblActitudes";
            lblActitudes.Size = new Size(171, 25);
            lblActitudes.TabIndex = 1;
            lblActitudes.Text = "Actitudes y Valores";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlatform.Location = new Point(146, 138);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(104, 25);
            lblPlatform.TabIndex = 2;
            lblPlatform.Text = "Plataforma";
            // 
            // lblActivities
            // 
            lblActivities.AutoSize = true;
            lblActivities.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivities.Location = new Point(146, 207);
            lblActivities.Name = "lblActivities";
            lblActivities.RightToLeft = RightToLeft.Yes;
            lblActivities.Size = new Size(108, 25);
            lblActivities.TabIndex = 3;
            lblActivities.Text = "Actividades";
            // 
            // lblProduction
            // 
            lblProduction.AutoSize = true;
            lblProduction.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblProduction.Location = new Point(146, 172);
            lblProduction.Name = "lblProduction";
            lblProduction.Size = new Size(168, 25);
            lblProduction.TabIndex = 4;
            lblProduction.Text = "Produccion Escrita";
            // 
            // lblLiteral
            // 
            lblLiteral.AutoSize = true;
            lblLiteral.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiteral.Location = new Point(146, 424);
            lblLiteral.Name = "lblLiteral";
            lblLiteral.Size = new Size(64, 25);
            lblLiteral.TabIndex = 7;
            lblLiteral.Text = "Literal";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(146, 386);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 25);
            lblResult.TabIndex = 6;
            lblResult.Text = "Resultado";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(146, 351);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(155, 25);
            lblScore.TabIndex = 5;
            lblScore.Text = "Calificacion Final";
            // 
            // tbExam
            // 
            tbExam.Location = new Point(230, 71);
            tbExam.Name = "tbExam";
            tbExam.Size = new Size(87, 27);
            tbExam.TabIndex = 8;
            tbExam.TextChanged += tbExam_TextChanged;
            // 
            // lblExamPersentaje
            // 
            lblExamPersentaje.AutoSize = true;
            lblExamPersentaje.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblExamPersentaje.Location = new Point(323, 70);
            lblExamPersentaje.Name = "lblExamPersentaje";
            lblExamPersentaje.Size = new Size(48, 25);
            lblExamPersentaje.TabIndex = 9;
            lblExamPersentaje.Text = "40%";
            // 
            // lblPersentageActitudes
            // 
            lblPersentageActitudes.AutoSize = true;
            lblPersentageActitudes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersentageActitudes.Location = new Point(416, 106);
            lblPersentageActitudes.Name = "lblPersentageActitudes";
            lblPersentageActitudes.Size = new Size(38, 25);
            lblPersentageActitudes.TabIndex = 11;
            lblPersentageActitudes.Text = "5%";
            lblPersentageActitudes.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbActitudes
            // 
            tbActitudes.Location = new Point(323, 107);
            tbActitudes.Name = "tbActitudes";
            tbActitudes.Size = new Size(87, 27);
            tbActitudes.TabIndex = 10;
            tbActitudes.TextChanged += tbActitudes_TextChanged;
            // 
            // lblPersentagePlatform
            // 
            lblPersentagePlatform.AutoSize = true;
            lblPersentagePlatform.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersentagePlatform.Location = new Point(349, 139);
            lblPersentagePlatform.Name = "lblPersentagePlatform";
            lblPersentagePlatform.Size = new Size(48, 25);
            lblPersentagePlatform.TabIndex = 13;
            lblPersentagePlatform.Text = "30%";
            // 
            // tbPlatform
            // 
            tbPlatform.Location = new Point(256, 140);
            tbPlatform.Name = "tbPlatform";
            tbPlatform.Size = new Size(87, 27);
            tbPlatform.TabIndex = 12;
            tbPlatform.TextChanged += tbPlatform_TextChanged;
            // 
            // lblPersentageProduction
            // 
            lblPersentageProduction.AutoSize = true;
            lblPersentageProduction.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersentageProduction.Location = new Point(413, 172);
            lblPersentageProduction.Name = "lblPersentageProduction";
            lblPersentageProduction.Size = new Size(48, 25);
            lblPersentageProduction.TabIndex = 15;
            lblPersentageProduction.Text = "15%";
            // 
            // tbProduction
            // 
            tbProduction.Location = new Point(320, 173);
            tbProduction.Name = "tbProduction";
            tbProduction.Size = new Size(87, 27);
            tbProduction.TabIndex = 14;
            tbProduction.TextChanged += tbProduction_TextChanged;
            // 
            // lblPersentageActivities
            // 
            lblPersentageActivities.AutoSize = true;
            lblPersentageActivities.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersentageActivities.Location = new Point(353, 207);
            lblPersentageActivities.Name = "lblPersentageActivities";
            lblPersentageActivities.Size = new Size(48, 25);
            lblPersentageActivities.TabIndex = 17;
            lblPersentageActivities.Text = "10%";
            // 
            // tbActivities
            // 
            tbActivities.Location = new Point(260, 208);
            tbActivities.Name = "tbActivities";
            tbActivities.Size = new Size(87, 27);
            tbActivities.TabIndex = 16;
            tbActivities.TextChanged += tbActivities_TextChanged;
            // 
            // tbFinalCalification
            // 
            tbFinalCalification.Enabled = false;
            tbFinalCalification.Location = new Point(307, 352);
            tbFinalCalification.Name = "tbFinalCalification";
            tbFinalCalification.Size = new Size(135, 27);
            tbFinalCalification.TabIndex = 18;
            // 
            // tbResult
            // 
            tbResult.Enabled = false;
            tbResult.Location = new Point(246, 387);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(135, 27);
            tbResult.TabIndex = 19;
            // 
            // tbLiteral
            // 
            tbLiteral.Enabled = false;
            tbLiteral.Location = new Point(246, 425);
            tbLiteral.Name = "tbLiteral";
            tbLiteral.Size = new Size(135, 27);
            tbLiteral.TabIndex = 20;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(149, 254);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(105, 31);
            btnCalc.TabIndex = 21;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.IndianRed;
            lblError.Location = new Point(272, 259);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 630);
            Controls.Add(lblError);
            Controls.Add(btnCalc);
            Controls.Add(tbLiteral);
            Controls.Add(tbResult);
            Controls.Add(tbFinalCalification);
            Controls.Add(lblPersentageActivities);
            Controls.Add(tbActivities);
            Controls.Add(lblPersentageProduction);
            Controls.Add(tbProduction);
            Controls.Add(lblPersentagePlatform);
            Controls.Add(tbPlatform);
            Controls.Add(lblPersentageActitudes);
            Controls.Add(tbActitudes);
            Controls.Add(lblExamPersentaje);
            Controls.Add(tbExam);
            Controls.Add(lblLiteral);
            Controls.Add(lblResult);
            Controls.Add(lblScore);
            Controls.Add(lblProduction);
            Controls.Add(lblActivities);
            Controls.Add(lblPlatform);
            Controls.Add(lblActitudes);
            Controls.Add(lblExam);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExam;
        private Label lblActitudes;
        private Label lblPlatform;
        private Label lblActivities;
        private Label lblProduction;
        private Label lblLiteral;
        private Label lblResult;
        private Label lblScore;
        private TextBox tbExam;
        private Label lblExamPersentaje;
        private Label lblPersentageActitudes;
        private TextBox tbActitudes;
        private Label lblPersentagePlatform;
        private TextBox tbPlatform;
        private Label lblPersentageProduction;
        private TextBox tbProduction;
        private Label lblPersentageActivities;
        private TextBox tbActivities;
        private TextBox tbFinalCalification;
        private TextBox tbResult;
        private TextBox tbLiteral;
        private Button btnCalc;
        private Label lblError;
    }
}