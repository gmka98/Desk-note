namespace Desk_Note
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bttCreate = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(63, 62);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(63, 167);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(50, 13);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Message";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(103, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "dcddccdd";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(112, 193);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(234, 143);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "cd";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // bttCreate
            // 
            this.bttCreate.Location = new System.Drawing.Point(112, 374);
            this.bttCreate.Name = "bttCreate";
            this.bttCreate.Size = new System.Drawing.Size(99, 34);
            this.bttCreate.TabIndex = 4;
            this.bttCreate.Text = "Create";
            this.bttCreate.UseVisualStyleBackColor = true;
            this.bttCreate.Click += new System.EventHandler(this.bttCreate_Click);
            // 
            // bttRead
            // 
            this.bttRead.Location = new System.Drawing.Point(269, 373);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(99, 35);
            this.bttRead.TabIndex = 5;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(584, 375);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(99, 33);
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(198, 273);
            this.dataGridView1.TabIndex = 8;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(426, 373);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(113, 36);
            this.bttSave.TabIndex = 9;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 467);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttCreate);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button bttCreate;
        private System.Windows.Forms.Button bttRead;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttSave;
    }
}

