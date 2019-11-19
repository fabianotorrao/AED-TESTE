namespace ex2
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
            this.tasks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.task = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pending_tasks = new System.Windows.Forms.TextBox();
            this.path_file = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasks
            // 
            this.tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks.FormattingEnabled = true;
            this.tasks.ItemHeight = 18;
            this.tasks.Location = new System.Drawing.Point(45, 16);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(175, 274);
            this.tasks.TabIndex = 0;
            this.tasks.SelectedIndexChanged += new System.EventHandler(this.tasks_SelectedIndexChanged);
            this.tasks.ClientSizeChanged += new System.EventHandler(this.tasks_ClientSizeChanged);
            this.tasks.SizeChanged += new System.EventHandler(this.tasks_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tasks);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.task);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(330, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(62, 44);
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Size = new System.Drawing.Size(132, 20);
            this.task.TabIndex = 1;
            this.task.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task : ";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(274, 183);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 30);
            this.add.TabIndex = 3;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Enabled = false;
            this.remove.Location = new System.Drawing.Point(361, 183);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(81, 30);
            this.remove.TabIndex = 4;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(448, 183);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(81, 30);
            this.clear.TabIndex = 5;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(274, 219);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(81, 30);
            this.upload.TabIndex = 6;
            this.upload.Text = "UPLOAD";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(361, 219);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(81, 30);
            this.download.TabIndex = 7;
            this.download.Text = "DOWNLOAD";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(448, 219);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(81, 30);
            this.order.TabIndex = 8;
            this.order.Text = "ORDER";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pending tasks :";
            // 
            // pending_tasks
            // 
            this.pending_tasks.Location = new System.Drawing.Point(358, 303);
            this.pending_tasks.Name = "pending_tasks";
            this.pending_tasks.ReadOnly = true;
            this.pending_tasks.Size = new System.Drawing.Size(41, 20);
            this.pending_tasks.TabIndex = 10;
            // 
            // path_file
            // 
            this.path_file.FileName = "uplaod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 348);
            this.Controls.Add(this.pending_tasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order);
            this.Controls.Add(this.download);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pending_tasks;
        private System.Windows.Forms.OpenFileDialog path_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

