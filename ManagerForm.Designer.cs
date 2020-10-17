namespace Remote_Desktop_Connection_List_Manager
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.addInput = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.computers = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.titleText2 = new System.Windows.Forms.Label();
            this.titleText1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addInput
            // 
            this.addInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addInput.Location = new System.Drawing.Point(12, 236);
            this.addInput.Name = "addInput";
            this.addInput.Size = new System.Drawing.Size(262, 20);
            this.addInput.TabIndex = 0;
            this.addInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddInputKeyPress);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(280, 234);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(23, 23);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddOnClick);
            // 
            // computers
            // 
            this.computers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.computers.FormattingEnabled = true;
            this.computers.Location = new System.Drawing.Point(12, 66);
            this.computers.Name = "computers";
            this.computers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.computers.Size = new System.Drawing.Size(381, 160);
            this.computers.TabIndex = 4;
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Location = new System.Drawing.Point(309, 234);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(25, 23);
            this.remove.TabIndex = 5;
            this.remove.Text = "-";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.RemoveOnClick);
            // 
            // up
            // 
            this.up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.up.Location = new System.Drawing.Point(340, 234);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(23, 23);
            this.up.TabIndex = 6;
            this.up.Text = "⯅";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.UpOnClick);
            // 
            // down
            // 
            this.down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.down.Location = new System.Drawing.Point(369, 233);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(24, 23);
            this.down.TabIndex = 7;
            this.down.Tag = "";
            this.down.Text = "⯆";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.DownOnClick);
            // 
            // titleText2
            // 
            this.titleText2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleText2.AutoSize = true;
            this.titleText2.BackColor = System.Drawing.Color.Transparent;
            this.titleText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleText2.Location = new System.Drawing.Point(137, 38);
            this.titleText2.Name = "titleText2";
            this.titleText2.Size = new System.Drawing.Size(137, 25);
            this.titleText2.TabIndex = 10;
            this.titleText2.Text = "List Manager";
            // 
            // titleText1
            // 
            this.titleText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleText1.AutoSize = true;
            this.titleText1.BackColor = System.Drawing.Color.Transparent;
            this.titleText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleText1.Location = new System.Drawing.Point(73, 13);
            this.titleText1.Name = "titleText1";
            this.titleText1.Size = new System.Drawing.Size(261, 25);
            this.titleText1.TabIndex = 9;
            this.titleText1.Text = "Remote Desktop Connection";
            this.titleText1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 266);
            this.Controls.Add(this.titleText2);
            this.Controls.Add(this.titleText1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.computers);
            this.Controls.Add(this.add);
            this.Controls.Add(this.addInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "ManagerForm";
            this.Text = "Remote Desktop Connection List Manager";
            this.Load += new System.EventHandler(this.ManagerFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addInput;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox computers;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Label titleText2;
        private System.Windows.Forms.Label titleText1;
    }
}







