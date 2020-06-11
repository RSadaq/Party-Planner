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
            this.numericUpDownGuestNo = new System.Windows.Forms.NumericUpDown();
            this.NoOfGuestsLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.CalculateCostButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.DrinksListBox = new System.Windows.Forms.ListBox();
            this.EntertainmentLabel = new System.Windows.Forms.Label();
            this.DecorationsLabel = new System.Windows.Forms.Label();
            this.EntertainmentListBox = new System.Windows.Forms.ListBox();
            this.DecorationsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuestNo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGuestNo
            // 
            this.numericUpDownGuestNo.Location = new System.Drawing.Point(412, 211);
            this.numericUpDownGuestNo.Name = "numericUpDownGuestNo";
            this.numericUpDownGuestNo.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownGuestNo.TabIndex = 0;
            // 
            // NoOfGuestsLabel
            // 
            this.NoOfGuestsLabel.AutoSize = true;
            this.NoOfGuestsLabel.Location = new System.Drawing.Point(193, 213);
            this.NoOfGuestsLabel.Name = "NoOfGuestsLabel";
            this.NoOfGuestsLabel.Size = new System.Drawing.Size(194, 25);
            this.NoOfGuestsLabel.TabIndex = 1;
            this.NoOfGuestsLabel.Text = "How many guests?";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(2032, 496);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(0, 25);
            this.TotalCostLabel.TabIndex = 2;
            // 
            // CalculateCostButton
            // 
            this.CalculateCostButton.Location = new System.Drawing.Point(1304, 390);
            this.CalculateCostButton.Name = "CalculateCostButton";
            this.CalculateCostButton.Size = new System.Drawing.Size(619, 237);
            this.CalculateCostButton.TabIndex = 3;
            this.CalculateCostButton.Text = "Calculate cost of party";
            this.CalculateCostButton.UseVisualStyleBackColor = true;
            this.CalculateCostButton.Click += new System.EventHandler(this.CalculateCostButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Location = new System.Drawing.Point(193, 352);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(185, 25);
            this.MenuLabel.TabIndex = 4;
            this.MenuLabel.Text = "Select your menu:";
            // 
            // MenuListBox
            // 
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 25;
            this.MenuListBox.Items.AddRange(new object[] {
            "Vegan",
            "Non-Vegan",
            "Snacks only"});
            this.MenuListBox.Location = new System.Drawing.Point(412, 352);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(136, 104);
            this.MenuListBox.TabIndex = 5;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(193, 572);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(190, 25);
            this.drinksLabel.TabIndex = 6;
            this.drinksLabel.Text = "Select your drinks:";
            // 
            // DrinksListBox
            // 
            this.DrinksListBox.FormattingEnabled = true;
            this.DrinksListBox.ItemHeight = 25;
            this.DrinksListBox.Items.AddRange(new object[] {
            "Alcoholic",
            "Non-alcoholic"});
            this.DrinksListBox.Location = new System.Drawing.Point(412, 572);
            this.DrinksListBox.Name = "DrinksListBox";
            this.DrinksListBox.Size = new System.Drawing.Size(146, 104);
            this.DrinksListBox.TabIndex = 7;
            this.DrinksListBox.SelectedIndexChanged += new System.EventHandler(this.DrinksListBox_SelectedIndexChanged);
            // 
            // EntertainmentLabel
            // 
            this.EntertainmentLabel.AutoSize = true;
            this.EntertainmentLabel.Location = new System.Drawing.Point(193, 817);
            this.EntertainmentLabel.Name = "EntertainmentLabel";
            this.EntertainmentLabel.Size = new System.Drawing.Size(263, 25);
            this.EntertainmentLabel.TabIndex = 8;
            this.EntertainmentLabel.Text = "Select your entertainment:";
            // 
            // DecorationsLabel
            // 
            this.DecorationsLabel.AutoSize = true;
            this.DecorationsLabel.Location = new System.Drawing.Point(207, 1036);
            this.DecorationsLabel.Name = "DecorationsLabel";
            this.DecorationsLabel.Size = new System.Drawing.Size(218, 25);
            this.DecorationsLabel.TabIndex = 10;
            this.DecorationsLabel.Text = "Decorations required:";
            // 
            // EntertainmentListBox
            // 
            this.EntertainmentListBox.FormattingEnabled = true;
            this.EntertainmentListBox.ItemHeight = 25;
            this.EntertainmentListBox.Items.AddRange(new object[] {
            "DJ",
            "Live Entertainment",
            "Not required"});
            this.EntertainmentListBox.Location = new System.Drawing.Point(500, 803);
            this.EntertainmentListBox.Name = "EntertainmentListBox";
            this.EntertainmentListBox.Size = new System.Drawing.Size(212, 104);
            this.EntertainmentListBox.TabIndex = 12;
            this.EntertainmentListBox.SelectedIndexChanged += new System.EventHandler(this.EntrtnmntListBox_SelectedIndexChanged);
            // 
            // DecorationsListBox
            // 
            this.DecorationsListBox.FormattingEnabled = true;
            this.DecorationsListBox.ItemHeight = 25;
            this.DecorationsListBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.DecorationsListBox.Location = new System.Drawing.Point(500, 1036);
            this.DecorationsListBox.Name = "DecorationsListBox";
            this.DecorationsListBox.Size = new System.Drawing.Size(135, 104);
            this.DecorationsListBox.TabIndex = 13;
            this.DecorationsListBox.SelectedIndexChanged += new System.EventHandler(this.decorationsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2713, 1631);
            this.Controls.Add(this.DecorationsListBox);
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
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuestNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGuestNo;
        private System.Windows.Forms.Label NoOfGuestsLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button CalculateCostButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.ListBox DrinksListBox;
        private System.Windows.Forms.Label EntertainmentLabel;
        private System.Windows.Forms.Label DecorationsLabel;
        private System.Windows.Forms.ListBox EntertainmentListBox;
        private System.Windows.Forms.ListBox DecorationsListBox;
    }
}

