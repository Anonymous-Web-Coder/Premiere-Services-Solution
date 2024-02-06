namespace Premier_Service_Solutionsv2.Forms
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTechnican = new System.Windows.Forms.Label();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbPriority = new System.Windows.Forms.CheckedListBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.tbxClientID = new System.Windows.Forms.TextBox();
            this.txbIncidentDescription = new System.Windows.Forms.TextBox();
            this.txbnature = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblNatureOfCall = new System.Windows.Forms.Label();
            this.lblIncidentDescr = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.btnAddExisting = new System.Windows.Forms.Button();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(383, 634);
            this.panel.TabIndex = 23;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Technican";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTechnican);
            this.panel3.Controls.Add(this.cmbTechnician);
            this.panel3.Location = new System.Drawing.Point(29, 511);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 112);
            this.panel3.TabIndex = 9;
            // 
            // lblTechnican
            // 
            this.lblTechnican.AutoSize = true;
            this.lblTechnican.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnican.Location = new System.Drawing.Point(4, 10);
            this.lblTechnican.Name = "lblTechnican";
            this.lblTechnican.Size = new System.Drawing.Size(137, 17);
            this.lblTechnican.TabIndex = 27;
            this.lblTechnican.Text = "Select Technician";
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(7, 44);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(279, 21);
            this.cmbTechnician.TabIndex = 26;
            this.cmbTechnician.SelectedIndexChanged += new System.EventHandler(this.cmbTechnician_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clbPriority);
            this.panel1.Controls.Add(this.lblClientID);
            this.panel1.Controls.Add(this.tbxClientID);
            this.panel1.Controls.Add(this.txbIncidentDescription);
            this.panel1.Controls.Add(this.txbnature);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.lblFullname);
            this.panel1.Controls.Add(this.lblNatureOfCall);
            this.panel1.Controls.Add(this.lblIncidentDescr);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(29, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 421);
            this.panel1.TabIndex = 4;
            // 
            // clbPriority
            // 
            this.clbPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.clbPriority.FormattingEnabled = true;
            this.clbPriority.Items.AddRange(new object[] {
            "Highest",
            "High",
            "Medium",
            "Low",
            "Lowest"});
            this.clbPriority.Location = new System.Drawing.Point(5, 289);
            this.clbPriority.Name = "clbPriority";
            this.clbPriority.Size = new System.Drawing.Size(120, 105);
            this.clbPriority.TabIndex = 9;
            this.clbPriority.SelectedIndexChanged += new System.EventHandler(this.clbPriority_SelectedIndexChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(3, 20);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(72, 18);
            this.lblClientID.TabIndex = 8;
            this.lblClientID.Text = "Client ID";
            // 
            // tbxClientID
            // 
            this.tbxClientID.Location = new System.Drawing.Point(5, 41);
            this.tbxClientID.Name = "tbxClientID";
            this.tbxClientID.Size = new System.Drawing.Size(169, 20);
            this.tbxClientID.TabIndex = 7;
            // 
            // txbIncidentDescription
            // 
            this.txbIncidentDescription.Location = new System.Drawing.Point(7, 200);
            this.txbIncidentDescription.Name = "txbIncidentDescription";
            this.txbIncidentDescription.Size = new System.Drawing.Size(169, 20);
            this.txbIncidentDescription.TabIndex = 6;
            // 
            // txbnature
            // 
            this.txbnature.Location = new System.Drawing.Point(7, 148);
            this.txbnature.Name = "txbnature";
            this.txbnature.Size = new System.Drawing.Size(169, 20);
            this.txbnature.TabIndex = 5;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(6, 94);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(169, 20);
            this.txbName.TabIndex = 4;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(4, 73);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(100, 18);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Client Name";
            // 
            // lblNatureOfCall
            // 
            this.lblNatureOfCall.AutoSize = true;
            this.lblNatureOfCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatureOfCall.Location = new System.Drawing.Point(3, 127);
            this.lblNatureOfCall.Name = "lblNatureOfCall";
            this.lblNatureOfCall.Size = new System.Drawing.Size(112, 18);
            this.lblNatureOfCall.TabIndex = 2;
            this.lblNatureOfCall.Text = "Nature of Call";
            this.lblNatureOfCall.Click += new System.EventHandler(this.lblNatureOfCall_Click);
            // 
            // lblIncidentDescr
            // 
            this.lblIncidentDescr.AutoSize = true;
            this.lblIncidentDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIncidentDescr.Location = new System.Drawing.Point(4, 184);
            this.lblIncidentDescr.Name = "lblIncidentDescr";
            this.lblIncidentDescr.Size = new System.Drawing.Size(309, 17);
            this.lblIncidentDescr.TabIndex = 2;
            this.lblIncidentDescr.Text = "Incident Description (what is the incident)";
            this.lblIncidentDescr.Click += new System.EventHandler(this.lblIncidentDescr_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(4, 223);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(43, 18);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Priority";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(3, 239);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2023/10/06";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Incident No. ";
            // 
            // btnEndCall
            // 
            this.btnEndCall.BackColor = System.Drawing.Color.White;
            this.btnEndCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEndCall.Image = ((System.Drawing.Image)(resources.GetObject("btnEndCall.Image")));
            this.btnEndCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndCall.Location = new System.Drawing.Point(456, 15);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(157, 44);
            this.btnEndCall.TabIndex = 20;
            this.btnEndCall.Text = "   End Call";
            this.btnEndCall.UseVisualStyleBackColor = false;
            // 
            // btnAddExisting
            // 
            this.btnAddExisting.BackColor = System.Drawing.Color.White;
            this.btnAddExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddExisting.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExisting.Image")));
            this.btnAddExisting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExisting.Location = new System.Drawing.Point(284, 15);
            this.btnAddExisting.Name = "btnAddExisting";
            this.btnAddExisting.Size = new System.Drawing.Size(157, 44);
            this.btnAddExisting.TabIndex = 21;
            this.btnAddExisting.Text = "   Add Existing";
            this.btnAddExisting.UseVisualStyleBackColor = false;
            this.btnAddExisting.Click += new System.EventHandler(this.btnAddExisting_Click);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.White;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitRequest.Image")));
            this.btnSubmitRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitRequest.Location = new System.Drawing.Point(114, 15);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(157, 44);
            this.btnSubmitRequest.TabIndex = 22;
            this.btnSubmitRequest.Text = "       Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(389, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(726, 522);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(309, -35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(379, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "🔎︎ Search Here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "🔎︎ Search Here";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnEndCall);
            this.panel2.Controls.Add(this.btnSubmitRequest);
            this.panel2.Controls.Add(this.btnAddExisting);
            this.panel2.Location = new System.Drawing.Point(389, 556);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 76);
            this.panel2.TabIndex = 25;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClient";
            this.Text = "CLIENT MAINTANCE";
            this.Load += new System.EventHandler(this.FormContractM_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label lblIncidentDescr;
        private System.Windows.Forms.Label lblNatureOfCall;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Button btnAddExisting;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTechnican;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.TextBox txbIncidentDescription;
        private System.Windows.Forms.TextBox txbnature;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox tbxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbPriority;
    }
}