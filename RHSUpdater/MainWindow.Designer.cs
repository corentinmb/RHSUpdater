namespace RHSUpdater
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.USAFPB = new System.Windows.Forms.PictureBox();
            this.AFRFPB = new System.Windows.Forms.PictureBox();
            this.GREFPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stateAFRF = new System.Windows.Forms.PictureBox();
            this.stateUSAF = new System.Windows.Forms.PictureBox();
            this.stateGREF = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.MAJButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.FolderAFRFButton = new System.Windows.Forms.Button();
            this.FolderUSAFButton = new System.Windows.Forms.Button();
            this.FolderGREFButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.USAFPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFRFPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREFPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAFRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateUSAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateGREF)).BeginInit();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Location = new System.Drawing.Point(12, 268);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(460, 234);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            // 
            // USAFPB
            // 
            this.USAFPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.USAFPB.Location = new System.Drawing.Point(12, 92);
            this.USAFPB.Name = "USAFPB";
            this.USAFPB.Size = new System.Drawing.Size(77, 74);
            this.USAFPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USAFPB.TabIndex = 8;
            this.USAFPB.TabStop = false;
            // 
            // AFRFPB
            // 
            this.AFRFPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AFRFPB.Location = new System.Drawing.Point(12, 12);
            this.AFRFPB.Name = "AFRFPB";
            this.AFRFPB.Size = new System.Drawing.Size(77, 74);
            this.AFRFPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AFRFPB.TabIndex = 7;
            this.AFRFPB.TabStop = false;
            // 
            // GREFPB
            // 
            this.GREFPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GREFPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GREFPB.Location = new System.Drawing.Point(12, 172);
            this.GREFPB.Name = "GREFPB";
            this.GREFPB.Size = new System.Drawing.Size(77, 74);
            this.GREFPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GREFPB.TabIndex = 6;
            this.GREFPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RHS: AFRF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RHS: USAF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RHS: GREF";
            // 
            // stateAFRF
            // 
            this.stateAFRF.Location = new System.Drawing.Point(431, 42);
            this.stateAFRF.Name = "stateAFRF";
            this.stateAFRF.Size = new System.Drawing.Size(16, 16);
            this.stateAFRF.TabIndex = 12;
            this.stateAFRF.TabStop = false;
            // 
            // stateUSAF
            // 
            this.stateUSAF.Location = new System.Drawing.Point(431, 126);
            this.stateUSAF.Name = "stateUSAF";
            this.stateUSAF.Size = new System.Drawing.Size(16, 16);
            this.stateUSAF.TabIndex = 13;
            this.stateUSAF.TabStop = false;
            // 
            // stateGREF
            // 
            this.stateGREF.Location = new System.Drawing.Point(431, 199);
            this.stateGREF.Name = "stateGREF";
            this.stateGREF.Size = new System.Drawing.Size(16, 16);
            this.stateGREF.TabIndex = 14;
            this.stateGREF.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "arma3.exe|arma3.exe";
            // 
            // MAJButton
            // 
            this.MAJButton.Enabled = false;
            this.MAJButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAJButton.Location = new System.Drawing.Point(12, 508);
            this.MAJButton.Name = "MAJButton";
            this.MAJButton.Size = new System.Drawing.Size(242, 48);
            this.MAJButton.TabIndex = 15;
            this.MAJButton.Text = "Installer/Mettre à jour";
            this.MAJButton.UseVisualStyleBackColor = true;
            this.MAJButton.Click += new System.EventHandler(this.MAJButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.Enabled = false;
            this.RepairButton.ForeColor = System.Drawing.Color.Red;
            this.RepairButton.Location = new System.Drawing.Point(365, 522);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(107, 23);
            this.RepairButton.TabIndex = 16;
            this.RepairButton.Text = "Réparer les mods";
            this.RepairButton.UseVisualStyleBackColor = true;
            // 
            // FolderAFRFButton
            // 
            this.FolderAFRFButton.Location = new System.Drawing.Point(324, 40);
            this.FolderAFRFButton.Name = "FolderAFRFButton";
            this.FolderAFRFButton.Size = new System.Drawing.Size(101, 23);
            this.FolderAFRFButton.TabIndex = 17;
            this.FolderAFRFButton.Text = "Dossier du mod";
            this.FolderAFRFButton.UseVisualStyleBackColor = true;
            this.FolderAFRFButton.Click += new System.EventHandler(this.FolderAFRFButton_Click);
            // 
            // FolderUSAFButton
            // 
            this.FolderUSAFButton.Location = new System.Drawing.Point(324, 121);
            this.FolderUSAFButton.Name = "FolderUSAFButton";
            this.FolderUSAFButton.Size = new System.Drawing.Size(101, 23);
            this.FolderUSAFButton.TabIndex = 20;
            this.FolderUSAFButton.Text = "Dossier du mod";
            this.FolderUSAFButton.UseVisualStyleBackColor = true;
            this.FolderUSAFButton.Click += new System.EventHandler(this.FolderUSAFButton_Click);
            // 
            // FolderGREFButton
            // 
            this.FolderGREFButton.Location = new System.Drawing.Point(324, 197);
            this.FolderGREFButton.Name = "FolderGREFButton";
            this.FolderGREFButton.Size = new System.Drawing.Size(101, 23);
            this.FolderGREFButton.TabIndex = 21;
            this.FolderGREFButton.Text = "Dossier du mod";
            this.FolderGREFButton.UseVisualStyleBackColor = true;
            this.FolderGREFButton.Click += new System.EventHandler(this.FolderGREFButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(402, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@corentinmb";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.FolderGREFButton);
            this.Controls.Add(this.FolderUSAFButton);
            this.Controls.Add(this.FolderAFRFButton);
            this.Controls.Add(this.RepairButton);
            this.Controls.Add(this.MAJButton);
            this.Controls.Add(this.stateGREF);
            this.Controls.Add(this.stateUSAF);
            this.Controls.Add(this.stateAFRF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USAFPB);
            this.Controls.Add(this.AFRFPB);
            this.Controls.Add(this.GREFPB);
            this.Controls.Add(this.logBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "RHSUpdater";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USAFPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AFRFPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREFPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAFRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateUSAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateGREF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.PictureBox USAFPB;
        private System.Windows.Forms.PictureBox AFRFPB;
        private System.Windows.Forms.PictureBox GREFPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox stateAFRF;
        private System.Windows.Forms.PictureBox stateUSAF;
        private System.Windows.Forms.PictureBox stateGREF;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button MAJButton;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.Button FolderAFRFButton;
        private System.Windows.Forms.Button FolderUSAFButton;
        private System.Windows.Forms.Button FolderGREFButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

