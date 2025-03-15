namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblMsg = new Label();
            txtTitle = new TextBox();
            txtMsg = new TextBox();
            dataGridView1 = new DataGridView();
            btnNew = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(77, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(42, 121);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(96, 25);
            lblMsg.TabIndex = 1;
            lblMsg.Text = "Message:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(255, 255, 128);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Bradley Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(138, 51);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 22);
            txtTitle.TabIndex = 2;
            // 
            // txtMsg
            // 
            txtMsg.BackColor = Color.FromArgb(255, 255, 128);
            txtMsg.BorderStyle = BorderStyle.None;
            txtMsg.Font = new Font("Bradley Hand ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMsg.Location = new Point(138, 121);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.ScrollBars = ScrollBars.Vertical;
            txtMsg.Size = new Size(200, 235);
            txtMsg.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(255, 255, 128);
            dataGridView1.Location = new Point(356, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(202, 305);
            dataGridView1.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 255, 192);
            btnNew.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(138, 405);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(255, 255, 192);
            btnRead.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(356, 405);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 6;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(464, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(244, 405);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(586, 473);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMsg);
            Controls.Add(txtTitle);
            Controls.Add(lblMsg);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Note App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMsg;
        private TextBox txtTitle;
        private TextBox txtMsg;
        private DataGridView dataGridView1;
        private Button btnNew;
        private Button btnRead;
        private Button btnDelete;
        private Button btnSave;
    }
}
