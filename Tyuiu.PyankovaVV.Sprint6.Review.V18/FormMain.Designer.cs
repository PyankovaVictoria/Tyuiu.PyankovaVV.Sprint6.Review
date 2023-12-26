
namespace Tyuiu.PyankovaVV.Sprint6.Review.V18
{
    partial class FormMain
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
            this.panelLeft_PVV = new System.Windows.Forms.Panel();
            this.buttonResult_PVV = new System.Windows.Forms.Button();
            this.buttonGetMatrix_PVV = new System.Windows.Forms.Button();
            this.labelNumRow_PVV = new System.Windows.Forms.Label();
            this.labelEndDiap_PVV = new System.Windows.Forms.Label();
            this.labelStartDiap_PVV = new System.Windows.Forms.Label();
            this.labelColumns_PVV = new System.Windows.Forms.Label();
            this.labelRows_PVV = new System.Windows.Forms.Label();
            this.labelEndColumn_PVV = new System.Windows.Forms.Label();
            this.labelStartColumn_PVV = new System.Windows.Forms.Label();
            this.labelResult_PVV = new System.Windows.Forms.Label();
            this.textBoxResult_PVV = new System.Windows.Forms.TextBox();
            this.textBoxNumRow_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStopColumn_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStartColumn_PVV = new System.Windows.Forms.TextBox();
            this.textBoxColumns_PVV = new System.Windows.Forms.TextBox();
            this.textBoxRows_PVV = new System.Windows.Forms.TextBox();
            this.textBoxEndDiap_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStartDiap_PVV = new System.Windows.Forms.TextBox();
            this.panelFill_PVV = new System.Windows.Forms.Panel();
            this.dataGridViewMatrix_PVV = new System.Windows.Forms.DataGridView();
            this.panelLeft_PVV.SuspendLayout();
            this.panelFill_PVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_PVV
            // 
            this.panelLeft_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft_PVV.Controls.Add(this.buttonResult_PVV);
            this.panelLeft_PVV.Controls.Add(this.buttonGetMatrix_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelNumRow_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelEndDiap_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelStartDiap_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelColumns_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelRows_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelEndColumn_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelStartColumn_PVV);
            this.panelLeft_PVV.Controls.Add(this.labelResult_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxResult_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxNumRow_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxStopColumn_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxStartColumn_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxColumns_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxRows_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxEndDiap_PVV);
            this.panelLeft_PVV.Controls.Add(this.textBoxStartDiap_PVV);
            this.panelLeft_PVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PVV.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_PVV.Name = "panelLeft_PVV";
            this.panelLeft_PVV.Size = new System.Drawing.Size(226, 560);
            this.panelLeft_PVV.TabIndex = 0;
            // 
            // buttonResult_PVV
            // 
            this.buttonResult_PVV.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonResult_PVV.Location = new System.Drawing.Point(126, 455);
            this.buttonResult_PVV.Name = "buttonResult_PVV";
            this.buttonResult_PVV.Size = new System.Drawing.Size(92, 51);
            this.buttonResult_PVV.TabIndex = 17;
            this.buttonResult_PVV.Text = "Результат";
            this.buttonResult_PVV.UseVisualStyleBackColor = false;
            this.buttonResult_PVV.Click += new System.EventHandler(this.buttonResult_PVV_Click);
            // 
            // buttonGetMatrix_PVV
            // 
            this.buttonGetMatrix_PVV.BackColor = System.Drawing.Color.Orange;
            this.buttonGetMatrix_PVV.Location = new System.Drawing.Point(13, 455);
            this.buttonGetMatrix_PVV.Name = "buttonGetMatrix_PVV";
            this.buttonGetMatrix_PVV.Size = new System.Drawing.Size(90, 51);
            this.buttonGetMatrix_PVV.TabIndex = 16;
            this.buttonGetMatrix_PVV.Text = "Создать матрицу";
            this.buttonGetMatrix_PVV.UseVisualStyleBackColor = false;
            this.buttonGetMatrix_PVV.Click += new System.EventHandler(this.buttonGetMatrix_PVV_Click);
            // 
            // labelNumRow_PVV
            // 
            this.labelNumRow_PVV.AutoSize = true;
            this.labelNumRow_PVV.Location = new System.Drawing.Point(59, 274);
            this.labelNumRow_PVV.Name = "labelNumRow_PVV";
            this.labelNumRow_PVV.Size = new System.Drawing.Size(94, 13);
            this.labelNumRow_PVV.TabIndex = 15;
            this.labelNumRow_PVV.Text = "Заданная строка";
            // 
            // labelEndDiap_PVV
            // 
            this.labelEndDiap_PVV.AutoSize = true;
            this.labelEndDiap_PVV.Location = new System.Drawing.Point(117, 29);
            this.labelEndDiap_PVV.Name = "labelEndDiap_PVV";
            this.labelEndDiap_PVV.Size = new System.Drawing.Size(95, 13);
            this.labelEndDiap_PVV.TabIndex = 14;
            this.labelEndDiap_PVV.Text = "Конец диапазона";
            // 
            // labelStartDiap_PVV
            // 
            this.labelStartDiap_PVV.AutoSize = true;
            this.labelStartDiap_PVV.Location = new System.Drawing.Point(4, 29);
            this.labelStartDiap_PVV.Name = "labelStartDiap_PVV";
            this.labelStartDiap_PVV.Size = new System.Drawing.Size(101, 13);
            this.labelStartDiap_PVV.TabIndex = 13;
            this.labelStartDiap_PVV.Text = "Начало диапазона";
            // 
            // labelColumns_PVV
            // 
            this.labelColumns_PVV.AutoSize = true;
            this.labelColumns_PVV.Location = new System.Drawing.Point(123, 122);
            this.labelColumns_PVV.Name = "labelColumns_PVV";
            this.labelColumns_PVV.Size = new System.Drawing.Size(91, 13);
            this.labelColumns_PVV.TabIndex = 12;
            this.labelColumns_PVV.Text = "Кол-во столбцов";
            // 
            // labelRows_PVV
            // 
            this.labelRows_PVV.AutoSize = true;
            this.labelRows_PVV.Location = new System.Drawing.Point(4, 126);
            this.labelRows_PVV.Name = "labelRows_PVV";
            this.labelRows_PVV.Size = new System.Drawing.Size(73, 13);
            this.labelRows_PVV.TabIndex = 11;
            this.labelRows_PVV.Text = "Кол-во строк";
            // 
            // labelEndColumn_PVV
            // 
            this.labelEndColumn_PVV.AutoSize = true;
            this.labelEndColumn_PVV.Location = new System.Drawing.Point(120, 208);
            this.labelEndColumn_PVV.Name = "labelEndColumn_PVV";
            this.labelEndColumn_PVV.Size = new System.Drawing.Size(66, 13);
            this.labelEndColumn_PVV.TabIndex = 10;
            this.labelEndColumn_PVV.Text = "До столбца";
            // 
            // labelStartColumn_PVV
            // 
            this.labelStartColumn_PVV.AutoSize = true;
            this.labelStartColumn_PVV.Location = new System.Drawing.Point(4, 209);
            this.labelStartColumn_PVV.Name = "labelStartColumn_PVV";
            this.labelStartColumn_PVV.Size = new System.Drawing.Size(64, 13);
            this.labelStartColumn_PVV.TabIndex = 9;
            this.labelStartColumn_PVV.Text = "От столбца";
            // 
            // labelResult_PVV
            // 
            this.labelResult_PVV.AutoSize = true;
            this.labelResult_PVV.Location = new System.Drawing.Point(79, 358);
            this.labelResult_PVV.Name = "labelResult_PVV";
            this.labelResult_PVV.Size = new System.Drawing.Size(59, 13);
            this.labelResult_PVV.TabIndex = 8;
            this.labelResult_PVV.Text = "Результат";
            // 
            // textBoxResult_PVV
            // 
            this.textBoxResult_PVV.Location = new System.Drawing.Point(59, 374);
            this.textBoxResult_PVV.Name = "textBoxResult_PVV";
            this.textBoxResult_PVV.ReadOnly = true;
            this.textBoxResult_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_PVV.TabIndex = 7;
            // 
            // textBoxNumRow_PVV
            // 
            this.textBoxNumRow_PVV.Location = new System.Drawing.Point(59, 290);
            this.textBoxNumRow_PVV.Name = "textBoxNumRow_PVV";
            this.textBoxNumRow_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumRow_PVV.TabIndex = 6;
            // 
            // textBoxStopColumn_PVV
            // 
            this.textBoxStopColumn_PVV.Location = new System.Drawing.Point(119, 227);
            this.textBoxStopColumn_PVV.Name = "textBoxStopColumn_PVV";
            this.textBoxStopColumn_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopColumn_PVV.TabIndex = 5;
            // 
            // textBoxStartColumn_PVV
            // 
            this.textBoxStartColumn_PVV.Location = new System.Drawing.Point(4, 228);
            this.textBoxStartColumn_PVV.Name = "textBoxStartColumn_PVV";
            this.textBoxStartColumn_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartColumn_PVV.TabIndex = 4;
            // 
            // textBoxColumns_PVV
            // 
            this.textBoxColumns_PVV.Location = new System.Drawing.Point(120, 141);
            this.textBoxColumns_PVV.Name = "textBoxColumns_PVV";
            this.textBoxColumns_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumns_PVV.TabIndex = 3;
            // 
            // textBoxRows_PVV
            // 
            this.textBoxRows_PVV.Location = new System.Drawing.Point(4, 142);
            this.textBoxRows_PVV.Name = "textBoxRows_PVV";
            this.textBoxRows_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows_PVV.TabIndex = 2;
            // 
            // textBoxEndDiap_PVV
            // 
            this.textBoxEndDiap_PVV.Location = new System.Drawing.Point(120, 48);
            this.textBoxEndDiap_PVV.Name = "textBoxEndDiap_PVV";
            this.textBoxEndDiap_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndDiap_PVV.TabIndex = 1;
            // 
            // textBoxStartDiap_PVV
            // 
            this.textBoxStartDiap_PVV.Location = new System.Drawing.Point(3, 48);
            this.textBoxStartDiap_PVV.Name = "textBoxStartDiap_PVV";
            this.textBoxStartDiap_PVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartDiap_PVV.TabIndex = 0;
            // 
            // panelFill_PVV
            // 
            this.panelFill_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFill_PVV.Controls.Add(this.dataGridViewMatrix_PVV);
            this.panelFill_PVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PVV.Location = new System.Drawing.Point(226, 0);
            this.panelFill_PVV.Name = "panelFill_PVV";
            this.panelFill_PVV.Size = new System.Drawing.Size(594, 560);
            this.panelFill_PVV.TabIndex = 1;
            // 
            // dataGridViewMatrix_PVV
            // 
            this.dataGridViewMatrix_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix_PVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_PVV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_PVV.Location = new System.Drawing.Point(-1, -1);
            this.dataGridViewMatrix_PVV.Name = "dataGridViewMatrix_PVV";
            this.dataGridViewMatrix_PVV.RowHeadersVisible = false;
            this.dataGridViewMatrix_PVV.Size = new System.Drawing.Size(592, 560);
            this.dataGridViewMatrix_PVV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.panelFill_PVV);
            this.Controls.Add(this.panelLeft_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Ревью | Вариант 18 | Пьянкова В. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelLeft_PVV.ResumeLayout(false);
            this.panelLeft_PVV.PerformLayout();
            this.panelFill_PVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_PVV;
        private System.Windows.Forms.Label labelNumRow_PVV;
        private System.Windows.Forms.Label labelEndDiap_PVV;
        private System.Windows.Forms.Label labelStartDiap_PVV;
        private System.Windows.Forms.Label labelColumns_PVV;
        private System.Windows.Forms.Label labelRows_PVV;
        private System.Windows.Forms.Label labelEndColumn_PVV;
        private System.Windows.Forms.Label labelStartColumn_PVV;
        private System.Windows.Forms.Label labelResult_PVV;
        private System.Windows.Forms.TextBox textBoxResult_PVV;
        private System.Windows.Forms.TextBox textBoxNumRow_PVV;
        private System.Windows.Forms.TextBox textBoxStopColumn_PVV;
        private System.Windows.Forms.TextBox textBoxStartColumn_PVV;
        private System.Windows.Forms.TextBox textBoxColumns_PVV;
        private System.Windows.Forms.TextBox textBoxRows_PVV;
        private System.Windows.Forms.TextBox textBoxEndDiap_PVV;
        private System.Windows.Forms.TextBox textBoxStartDiap_PVV;
        private System.Windows.Forms.Panel panelFill_PVV;
        private System.Windows.Forms.Button buttonResult_PVV;
        private System.Windows.Forms.Button buttonGetMatrix_PVV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_PVV;
    }
}
