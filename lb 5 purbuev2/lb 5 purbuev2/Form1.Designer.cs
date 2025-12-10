namespace lb_5_purbuev2
{
    partial class Form1
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.btnGeomAvg = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnPositiveCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGeom = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(190, 32);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 0;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(153, 58);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(162, 23);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "создать массив";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new System.Drawing.Point(12, 82);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(120, 95);
            this.listBoxArray.TabIndex = 3;
            // 
            // btnGeomAvg
            // 
            this.btnGeomAvg.Location = new System.Drawing.Point(153, 87);
            this.btnGeomAvg.Name = "btnGeomAvg";
            this.btnGeomAvg.Size = new System.Drawing.Size(162, 23);
            this.btnGeomAvg.TabIndex = 4;
            this.btnGeomAvg.Text = "Геометрическая";
            this.btnGeomAvg.UseVisualStyleBackColor = true;
            this.btnGeomAvg.Click += new System.EventHandler(this.btnGeom_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(153, 116);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(165, 23);
            this.btnDiff.TabIndex = 5;
            this.btnDiff.Text = "разность суммы";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // btnPositiveCount
            // 
            this.btnPositiveCount.Location = new System.Drawing.Point(153, 145);
            this.btnPositiveCount.Name = "btnPositiveCount";
            this.btnPositiveCount.Size = new System.Drawing.Size(253, 23);
            this.btnPositiveCount.TabIndex = 6;
            this.btnPositiveCount.Text = "Положительное отрицательное";
            this.btnPositiveCount.UseVisualStyleBackColor = true;
            this.btnPositiveCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ввод кол-ва элементов массива";
            // 
            // lblGeom
            // 
            this.lblGeom.AutoSize = true;
            this.lblGeom.Location = new System.Drawing.Point(26, 223);
            this.lblGeom.Name = "lblGeom";
            this.lblGeom.Size = new System.Drawing.Size(90, 13);
            this.lblGeom.TabIndex = 7;
            this.lblGeom.Text = "геометрическая";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(24, 251);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(92, 13);
            this.lblDiff.TabIndex = 8;
            this.lblDiff.Text = "разность суммы";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(26, 276);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "+ -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.lblGeom);
            this.Controls.Add(this.btnPositiveCount);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.btnGeomAvg);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.Button btnGeomAvg;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnPositiveCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeom;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblCount;
    }
}

