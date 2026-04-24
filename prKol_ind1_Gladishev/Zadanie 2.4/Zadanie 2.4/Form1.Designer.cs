namespace ArrayApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblArrayInfo = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnGetElement = new System.Windows.Forms.Button();
            this.btnSetElement = new System.Windows.Forms.Button();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnCreateSecond = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnPrintElement = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArrayInfo
            // 
            this.lblArrayInfo.AutoSize = true;
            this.lblArrayInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrayInfo.ForeColor = System.Drawing.Color.Black;
            this.lblArrayInfo.Location = new System.Drawing.Point(12, 9);
            this.lblArrayInfo.Name = "lblArrayInfo";
            this.lblArrayInfo.Size = new System.Drawing.Size(105, 15);
            this.lblArrayInfo.TabIndex = 1;
            this.lblArrayInfo.Text = "Массив не создан";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 39);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 15);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Размер:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(72, 36);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(55, 23);
            this.txtSize.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(135, 34);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 27);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Создать массив";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Location = new System.Drawing.Point(258, 34);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(115, 27);
            this.btnFillRandom.TabIndex = 5;
            this.btnFillRandom.Text = "Заполнить случ.";
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click_1);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(12, 77);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(50, 15);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "Индекс:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(72, 74);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(55, 23);
            this.txtIndex.TabIndex = 7;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(135, 77);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 15);
            this.lblValue.TabIndex = 8;
            this.lblValue.Text = "Знач.:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(175, 74);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(70, 23);
            this.txtValue.TabIndex = 9;
            // 
            // btnGetElement
            // 
            this.btnGetElement.Location = new System.Drawing.Point(253, 72);
            this.btnGetElement.Name = "btnGetElement";
            this.btnGetElement.Size = new System.Drawing.Size(90, 27);
            this.btnGetElement.TabIndex = 10;
            this.btnGetElement.Text = "Получить";
            this.btnGetElement.Click += new System.EventHandler(this.btnGetElement_Click_1);
            // 
            // btnSetElement
            // 
            this.btnSetElement.Location = new System.Drawing.Point(351, 72);
            this.btnSetElement.Name = "btnSetElement";
            this.btnSetElement.Size = new System.Drawing.Size(90, 27);
            this.btnSetElement.TabIndex = 11;
            this.btnSetElement.Text = "Установить";
            this.btnSetElement.Click += new System.EventHandler(this.btnSetElement_Click_1);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(12, 115);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(47, 15);
            this.lblMultiplier.TabIndex = 12;
            this.lblMultiplier.Text = "Множ.:";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(62, 112);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(55, 23);
            this.txtMultiplier.TabIndex = 13;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(125, 110);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(130, 27);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "Умножить на число";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click_1);
            // 
            // btnCreateSecond
            // 
            this.btnCreateSecond.Location = new System.Drawing.Point(263, 110);
            this.btnCreateSecond.Name = "btnCreateSecond";
            this.btnCreateSecond.Size = new System.Drawing.Size(130, 27);
            this.btnCreateSecond.TabIndex = 15;
            this.btnCreateSecond.Text = "Создать 2-й массив";
            this.btnCreateSecond.Click += new System.EventHandler(this.btnCreateSecond_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(401, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(479, 110);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(70, 27);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "−";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click_1);
            // 
            // btnPrintElement
            // 
            this.btnPrintElement.Location = new System.Drawing.Point(12, 149);
            this.btnPrintElement.Name = "btnPrintElement";
            this.btnPrintElement.Size = new System.Drawing.Size(175, 30);
            this.btnPrintElement.TabIndex = 18;
            this.btnPrintElement.Text = "Вывести элемент";
            this.btnPrintElement.Click += new System.EventHandler(this.btnPrintElement_Click_1);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(197, 149);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(175, 30);
            this.btnPrintAll.TabIndex = 19;
            this.btnPrintAll.Text = "Вывести весь массив";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Location = new System.Drawing.Point(382, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 30);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Очистить всё";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(12, 189);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(537, 250);
            this.txtOutput.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(12, 447);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(537, 22);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Готов к работе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 480);
            this.Controls.Add(this.lblArrayInfo);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnGetElement);
            this.Controls.Add(this.btnSetElement);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnCreateSecond);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnPrintElement);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одномерный массив (ArrayList + LINQ)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblArrayInfo;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnGetElement;
        private System.Windows.Forms.Button btnSetElement;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnCreateSecond;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnPrintElement;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblStatus;
    }
}

