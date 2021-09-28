
namespace Visualize_Chessboard_Cover
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sizeLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionXText = new System.Windows.Forms.TextBox();
            this.positionYText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.drawTImer = new System.Windows.Forms.Timer(this.components);
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyText = new System.Windows.Forms.TextBox();
            this.frequencyUnitLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeLabel.Location = new System.Drawing.Point(668, 15);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(90, 21);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "棋盘大小：";
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.Location = new System.Drawing.Point(668, 50);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(122, 21);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "特殊方格位置：";
            // 
            // positionXText
            // 
            this.positionXText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionXText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionXText.Location = new System.Drawing.Point(796, 47);
            this.positionXText.Name = "positionXText";
            this.positionXText.Size = new System.Drawing.Size(97, 29);
            this.positionXText.TabIndex = 1;
            this.positionXText.Text = "1";
            this.positionXText.TextChanged += new System.EventHandler(this.SpecialXChanged);
            // 
            // positionYText
            // 
            this.positionYText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionYText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionYText.Location = new System.Drawing.Point(899, 47);
            this.positionYText.Name = "positionYText";
            this.positionYText.Size = new System.Drawing.Size(97, 29);
            this.positionYText.TabIndex = 2;
            this.positionYText.Text = "1";
            this.positionYText.TextChanged += new System.EventHandler(this.SpecialYChanged);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(796, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 31);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.BeginCover);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize = true;
            this.resetButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(899, 117);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 31);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetChessboard);
            // 
            // sizeCombo
            // 
            this.sizeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeCombo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.sizeCombo.Location = new System.Drawing.Point(796, 12);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(200, 29);
            this.sizeCombo.TabIndex = 0;
            this.sizeCombo.SelectedIndexChanged += new System.EventHandler(this.ChessboardSizeChanged);
            // 
            // drawTImer
            // 
            this.drawTImer.Interval = 1000;
            this.drawTImer.Tick += new System.EventHandler(this.DrawUnitThreeByThree);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frequencyLabel.Location = new System.Drawing.Point(668, 85);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(90, 21);
            this.frequencyLabel.TabIndex = 8;
            this.frequencyLabel.Text = "刷新间隔：";
            // 
            // frequencyText
            // 
            this.frequencyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frequencyText.Location = new System.Drawing.Point(796, 82);
            this.frequencyText.Name = "frequencyText";
            this.frequencyText.Size = new System.Drawing.Size(152, 29);
            this.frequencyText.TabIndex = 3;
            this.frequencyText.Text = "1000";
            this.frequencyText.TextChanged += new System.EventHandler(this.FrequencyChanged);
            // 
            // frequencyUnitLabel
            // 
            this.frequencyUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyUnitLabel.AutoSize = true;
            this.frequencyUnitLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frequencyUnitLabel.Location = new System.Drawing.Point(954, 85);
            this.frequencyUnitLabel.Name = "frequencyUnitLabel";
            this.frequencyUnitLabel.Size = new System.Drawing.Size(42, 21);
            this.frequencyUnitLabel.TabIndex = 10;
            this.frequencyUnitLabel.Text = "毫秒";
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.AutoSize = true;
            this.previousButton.Enabled = false;
            this.previousButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousButton.Location = new System.Drawing.Point(796, 155);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(97, 31);
            this.previousButton.TabIndex = 6;
            this.previousButton.Text = "上一步";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.GoPrevious);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.AutoSize = true;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(899, 155);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(97, 31);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "下一步";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.GoNext);
            // 
            // MainForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.frequencyUnitLabel);
            this.Controls.Add(this.frequencyText);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.sizeCombo);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.positionYText);
            this.Controls.Add(this.positionXText);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.sizeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "MainForm";
            this.Text = "棋盘覆盖可视化";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InitialPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionXText;
        private System.Windows.Forms.TextBox positionYText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.Timer drawTImer;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox frequencyText;
        private System.Windows.Forms.Label frequencyUnitLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
    }
}

