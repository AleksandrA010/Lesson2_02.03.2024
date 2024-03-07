namespace Lesson2_02._03._2024
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node1_1");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node1_2");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Врачи", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node2_1");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node2_2");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Пациенты", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node3_1");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node3_2");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Администрация", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeApp = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeInfo = new System.Windows.Forms.TreeView();
            this.pictureTree = new System.Windows.Forms.PictureBox();
            this.OpenInfo = new System.Windows.Forms.Button();
            this.CloseInfo = new System.Windows.Forms.Button();
            this.OpenAdminstForm = new System.Windows.Forms.Button();
            this.tableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTree)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.MinimizeApp);
            this.Header.Controls.Add(this.ExitApp);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1020, 30);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MedBook";
            // 
            // MinimizeApp
            // 
            this.MinimizeApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeApp.FlatAppearance.BorderSize = 0;
            this.MinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeApp.ForeColor = System.Drawing.Color.White;
            this.MinimizeApp.Location = new System.Drawing.Point(960, 0);
            this.MinimizeApp.Name = "MinimizeApp";
            this.MinimizeApp.Size = new System.Drawing.Size(30, 30);
            this.MinimizeApp.TabIndex = 1;
            this.MinimizeApp.Text = "−";
            this.MinimizeApp.UseVisualStyleBackColor = true;
            this.MinimizeApp.Click += new System.EventHandler(this.MinimizeApp_Click);
            this.MinimizeApp.MouseEnter += new System.EventHandler(this.MinimizeApp_MouseEnter);
            this.MinimizeApp.MouseLeave += new System.EventHandler(this.MinimizeApp_MouseLeave);
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitApp.FlatAppearance.BorderSize = 0;
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.ForeColor = System.Drawing.Color.White;
            this.ExitApp.Location = new System.Drawing.Point(990, 0);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(30, 30);
            this.ExitApp.TabIndex = 0;
            this.ExitApp.Text = "X";
            this.ExitApp.UseVisualStyleBackColor = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            this.ExitApp.MouseEnter += new System.EventHandler(this.ExitApp_MouseEnter);
            this.ExitApp.MouseLeave += new System.EventHandler(this.ExitApp_MouseLeave);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 36);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainSplitContainer.Panel1.Controls.Add(this.treeInfo);
            this.MainSplitContainer.Panel1.Controls.Add(this.pictureTree);
            this.MainSplitContainer.Panel1MinSize = 200;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainSplitContainer.Panel2.Controls.Add(this.OpenInfo);
            this.MainSplitContainer.Panel2.Controls.Add(this.CloseInfo);
            this.MainSplitContainer.Panel2.Controls.Add(this.OpenAdminstForm);
            this.MainSplitContainer.Panel2.Controls.Add(this.tableInfo);
            this.MainSplitContainer.Panel2MinSize = 350;
            this.MainSplitContainer.Size = new System.Drawing.Size(1020, 552);
            this.MainSplitContainer.SplitterDistance = 337;
            this.MainSplitContainer.SplitterWidth = 5;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // treeInfo
            // 
            this.treeInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeInfo.Location = new System.Drawing.Point(13, 140);
            this.treeInfo.Name = "treeInfo";
            treeNode19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode19.Name = "Node1_1";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode19.Text = "Node1_1";
            treeNode20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode20.Name = "Node1_2";
            treeNode20.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode20.Text = "Node1_2";
            treeNode21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode21.Name = "NodeMain1";
            treeNode21.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode21.Text = "Врачи";
            treeNode22.Name = "Node2_1";
            treeNode22.Text = "Node2_1";
            treeNode23.Name = "Node2_2";
            treeNode23.Text = "Node2_2";
            treeNode24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode24.Name = "NodeMain2";
            treeNode24.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode24.Text = "Пациенты";
            treeNode25.Name = "Node3_1";
            treeNode25.Text = "Node3_1";
            treeNode26.Name = "Node3_1";
            treeNode26.Text = "Node3_2";
            treeNode27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode27.Name = "NodeMain3";
            treeNode27.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode27.Text = "Администрация";
            this.treeInfo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24,
            treeNode27});
            this.treeInfo.Size = new System.Drawing.Size(314, 409);
            this.treeInfo.TabIndex = 1;
            // 
            // pictureTree
            // 
            this.pictureTree.Image = global::Lesson2_02._03._2024.Properties.Resources.tree;
            this.pictureTree.Location = new System.Drawing.Point(13, 13);
            this.pictureTree.Name = "pictureTree";
            this.pictureTree.Size = new System.Drawing.Size(120, 120);
            this.pictureTree.TabIndex = 0;
            this.pictureTree.TabStop = false;
            // 
            // OpenInfo
            // 
            this.OpenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenInfo.Location = new System.Drawing.Point(194, 27);
            this.OpenInfo.Name = "OpenInfo";
            this.OpenInfo.Size = new System.Drawing.Size(150, 67);
            this.OpenInfo.TabIndex = 3;
            this.OpenInfo.Text = "Показать информацию о больнице";
            this.OpenInfo.UseVisualStyleBackColor = true;
            // 
            // CloseInfo
            // 
            this.CloseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseInfo.Location = new System.Drawing.Point(350, 27);
            this.CloseInfo.Name = "CloseInfo";
            this.CloseInfo.Size = new System.Drawing.Size(155, 67);
            this.CloseInfo.TabIndex = 2;
            this.CloseInfo.Text = "Закрыть информацию";
            this.CloseInfo.UseVisualStyleBackColor = true;
            // 
            // OpenAdminstForm
            // 
            this.OpenAdminstForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAdminstForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenAdminstForm.Location = new System.Drawing.Point(511, 27);
            this.OpenAdminstForm.Name = "OpenAdminstForm";
            this.OpenAdminstForm.Size = new System.Drawing.Size(153, 67);
            this.OpenAdminstForm.TabIndex = 1;
            this.OpenAdminstForm.Text = "Открыть меню администратора";
            this.OpenAdminstForm.UseVisualStyleBackColor = true;
            this.OpenAdminstForm.Click += new System.EventHandler(this.OpenAdminstForm_Click);
            // 
            // tableInfo
            // 
            this.tableInfo.ColumnCount = 2;
            this.tableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 442F));
            this.tableInfo.Location = new System.Drawing.Point(22, 140);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.RowCount = 5;
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableInfo.Size = new System.Drawing.Size(642, 412);
            this.tableInfo.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.Header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button MinimizeApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox pictureTree;
        private System.Windows.Forms.TreeView treeInfo;
        private System.Windows.Forms.TableLayoutPanel tableInfo;
        private System.Windows.Forms.Button OpenInfo;
        private System.Windows.Forms.Button CloseInfo;
        private System.Windows.Forms.Button OpenAdminstForm;
    }
}

