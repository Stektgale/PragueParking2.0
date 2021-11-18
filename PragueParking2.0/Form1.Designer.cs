namespace PragueParking2._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SaveData = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_ShowVehicles = new System.Windows.Forms.Button();
            this.btn_MoveVehicle = new System.Windows.Forms.Button();
            this.btn_RemoveVehicle = new System.Windows.Forms.Button();
            this.btn_SearchVehicle = new System.Windows.Forms.Button();
            this.btn_AddVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prague Parking 2.0";
            // 
            // btn_SaveData
            // 
            this.btn_SaveData.Location = new System.Drawing.Point(12, 378);
            this.btn_SaveData.Name = "btn_SaveData";
            this.btn_SaveData.Size = new System.Drawing.Size(148, 60);
            this.btn_SaveData.TabIndex = 6;
            this.btn_SaveData.Text = "Save Data";
            this.btn_SaveData.UseVisualStyleBackColor = true;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(189, 378);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(148, 60);
            this.btn_OpenFile.TabIndex = 7;
            this.btn_OpenFile.Text = "Open File Directory";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            // 
            // btn_ShowVehicles
            // 
            this.btn_ShowVehicles.Location = new System.Drawing.Point(539, 117);
            this.btn_ShowVehicles.Name = "btn_ShowVehicles";
            this.btn_ShowVehicles.Size = new System.Drawing.Size(148, 60);
            this.btn_ShowVehicles.TabIndex = 4;
            this.btn_ShowVehicles.Text = "Show All Vehicles";
            this.btn_ShowVehicles.UseVisualStyleBackColor = true;
            // 
            // btn_MoveVehicle
            // 
            this.btn_MoveVehicle.Location = new System.Drawing.Point(364, 117);
            this.btn_MoveVehicle.Name = "btn_MoveVehicle";
            this.btn_MoveVehicle.Size = new System.Drawing.Size(148, 60);
            this.btn_MoveVehicle.TabIndex = 3;
            this.btn_MoveVehicle.Text = "Move Vehicle";
            this.btn_MoveVehicle.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveVehicle
            // 
            this.btn_RemoveVehicle.Location = new System.Drawing.Point(189, 117);
            this.btn_RemoveVehicle.Name = "btn_RemoveVehicle";
            this.btn_RemoveVehicle.Size = new System.Drawing.Size(148, 60);
            this.btn_RemoveVehicle.TabIndex = 2;
            this.btn_RemoveVehicle.Text = "Remove Vehicle";
            this.btn_RemoveVehicle.UseVisualStyleBackColor = true;
            this.btn_RemoveVehicle.Click += new System.EventHandler(this.btn_RemoveVehicle_Click);
            // 
            // btn_SearchVehicle
            // 
            this.btn_SearchVehicle.Location = new System.Drawing.Point(12, 201);
            this.btn_SearchVehicle.Name = "btn_SearchVehicle";
            this.btn_SearchVehicle.Size = new System.Drawing.Size(148, 60);
            this.btn_SearchVehicle.TabIndex = 5;
            this.btn_SearchVehicle.Text = "Search For Vehicle";
            this.btn_SearchVehicle.UseVisualStyleBackColor = true;
            // 
            // btn_AddVehicle
            // 
            this.btn_AddVehicle.Location = new System.Drawing.Point(12, 117);
            this.btn_AddVehicle.Name = "btn_AddVehicle";
            this.btn_AddVehicle.Size = new System.Drawing.Size(148, 60);
            this.btn_AddVehicle.TabIndex = 8;
            this.btn_AddVehicle.Text = "Add Vehicle";
            this.btn_AddVehicle.UseVisualStyleBackColor = true;
            this.btn_AddVehicle.Click += new System.EventHandler(this.btn_AddVehicle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddVehicle);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_SaveData);
            this.Controls.Add(this.btn_SearchVehicle);
            this.Controls.Add(this.btn_ShowVehicles);
            this.Controls.Add(this.btn_MoveVehicle);
            this.Controls.Add(this.btn_RemoveVehicle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_SaveData;
        private Button btn_OpenFile;
        private Button btn_ShowVehicles;
        private Button btn_MoveVehicle;
        private Button btn_RemoveVehicle;
        private Button btn_SearchVehicle;
        private Button btn_AddVehicle;
    }
}