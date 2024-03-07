namespace Lesson2_02._03._2024
{
    partial class AdministratorForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonSer = new System.Windows.Forms.Button();
            this.buttonDeSer = new System.Windows.Forms.Button();
            this.labelPersons = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 394);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.textBox3);
            this.panelInfo.Controls.Add(this.textBox2);
            this.panelInfo.Controls.Add(this.textBox1);
            this.panelInfo.Location = new System.Drawing.Point(314, 44);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(408, 338);
            this.panelInfo.TabIndex = 1;
            // 
            // buttonSer
            // 
            this.buttonSer.Location = new System.Drawing.Point(314, 388);
            this.buttonSer.Name = "buttonSer";
            this.buttonSer.Size = new System.Drawing.Size(202, 50);
            this.buttonSer.TabIndex = 2;
            this.buttonSer.Text = "сериазировать";
            this.buttonSer.UseVisualStyleBackColor = true;
            // 
            // buttonDeSer
            // 
            this.buttonDeSer.Location = new System.Drawing.Point(537, 388);
            this.buttonDeSer.Name = "buttonDeSer";
            this.buttonDeSer.Size = new System.Drawing.Size(185, 50);
            this.buttonDeSer.TabIndex = 3;
            this.buttonDeSer.Text = "десериализировать";
            this.buttonDeSer.UseVisualStyleBackColor = true;
            // 
            // labelPersons
            // 
            this.labelPersons.AutoSize = true;
            this.labelPersons.Location = new System.Drawing.Point(12, 25);
            this.labelPersons.Name = "labelPersons";
            this.labelPersons.Size = new System.Drawing.Size(71, 16);
            this.labelPersons.TabIndex = 4;
            this.labelPersons.Text = "Сущности";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(311, 25);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(92, 16);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Информация";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ТипСущности";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPersons);
            this.Controls.Add(this.buttonDeSer);
            this.Controls.Add(this.buttonSer);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.listView1);
            this.Name = "AdministratorForm";
            this.Text = "Administrator";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button buttonSer;
        private System.Windows.Forms.Button buttonDeSer;
        private System.Windows.Forms.Label labelPersons;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}