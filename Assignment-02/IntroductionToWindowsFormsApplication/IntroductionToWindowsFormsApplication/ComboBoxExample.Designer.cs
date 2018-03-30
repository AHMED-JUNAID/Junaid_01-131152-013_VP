namespace IntroductionToWindowsFormsApplication
{
    partial class ComboBoxExample
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
            this.SportsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewItemTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CountItemsButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearAllItemsButton = new System.Windows.Forms.Button();
            this.SortItemsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SportsComboBox
            // 
            this.SportsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SportsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SportsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SportsComboBox.FormattingEnabled = true;
            this.SportsComboBox.Items.AddRange(new object[] {
            "Hockey",
            "Cricket",
            "Squash",
            "Football",
            "Tennis",
            "Swimming"});
            this.SportsComboBox.Location = new System.Drawing.Point(17, 81);
            this.SportsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SportsComboBox.Name = "SportsComboBox";
            this.SportsComboBox.Size = new System.Drawing.Size(291, 23);
            this.SportsComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter an Item To Add";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewItemTextBox
            // 
            this.NewItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewItemTextBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewItemTextBox.Location = new System.Drawing.Point(18, 44);
            this.NewItemTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewItemTextBox.Name = "NewItemTextBox";
            this.NewItemTextBox.Size = new System.Drawing.Size(197, 24);
            this.NewItemTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(231, 44);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 24);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "&Add Item";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CountItemsButton
            // 
            this.CountItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CountItemsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountItemsButton.Location = new System.Drawing.Point(17, 118);
            this.CountItemsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountItemsButton.Name = "CountItemsButton";
            this.CountItemsButton.Size = new System.Drawing.Size(291, 27);
            this.CountItemsButton.TabIndex = 3;
            this.CountItemsButton.Text = "&Count Items";
            this.CountItemsButton.UseVisualStyleBackColor = false;
            this.CountItemsButton.Click += new System.EventHandler(this.CountItemsButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RemoveItemButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemButton.Location = new System.Drawing.Point(17, 160);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(291, 27);
            this.RemoveItemButton.TabIndex = 4;
            this.RemoveItemButton.Text = "&Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearAllItemsButton
            // 
            this.ClearAllItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearAllItemsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllItemsButton.Location = new System.Drawing.Point(17, 203);
            this.ClearAllItemsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearAllItemsButton.Name = "ClearAllItemsButton";
            this.ClearAllItemsButton.Size = new System.Drawing.Size(291, 27);
            this.ClearAllItemsButton.TabIndex = 5;
            this.ClearAllItemsButton.Text = "&Clear All Items";
            this.ClearAllItemsButton.UseVisualStyleBackColor = false;
            this.ClearAllItemsButton.Click += new System.EventHandler(this.ClearAllItemsButton_Click);
            // 
            // SortItemsButton
            // 
            this.SortItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SortItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SortItemsButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortItemsButton.Location = new System.Drawing.Point(18, 245);
            this.SortItemsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortItemsButton.Name = "SortItemsButton";
            this.SortItemsButton.Size = new System.Drawing.Size(291, 27);
            this.SortItemsButton.TabIndex = 6;
            this.SortItemsButton.Text = "&Sort Items";
            this.SortItemsButton.UseVisualStyleBackColor = false;
            this.SortItemsButton.Click += new System.EventHandler(this.SortItemsButton_Click);
            // 
            // ComboBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.Controls.Add(this.SortItemsButton);
            this.Controls.Add(this.ClearAllItemsButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CountItemsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NewItemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SportsComboBox);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComboBoxExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SportsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewItemTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CountItemsButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearAllItemsButton;
        private System.Windows.Forms.Button SortItemsButton;
    }
}