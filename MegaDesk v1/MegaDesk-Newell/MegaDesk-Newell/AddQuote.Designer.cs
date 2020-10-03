namespace MegaDesk_Newell
{
    partial class AddQuote
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
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.widthEntryBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthEntryBox = new System.Windows.Forms.TextBox();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.drawerEntryBox = new System.Windows.Forms.TextBox();
            this.deskMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.materialOptionBox = new System.Windows.Forms.ComboBox();
            this.rushOrderBox = new System.Windows.Forms.ComboBox();
            this.nameEntryBox = new System.Windows.Forms.TextBox();
            this.nameEntryLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TodaysDate = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnToMainMenuButton.Location = new System.Drawing.Point(714, 410);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.returnToMainMenuButton.TabIndex = 0;
            this.returnToMainMenuButton.Text = "M&ain Menu";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // widthEntryBox
            // 
            this.widthEntryBox.Location = new System.Drawing.Point(12, 63);
            this.widthEntryBox.Name = "widthEntryBox";
            this.widthEntryBox.Size = new System.Drawing.Size(132, 20);
            this.widthEntryBox.TabIndex = 2;
            this.widthEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthEntryBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthEntryBox_Validating);
            this.widthEntryBox.Validated += new System.EventHandler(this.widthEntryBox_Validated);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 47);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(94, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Enter Desk Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(12, 86);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(95, 13);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Enter Desk Depth:";
            // 
            // depthEntryBox
            // 
            this.depthEntryBox.Location = new System.Drawing.Point(12, 102);
            this.depthEntryBox.Name = "depthEntryBox";
            this.depthEntryBox.Size = new System.Drawing.Size(132, 20);
            this.depthEntryBox.TabIndex = 3;
            this.depthEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.depthEntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthEntryBox_KeyPress);
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Location = new System.Drawing.Point(9, 125);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(129, 13);
            this.drawerLabel.TabIndex = 3;
            this.drawerLabel.Text = "Enter Number of Drawers:";
            // 
            // drawerEntryBox
            // 
            this.drawerEntryBox.Location = new System.Drawing.Point(12, 141);
            this.drawerEntryBox.Name = "drawerEntryBox";
            this.drawerEntryBox.Size = new System.Drawing.Size(132, 20);
            this.drawerEntryBox.TabIndex = 4;
            this.drawerEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deskMaterialLabel
            // 
            this.deskMaterialLabel.AutoSize = true;
            this.deskMaterialLabel.Location = new System.Drawing.Point(9, 164);
            this.deskMaterialLabel.Name = "deskMaterialLabel";
            this.deskMaterialLabel.Size = new System.Drawing.Size(138, 13);
            this.deskMaterialLabel.TabIndex = 3;
            this.deskMaterialLabel.Text = "Choose Material Option 1-5:";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Location = new System.Drawing.Point(9, 204);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(108, 13);
            this.RushOrderLabel.TabIndex = 3;
            this.RushOrderLabel.Text = "Choose Rush Option:";
            // 
            // materialOptionBox
            // 
            this.materialOptionBox.FormattingEnabled = true;
            this.materialOptionBox.Location = new System.Drawing.Point(12, 180);
            this.materialOptionBox.Name = "materialOptionBox";
            this.materialOptionBox.Size = new System.Drawing.Size(132, 21);
            this.materialOptionBox.TabIndex = 5;
            // 
            // rushOrderBox
            // 
            this.rushOrderBox.FormattingEnabled = true;
            this.rushOrderBox.Location = new System.Drawing.Point(12, 220);
            this.rushOrderBox.Name = "rushOrderBox";
            this.rushOrderBox.Size = new System.Drawing.Size(132, 21);
            this.rushOrderBox.TabIndex = 6;
            // 
            // nameEntryBox
            // 
            this.nameEntryBox.Location = new System.Drawing.Point(12, 25);
            this.nameEntryBox.Name = "nameEntryBox";
            this.nameEntryBox.Size = new System.Drawing.Size(132, 20);
            this.nameEntryBox.TabIndex = 1;
            this.nameEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameEntryLabel
            // 
            this.nameEntryLabel.AutoSize = true;
            this.nameEntryLabel.Location = new System.Drawing.Point(12, 9);
            this.nameEntryLabel.Name = "nameEntryLabel";
            this.nameEntryLabel.Size = new System.Drawing.Size(101, 13);
            this.nameEntryLabel.TabIndex = 2;
            this.nameEntryLabel.Text = "Please Enter Name:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(32, 415);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Date:";
            // 
            // TodaysDate
            // 
            this.TodaysDate.AutoSize = true;
            this.TodaysDate.Location = new System.Drawing.Point(71, 415);
            this.TodaysDate.Name = "TodaysDate";
            this.TodaysDate.Size = new System.Drawing.Size(70, 13);
            this.TodaysDate.TabIndex = 7;
            this.TodaysDate.Text = "Today\'s Date";
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.Location = new System.Drawing.Point(299, 393);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(205, 45);
            this.SubmitOrder.TabIndex = 8;
            this.SubmitOrder.Text = "Submit Order";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.returnToMainMenuButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.TodaysDate);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.rushOrderBox);
            this.Controls.Add(this.materialOptionBox);
            this.Controls.Add(this.drawerEntryBox);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.deskMaterialLabel);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthEntryBox);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.nameEntryLabel);
            this.Controls.Add(this.nameEntryBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthEntryBox);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.TextBox widthEntryBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthEntryBox;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.TextBox drawerEntryBox;
        private System.Windows.Forms.Label deskMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox materialOptionBox;
        private System.Windows.Forms.ComboBox rushOrderBox;
        private System.Windows.Forms.TextBox nameEntryBox;
        private System.Windows.Forms.Label nameEntryLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TodaysDate;
        private System.Windows.Forms.Button SubmitOrder;
    }
}