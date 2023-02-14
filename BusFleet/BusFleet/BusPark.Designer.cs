namespace BusFleet
{
    partial class BusPark
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusPark));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetParking = new System.Windows.Forms.Button();
            this.buttonSetRoute = new System.Windows.Forms.Button();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.buttonParking = new System.Windows.Forms.Button();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteBus = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(327, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(437, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(562, 543);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(3, 494);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(318, 46);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetParking
            // 
            this.buttonSetParking.AutoSize = true;
            this.buttonSetParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetParking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonSetParking.FlatAppearance.BorderSize = 0;
            this.buttonSetParking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonSetParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetParking.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetParking.ForeColor = System.Drawing.Color.White;
            this.buttonSetParking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetParking.Location = new System.Drawing.Point(3, 382);
            this.buttonSetParking.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonSetParking.Name = "buttonSetParking";
            this.buttonSetParking.Size = new System.Drawing.Size(318, 46);
            this.buttonSetParking.TabIndex = 9;
            this.buttonSetParking.Text = "Направить на парковку";
            this.buttonSetParking.UseVisualStyleBackColor = true;
            this.buttonSetParking.Click += new System.EventHandler(this.buttonSetParking_Click);
            // 
            // buttonSetRoute
            // 
            this.buttonSetRoute.AutoSize = true;
            this.buttonSetRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonSetRoute.FlatAppearance.BorderSize = 0;
            this.buttonSetRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonSetRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetRoute.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRoute.ForeColor = System.Drawing.Color.White;
            this.buttonSetRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetRoute.Location = new System.Drawing.Point(3, 326);
            this.buttonSetRoute.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonSetRoute.Name = "buttonSetRoute";
            this.buttonSetRoute.Size = new System.Drawing.Size(318, 46);
            this.buttonSetRoute.TabIndex = 8;
            this.buttonSetRoute.Text = "Направить на маршрут";
            this.buttonSetRoute.UseVisualStyleBackColor = true;
            this.buttonSetRoute.Click += new System.EventHandler(this.buttonSetRoute_Click);
            // 
            // buttonRoute
            // 
            this.buttonRoute.AutoSize = true;
            this.buttonRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonRoute.FlatAppearance.BorderSize = 0;
            this.buttonRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoute.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoute.ForeColor = System.Drawing.Color.White;
            this.buttonRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoute.Location = new System.Drawing.Point(3, 270);
            this.buttonRoute.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(318, 46);
            this.buttonRoute.TabIndex = 7;
            this.buttonRoute.Text = "Автобусы на маршруте";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // buttonParking
            // 
            this.buttonParking.AutoSize = true;
            this.buttonParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonParking.FlatAppearance.BorderSize = 0;
            this.buttonParking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParking.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParking.ForeColor = System.Drawing.Color.White;
            this.buttonParking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParking.Location = new System.Drawing.Point(3, 214);
            this.buttonParking.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(318, 46);
            this.buttonParking.TabIndex = 6;
            this.buttonParking.Text = "Автобусы на парковке";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.Click += new System.EventHandler(this.buttonParking_Click);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.AutoSize = true;
            this.buttonAddBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonAddBus.FlatAppearance.BorderSize = 0;
            this.buttonAddBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBus.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBus.ForeColor = System.Drawing.Color.White;
            this.buttonAddBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBus.Location = new System.Drawing.Point(3, 102);
            this.buttonAddBus.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(318, 46);
            this.buttonAddBus.TabIndex = 3;
            this.buttonAddBus.Text = "Добавить автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddBus);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeleteBus);
            this.flowLayoutPanel1.Controls.Add(this.buttonParking);
            this.flowLayoutPanel1.Controls.Add(this.buttonRoute);
            this.flowLayoutPanel1.Controls.Add(this.buttonSetRoute);
            this.flowLayoutPanel1.Controls.Add(this.buttonSetParking);
            this.flowLayoutPanel1.Controls.Add(this.buttonInfo);
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 543);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 89);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 103);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colbert", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 74);
            this.label1.TabIndex = 12;
            this.label1.Text = "Автобусный\r\nпарк\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDeleteBus
            // 
            this.buttonDeleteBus.AutoSize = true;
            this.buttonDeleteBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonDeleteBus.FlatAppearance.BorderSize = 0;
            this.buttonDeleteBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonDeleteBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBus.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBus.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteBus.Location = new System.Drawing.Point(3, 158);
            this.buttonDeleteBus.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonDeleteBus.Name = "buttonDeleteBus";
            this.buttonDeleteBus.Size = new System.Drawing.Size(318, 46);
            this.buttonDeleteBus.TabIndex = 4;
            this.buttonDeleteBus.Text = "Удалить автобус";
            this.buttonDeleteBus.UseVisualStyleBackColor = true;
            this.buttonDeleteBus.Click += new System.EventHandler(this.buttonDeleteBus_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.AutoSize = true;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Colbert", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(3, 438);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(318, 46);
            this.buttonInfo.TabIndex = 11;
            this.buttonInfo.Text = "О программе";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Номер автобуса";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 107;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО водителя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 310;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер маршрута";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 108;
            // 
            // BusPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 542);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BusPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автобусный парк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDeleteBus;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.Button buttonSetParking;
        private System.Windows.Forms.Button buttonSetRoute;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

