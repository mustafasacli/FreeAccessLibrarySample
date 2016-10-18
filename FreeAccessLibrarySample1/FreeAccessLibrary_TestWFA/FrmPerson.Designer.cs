namespace FreeAccessLibrary_TestWFA
{
    partial class FrmPerson
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
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytProperties = new System.Windows.Forms.TableLayoutPanel();
            this.pcbxImage = new System.Windows.Forms.PictureBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblImPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLytMain.SuspendLayout();
            this.tblLytProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).BeginInit();
            this.tblLytButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytProperties, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblLytMain.Size = new System.Drawing.Size(556, 518);
            this.tblLytMain.TabIndex = 0;
            // 
            // tblLytProperties
            // 
            this.tblLytProperties.ColumnCount = 2;
            this.tblLytProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLytProperties.Controls.Add(this.pcbxImage, 1, 3);
            this.tblLytProperties.Controls.Add(this.lblAd, 0, 0);
            this.tblLytProperties.Controls.Add(this.lblSoyad, 0, 1);
            this.tblLytProperties.Controls.Add(this.lblResim, 0, 2);
            this.tblLytProperties.Controls.Add(this.txtAd, 1, 0);
            this.tblLytProperties.Controls.Add(this.txtSoyad, 1, 1);
            this.tblLytProperties.Controls.Add(this.lblImPath, 1, 2);
            this.tblLytProperties.Controls.Add(this.btnBrowse, 1, 4);
            this.tblLytProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytProperties.Location = new System.Drawing.Point(4, 4);
            this.tblLytProperties.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytProperties.Name = "tblLytProperties";
            this.tblLytProperties.RowCount = 5;
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLytProperties.Size = new System.Drawing.Size(548, 405);
            this.tblLytProperties.TabIndex = 0;
            // 
            // pcbxImage
            // 
            this.pcbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxImage.Location = new System.Drawing.Point(168, 124);
            this.pcbxImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbxImage.Name = "pcbxImage";
            this.pcbxImage.Size = new System.Drawing.Size(376, 227);
            this.pcbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxImage.TabIndex = 0;
            this.pcbxImage.TabStop = false;
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(10, 11);
            this.lblAd.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 17);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(10, 51);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblResim
            // 
            this.lblResim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(10, 91);
            this.lblResim.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(55, 17);
            this.lblResim.TabIndex = 1;
            this.lblResim.Text = "Resim :";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.Location = new System.Drawing.Point(167, 8);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(378, 23);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyad.Location = new System.Drawing.Point(167, 48);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(378, 23);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // lblImPath
            // 
            this.lblImPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblImPath.AutoSize = true;
            this.lblImPath.Location = new System.Drawing.Point(174, 91);
            this.lblImPath.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblImPath.Name = "lblImPath";
            this.lblImPath.Size = new System.Drawing.Size(0, 17);
            this.lblImPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Location = new System.Drawing.Point(303, 363);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 34);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Resim Seç";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 3;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLytButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tblLytButtons.Controls.Add(this.btnSave, 1, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(4, 417);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(548, 97);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(427, 31);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(267, 31);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 518);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPerson";
            this.Text = "FrmPerson";
            this.Load += new System.EventHandler(this.FrmPerson_Load);
            this.tblLytMain.ResumeLayout(false);
            this.tblLytProperties.ResumeLayout(false);
            this.tblLytProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).EndInit();
            this.tblLytButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytProperties;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.PictureBox pcbxImage;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblImPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}