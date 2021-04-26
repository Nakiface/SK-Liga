
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
            this.panelLeague = new System.Windows.Forms.Panel();
            this.dataGridViewLeague = new System.Windows.Forms.DataGridView();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLeague.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelMenu.UseWaitCursor = true;
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
            this.panelLeague.UseWaitCursor = true;
            // 
            // dataGridViewLeague
            // 
            this.dataGridViewLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLeague.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeague.Location = new System.Drawing.Point(4, 39);
            this.dataGridViewLeague.Name = "dataGridViewLeague";
            this.dataGridViewLeague.RowHeadersWidth = 62;
            this.dataGridViewLeague.RowTemplate.Height = 28;
            this.dataGridViewLeague.Size = new System.Drawing.Size(625, 950);
            this.dataGridViewLeague.TabIndex = 1;
            this.dataGridViewLeague.UseWaitCursor = true;
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
            this.comboBoxGame.UseWaitCursor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = global::SK_Liga.Properties.Resources.Settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.Location = new System.Drawing.Point(493, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(136, 136);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.UseWaitCursor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImage = global::SK_Liga.Properties.Resources.Profile;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Location = new System.Drawing.Point(351, 4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(136, 136);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.UseWaitCursor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.White;
            this.buttonRecord.BackgroundImage = global::SK_Liga.Properties.Resources.NewFile;
            this.buttonRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecord.Location = new System.Drawing.Point(209, 4);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(136, 136);
            this.buttonRecord.TabIndex = 1;
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.UseWaitCursor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SK_Liga.Properties.Resources.LogoSK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 1167);
            this.Controls.Add(this.panelLeague);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.UseWaitCursor = true;
            this.panelMenu.ResumeLayout(false);
            this.panelLeague.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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