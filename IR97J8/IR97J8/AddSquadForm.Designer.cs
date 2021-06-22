
namespace IR97J8
{
    partial class AddSquadForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LSaved = new System.Windows.Forms.Label();
            this.BNo = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.LPNumber = new System.Windows.Forms.Label();
            this.LPName = new System.Windows.Forms.Label();
            this.LSquadron = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.CBPName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LSaved);
            this.panel1.Controls.Add(this.BNo);
            this.panel1.Controls.Add(this.BAdd);
            this.panel1.Controls.Add(this.TBNumber);
            this.panel1.Controls.Add(this.LPNumber);
            this.panel1.Controls.Add(this.LPName);
            this.panel1.Controls.Add(this.LSquadron);
            this.panel1.Controls.Add(this.TBName);
            this.panel1.Controls.Add(this.CBPName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 231);
            this.panel1.TabIndex = 0;
            // 
            // LSaved
            // 
            this.LSaved.AutoSize = true;
            this.LSaved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LSaved.Location = new System.Drawing.Point(81, 204);
            this.LSaved.Name = "LSaved";
            this.LSaved.Size = new System.Drawing.Size(82, 21);
            this.LSaved.TabIndex = 8;
            this.LSaved.Text = "Elmentve";
            this.LSaved.Visible = false;
            // 
            // BNo
            // 
            this.BNo.Location = new System.Drawing.Point(169, 205);
            this.BNo.Name = "BNo";
            this.BNo.Size = new System.Drawing.Size(75, 23);
            this.BNo.TabIndex = 7;
            this.BNo.Text = "Mégse";
            this.BNo.UseVisualStyleBackColor = true;
            this.BNo.Click += new System.EventHandler(this.BNo_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(0, 205);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 6;
            this.BAdd.Text = "Hozzáadás";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(0, 133);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(244, 23);
            this.TBNumber.TabIndex = 5;
            // 
            // LPNumber
            // 
            this.LPNumber.AutoSize = true;
            this.LPNumber.Location = new System.Drawing.Point(55, 115);
            this.LPNumber.Name = "LPNumber";
            this.LPNumber.Size = new System.Drawing.Size(115, 15);
            this.LPNumber.TabIndex = 4;
            this.LPNumber.Text = "Repülőgépek száma:";
            // 
            // LPName
            // 
            this.LPName.AutoSize = true;
            this.LPName.Location = new System.Drawing.Point(75, 52);
            this.LPName.Name = "LPName";
            this.LPName.Size = new System.Drawing.Size(95, 15);
            this.LPName.TabIndex = 3;
            this.LPName.Text = "Repülőgép neve:";
            // 
            // LSquadron
            // 
            this.LSquadron.AutoSize = true;
            this.LSquadron.Location = new System.Drawing.Point(75, 2);
            this.LSquadron.Name = "LSquadron";
            this.LSquadron.Size = new System.Drawing.Size(77, 15);
            this.LSquadron.TabIndex = 2;
            this.LSquadron.Text = "Szakasz neve:";
            this.LSquadron.Click += new System.EventHandler(this.LSquadron_Click);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(0, 20);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(244, 23);
            this.TBName.TabIndex = 1;
            // 
            // CBPName
            // 
            this.CBPName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPName.FormattingEnabled = true;
            this.CBPName.Location = new System.Drawing.Point(0, 70);
            this.CBPName.Name = "CBPName";
            this.CBPName.Size = new System.Drawing.Size(244, 23);
            this.CBPName.TabIndex = 0;
            // 
            // AddSquadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 255);
            this.Controls.Add(this.panel1);
            this.Name = "AddSquadForm";
            this.Text = "AddSquadForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LPName;
        private System.Windows.Forms.Label LSquadron;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.ComboBox CBPName;
        private System.Windows.Forms.Label LPNumber;
        private System.Windows.Forms.Label LSaved;
        private System.Windows.Forms.Button BNo;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TBNumber;
    }
}