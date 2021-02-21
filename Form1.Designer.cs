
namespace CSharp_FrameExtractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartExtraction = new System.Windows.Forms.Button();
            this.SomeoneHelpMeRenameThese = new System.Windows.Forms.Label();
            this.OutputFolderPath = new System.Windows.Forms.TextBox();
            this.OutputFolderPathChoose = new System.Windows.Forms.Button();
            this.VideoPathChoose = new System.Windows.Forms.Button();
            this.VideoPath = new System.Windows.Forms.TextBox();
            this.ImBadAtNames = new System.Windows.Forms.Label();
            this.OutputFolderPathDrop = new System.Windows.Forms.Label();
            this.VideoPathDrop = new System.Windows.Forms.Label();
            this.NumberOfProcesses = new System.Windows.Forms.NumericUpDown();
            this.AGoodName = new System.Windows.Forms.Label();
            this.TotalNumberOfFrames = new System.Windows.Forms.Label();
            this.Its6amNowAndImTired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // StartExtraction
            // 
            this.StartExtraction.Location = new System.Drawing.Point(12, 351);
            this.StartExtraction.Name = "StartExtraction";
            this.StartExtraction.Size = new System.Drawing.Size(260, 48);
            this.StartExtraction.TabIndex = 0;
            this.StartExtraction.Text = "Extract frames";
            this.StartExtraction.UseVisualStyleBackColor = true;
            this.StartExtraction.Click += new System.EventHandler(this.StartExtraction_Click);
            // 
            // SomeoneHelpMeRenameThese
            // 
            this.SomeoneHelpMeRenameThese.AutoSize = true;
            this.SomeoneHelpMeRenameThese.Location = new System.Drawing.Point(12, 167);
            this.SomeoneHelpMeRenameThese.Name = "SomeoneHelpMeRenameThese";
            this.SomeoneHelpMeRenameThese.Size = new System.Drawing.Size(95, 13);
            this.SomeoneHelpMeRenameThese.TabIndex = 2;
            this.SomeoneHelpMeRenameThese.Text = "Output folder path:";
            // 
            // OutputFolderPath
            // 
            this.OutputFolderPath.Location = new System.Drawing.Point(12, 183);
            this.OutputFolderPath.Name = "OutputFolderPath";
            this.OutputFolderPath.Size = new System.Drawing.Size(232, 20);
            this.OutputFolderPath.TabIndex = 3;
            // 
            // OutputFolderPathChoose
            // 
            this.OutputFolderPathChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolderPathChoose.Location = new System.Drawing.Point(245, 183);
            this.OutputFolderPathChoose.Name = "OutputFolderPathChoose";
            this.OutputFolderPathChoose.Size = new System.Drawing.Size(27, 20);
            this.OutputFolderPathChoose.TabIndex = 4;
            this.OutputFolderPathChoose.Text = "...";
            this.OutputFolderPathChoose.UseVisualStyleBackColor = true;
            this.OutputFolderPathChoose.Click += new System.EventHandler(this.OutputFolderPathChoose_Click);
            // 
            // VideoPathChoose
            // 
            this.VideoPathChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoPathChoose.Location = new System.Drawing.Point(245, 144);
            this.VideoPathChoose.Name = "VideoPathChoose";
            this.VideoPathChoose.Size = new System.Drawing.Size(27, 20);
            this.VideoPathChoose.TabIndex = 7;
            this.VideoPathChoose.Text = "...";
            this.VideoPathChoose.UseVisualStyleBackColor = true;
            this.VideoPathChoose.Click += new System.EventHandler(this.VideoPathChoose_Click);
            // 
            // VideoPath
            // 
            this.VideoPath.Location = new System.Drawing.Point(12, 144);
            this.VideoPath.Name = "VideoPath";
            this.VideoPath.Size = new System.Drawing.Size(232, 20);
            this.VideoPath.TabIndex = 6;
            this.VideoPath.TextChanged += new System.EventHandler(this.VideoPath_TextChanged);
            // 
            // ImBadAtNames
            // 
            this.ImBadAtNames.AutoSize = true;
            this.ImBadAtNames.Location = new System.Drawing.Point(12, 128);
            this.ImBadAtNames.Name = "ImBadAtNames";
            this.ImBadAtNames.Size = new System.Drawing.Size(87, 13);
            this.ImBadAtNames.TabIndex = 5;
            this.ImBadAtNames.Text = "Input video path:";
            // 
            // OutputFolderPathDrop
            // 
            this.OutputFolderPathDrop.AllowDrop = true;
            this.OutputFolderPathDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152)))));
            this.OutputFolderPathDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputFolderPathDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFolderPathDrop.Location = new System.Drawing.Point(143, 9);
            this.OutputFolderPathDrop.Name = "OutputFolderPathDrop";
            this.OutputFolderPathDrop.Size = new System.Drawing.Size(129, 109);
            this.OutputFolderPathDrop.TabIndex = 10;
            this.OutputFolderPathDrop.Text = "Drag and drop output folder here";
            this.OutputFolderPathDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputFolderPathDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputFolderPathDrop_DragDrop);
            this.OutputFolderPathDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drags_DragEnter);
            // 
            // VideoPathDrop
            // 
            this.VideoPathDrop.AllowDrop = true;
            this.VideoPathDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.VideoPathDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoPathDrop.Location = new System.Drawing.Point(12, 9);
            this.VideoPathDrop.Name = "VideoPathDrop";
            this.VideoPathDrop.Size = new System.Drawing.Size(129, 109);
            this.VideoPathDrop.TabIndex = 11;
            this.VideoPathDrop.Text = "Drag and drop input video here";
            this.VideoPathDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VideoPathDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoPathDrop_DragDrop);
            this.VideoPathDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drags_DragEnter);
            // 
            // NumberOfProcesses
            // 
            this.NumberOfProcesses.Location = new System.Drawing.Point(246, 283);
            this.NumberOfProcesses.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumberOfProcesses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfProcesses.Name = "NumberOfProcesses";
            this.NumberOfProcesses.Size = new System.Drawing.Size(27, 20);
            this.NumberOfProcesses.TabIndex = 12;
            this.NumberOfProcesses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AGoodName
            // 
            this.AGoodName.AutoSize = true;
            this.AGoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGoodName.Location = new System.Drawing.Point(13, 285);
            this.AGoodName.Name = "AGoodName";
            this.AGoodName.Size = new System.Drawing.Size(222, 13);
            this.AGoodName.TabIndex = 13;
            this.AGoodName.Text = "Number of processes running at once (Max 8)";
            // 
            // TotalNumberOfFrames
            // 
            this.TotalNumberOfFrames.AutoSize = true;
            this.TotalNumberOfFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumberOfFrames.Location = new System.Drawing.Point(13, 206);
            this.TotalNumberOfFrames.Name = "TotalNumberOfFrames";
            this.TotalNumberOfFrames.Size = new System.Drawing.Size(91, 17);
            this.TotalNumberOfFrames.TabIndex = 14;
            this.TotalNumberOfFrames.Text = "Total frames:";
            // 
            // Its6amNowAndImTired
            // 
            this.Its6amNowAndImTired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Its6amNowAndImTired.Location = new System.Drawing.Point(13, 309);
            this.Its6amNowAndImTired.Name = "Its6amNowAndImTired";
            this.Its6amNowAndImTired.Size = new System.Drawing.Size(259, 39);
            this.Its6amNowAndImTired.TabIndex = 15;
            this.Its6amNowAndImTired.Text = "Warning: Using multiple processes could be slower than a single process. And you " +
    "cannot easily cancel the frame extraction.            ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Frame accuracy 30+/-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Its6amNowAndImTired);
            this.Controls.Add(this.TotalNumberOfFrames);
            this.Controls.Add(this.AGoodName);
            this.Controls.Add(this.NumberOfProcesses);
            this.Controls.Add(this.VideoPathDrop);
            this.Controls.Add(this.OutputFolderPathDrop);
            this.Controls.Add(this.VideoPathChoose);
            this.Controls.Add(this.VideoPath);
            this.Controls.Add(this.ImBadAtNames);
            this.Controls.Add(this.OutputFolderPathChoose);
            this.Controls.Add(this.OutputFolderPath);
            this.Controls.Add(this.SomeoneHelpMeRenameThese);
            this.Controls.Add(this.StartExtraction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Form1";
            this.Text = "Video frame extractor";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartExtraction;
        private System.Windows.Forms.Label SomeoneHelpMeRenameThese;
        private System.Windows.Forms.TextBox OutputFolderPath;
        private System.Windows.Forms.Button OutputFolderPathChoose;
        private System.Windows.Forms.Button VideoPathChoose;
        private System.Windows.Forms.TextBox VideoPath;
        private System.Windows.Forms.Label ImBadAtNames;
        private System.Windows.Forms.Label OutputFolderPathDrop;
        private System.Windows.Forms.Label VideoPathDrop;
        private System.Windows.Forms.NumericUpDown NumberOfProcesses;
        private System.Windows.Forms.Label AGoodName;
        private System.Windows.Forms.Label TotalNumberOfFrames;
        private System.Windows.Forms.Label Its6amNowAndImTired;
        private System.Windows.Forms.Label label1;
    }
}

