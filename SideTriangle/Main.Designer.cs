namespace SideTriangle
{
    partial class Main
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.tbSideC = new System.Windows.Forms.TextBox();
            this.tbSideB = new System.Windows.Forms.TextBox();
            this.tbSideA = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelOutput);
            this.panelMain.Controls.Add(this.btnMain);
            this.panelMain.Controls.Add(this.labelInput);
            this.panelMain.Controls.Add(this.tbSideC);
            this.panelMain.Controls.Add(this.tbSideB);
            this.panelMain.Controls.Add(this.tbSideA);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1101, 594);
            this.panelMain.TabIndex = 0;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(318, 147);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(339, 33);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Треугольник является (тип)";
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.IndianRed;
            this.btnMain.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(374, 326);
            this.btnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(309, 78);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Проверить";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(369, 108);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(314, 26);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Введите стороны треугольника";
            // 
            // tbSideC
            // 
            this.tbSideC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSideC.Location = new System.Drawing.Point(698, 194);
            this.tbSideC.Name = "tbSideC";
            this.tbSideC.Size = new System.Drawing.Size(193, 39);
            this.tbSideC.TabIndex = 2;
            // 
            // tbSideB
            // 
            this.tbSideB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSideB.Location = new System.Drawing.Point(428, 194);
            this.tbSideB.Name = "tbSideB";
            this.tbSideB.Size = new System.Drawing.Size(193, 39);
            this.tbSideB.TabIndex = 1;
            // 
            // tbSideA
            // 
            this.tbSideA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSideA.Location = new System.Drawing.Point(151, 194);
            this.tbSideA.Name = "tbSideA";
            this.tbSideA.Size = new System.Drawing.Size(193, 39);
            this.tbSideA.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1101, 594);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Какой это треугольник?";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox tbSideC;
        private System.Windows.Forms.TextBox tbSideB;
        private System.Windows.Forms.TextBox tbSideA;
        private System.Windows.Forms.Label labelOutput;
    }
}

