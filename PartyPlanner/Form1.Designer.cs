namespace PartyPlanner
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EntertainmentListBox = new System.Windows.Forms.ListBox();
            this.DecorationsLabel = new System.Windows.Forms.Label();
            this.EntertainmentLabel = new System.Windows.Forms.Label();
            this.DrinksListBox = new System.Windows.Forms.ListBox();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.CalculateCostButton = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.NoOfGuestsLabel = new System.Windows.Forms.Label();
            this.numericUpDownGuestNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuestNo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(571, 1014);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Tick if required";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EntertainmentListBox
            // 
            this.EntertainmentListBox.FormattingEnabled = true;
            this.EntertainmentListBox.ItemHeight = 20;
            this.EntertainmentListBox.Location = new System.Drawing.Point(590, 798);
            this.EntertainmentListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EntertainmentListBox.Name = "EntertainmentListBox";
            this.EntertainmentListBox.Size = new System.Drawing.Size(160, 84);
            this.EntertainmentListBox.TabIndex = 36;
            this.EntertainmentListBox.SelectedIndexChanged += new System.EventHandler(this.EntertainmentListBox_SelectedIndexChanged);
            // 
            // DecorationsLabel
            // 
            this.DecorationsLabel.AutoSize = true;
            this.DecorationsLabel.Location = new System.Drawing.Point(331, 1018);
            this.DecorationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DecorationsLabel.Name = "DecorationsLabel";
            this.DecorationsLabel.Size = new System.Drawing.Size(161, 20);
            this.DecorationsLabel.TabIndex = 35;
            this.DecorationsLabel.Text = "Decorations required:";
            // 
            // EntertainmentLabel
            // 
            this.EntertainmentLabel.AutoSize = true;
            this.EntertainmentLabel.Location = new System.Drawing.Point(317, 798);
            this.EntertainmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntertainmentLabel.Name = "EntertainmentLabel";
            this.EntertainmentLabel.Size = new System.Drawing.Size(195, 20);
            this.EntertainmentLabel.TabIndex = 34;
            this.EntertainmentLabel.Text = "Select your entertainment:";
            // 
            // DrinksListBox
            // 
            this.DrinksListBox.FormattingEnabled = true;
            this.DrinksListBox.ItemHeight = 20;
            this.DrinksListBox.Location = new System.Drawing.Point(486, 599);
            this.DrinksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.DrinksListBox.Name = "DrinksListBox";
            this.DrinksListBox.Size = new System.Drawing.Size(110, 84);
            this.DrinksListBox.TabIndex = 33;
            this.DrinksListBox.SelectedIndexChanged += new System.EventHandler(this.DrinksListBox_SelectedIndexChanged);
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(317, 599);
            this.drinksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(138, 20);
            this.drinksLabel.TabIndex = 32;
            this.drinksLabel.Text = "Select your drinks:";
            // 
            // MenuListBox
            // 
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 20;
            this.MenuListBox.Location = new System.Drawing.Point(493, 409);
            this.MenuListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(103, 84);
            this.MenuListBox.TabIndex = 31;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Location = new System.Drawing.Point(304, 409);
            this.MenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(136, 20);
            this.MenuLabel.TabIndex = 30;
            this.MenuLabel.Text = "Select your menu:";
            // 
            // CalculateCostButton
            // 
            this.CalculateCostButton.Location = new System.Drawing.Point(1193, 550);
            this.CalculateCostButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateCostButton.Name = "CalculateCostButton";
            this.CalculateCostButton.Size = new System.Drawing.Size(464, 190);
            this.CalculateCostButton.TabIndex = 29;
            this.CalculateCostButton.Text = "Calculate cost of party";
            this.CalculateCostButton.UseVisualStyleBackColor = true;
            this.CalculateCostButton.Click += new System.EventHandler(this.CalculateCostButton_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(1739, 635);
            this.TotalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(0, 20);
            this.TotalCostLabel.TabIndex = 28;
            // 
            // NoOfGuestsLabel
            // 
            this.NoOfGuestsLabel.AutoSize = true;
            this.NoOfGuestsLabel.Location = new System.Drawing.Point(296, 267);
            this.NoOfGuestsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoOfGuestsLabel.Name = "NoOfGuestsLabel";
            this.NoOfGuestsLabel.Size = new System.Drawing.Size(144, 20);
            this.NoOfGuestsLabel.TabIndex = 27;
            this.NoOfGuestsLabel.Text = "How many guests?";
            // 
            // numericUpDownGuestNo
            // 
            this.numericUpDownGuestNo.Location = new System.Drawing.Point(506, 267);
            this.numericUpDownGuestNo.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownGuestNo.Name = "numericUpDownGuestNo";
            this.numericUpDownGuestNo.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownGuestNo.TabIndex = 26;
            this.numericUpDownGuestNo.ValueChanged += new System.EventHandler(this.numericUpDownGuestNo_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2035, 1305);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.EntertainmentListBox);
            this.Controls.Add(this.DecorationsLabel);
            this.Controls.Add(this.EntertainmentLabel);
            this.Controls.Add(this.DrinksListBox);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.CalculateCostButton);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.NoOfGuestsLabel);
            this.Controls.Add(this.numericUpDownGuestNo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuestNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox EntertainmentListBox;
        private System.Windows.Forms.Label DecorationsLabel;
        private System.Windows.Forms.Label EntertainmentLabel;
        private System.Windows.Forms.ListBox DrinksListBox;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button CalculateCostButton;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label NoOfGuestsLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownGuestNo;
    }
}

