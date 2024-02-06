namespace Premier_Service_Solutionsv2.Forms
{
    partial class FormOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOut));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddExisting = new System.Windows.Forms.Button();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnAddExisting);
            this.panel1.Controls.Add(this.btnSubmitRequest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(423, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 244);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 415);
            this.panel2.TabIndex = 2;
            // 
            // btnAddExisting
            // 
            this.btnAddExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddExisting.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExisting.Image")));
            this.btnAddExisting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExisting.Location = new System.Drawing.Point(303, 140);
            this.btnAddExisting.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExisting.Name = "btnAddExisting";
            this.btnAddExisting.Size = new System.Drawing.Size(209, 54);
            this.btnAddExisting.TabIndex = 23;
            this.btnAddExisting.Text = "No";
            this.btnAddExisting.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitRequest.Image")));
            this.btnSubmitRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitRequest.Location = new System.Drawing.Point(77, 140);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(209, 54);
            this.btnSubmitRequest.TabIndex = 24;
            this.btnSubmitRequest.Text = "Yes";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 415);
            this.Controls.Add(this.panel2);
            this.Name = "FormOut";
            this.Text = "LOG OUT";
            this.Load += new System.EventHandler(this.FormOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddExisting;
        private System.Windows.Forms.Button btnSubmitRequest;
    }
}