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
    }
}