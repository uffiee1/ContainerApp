namespace ContainerApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbxContainers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.btnStartVisualize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numUpDown1);
            this.groupBox1.Controls.Add(this.numUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 79);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schip Info:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Schip Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Schip Width:";
            // 
            // numUpDown1
            // 
            this.numUpDown1.Location = new System.Drawing.Point(112, 20);
            this.numUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numUpDown1.TabIndex = 1;
            // 
            // numUpDown2
            // 
            this.numUpDown2.Location = new System.Drawing.Point(112, 46);
            this.numUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDown2.Name = "numUpDown2";
            this.numUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numUpDown2.TabIndex = 0;
            // 
            // lbxContainers
            // 
            this.lbxContainers.FormattingEnabled = true;
            this.lbxContainers.Location = new System.Drawing.Point(12, 195);
            this.lbxContainers.Name = "lbxContainers";
            this.lbxContainers.Size = new System.Drawing.Size(304, 290);
            this.lbxContainers.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Containers:";
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.Enabled = false;
            this.btnCreateContainer.Location = new System.Drawing.Point(124, 97);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(75, 51);
            this.btnCreateContainer.TabIndex = 5;
            this.btnCreateContainer.Text = "Create Containers";
            this.btnCreateContainer.UseVisualStyleBackColor = true;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // btnStartVisualize
            // 
            this.btnStartVisualize.Enabled = false;
            this.btnStartVisualize.Location = new System.Drawing.Point(241, 97);
            this.btnStartVisualize.Name = "btnStartVisualize";
            this.btnStartVisualize.Size = new System.Drawing.Size(75, 51);
            this.btnStartVisualize.TabIndex = 15;
            this.btnStartVisualize.Text = "Start Visualize";
            this.btnStartVisualize.UseVisualStyleBackColor = true;
            this.btnStartVisualize.Click += new System.EventHandler(this.btnStartVisualize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 506);
            this.Controls.Add(this.btnStartVisualize);
            this.Controls.Add(this.btnCreateContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxContainers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ContainerVervoer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDown1;
        private System.Windows.Forms.NumericUpDown numUpDown2;
        private System.Windows.Forms.ListBox lbxContainers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.Button btnStartVisualize;
    }
}

