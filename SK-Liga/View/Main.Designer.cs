
namespace SK_Liga.View
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeague = new System.Windows.Forms.Panel();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.dataGridViewLeague = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeague.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonRecord);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(13, 13);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(633, 143);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(478, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(136, 136);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "button3";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(336, 4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(136, 136);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "button2";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(194, 4);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(136, 136);
            this.buttonRecord.TabIndex = 1;
            this.buttonRecord.Text = "button1";
            this.buttonRecord.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SK_Liga.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLeague
            // 
            this.panelLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeague.Controls.Add(this.dataGridViewLeague);
            this.panelLeague.Controls.Add(this.comboBoxGame);
            this.panelLeague.Location = new System.Drawing.Point(13, 163);
            this.panelLeague.Name = "panelLeague";
            this.panelLeague.Size = new System.Drawing.Size(633, 992);
            this.panelLeague.TabIndex = 1;
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(4, 4);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(625, 28);
            this.comboBoxGame.TabIndex = 0;
            // 
            // dataGridViewLeague
            // 
            this.dataGridViewLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeague.Location = new System.Drawing.Point(4, 39);
            this.dataGridViewLeague.Name = "dataGridViewLeague";
            this.dataGridViewLeague.RowHeadersWidth = 62;
            this.dataGridViewLeague.RowTemplate.Height = 28;
            this.dataGridViewLeague.Size = new System.Drawing.Size(625, 950);
            this.dataGridViewLeague.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 1167);
            this.Controls.Add(this.panelLeague);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeague.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeague;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.DataGridView dataGridViewLeague;
        private System.Windows.Forms.ComboBox comboBoxGame;
    }
}