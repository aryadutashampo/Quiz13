namespace Quiz13
{
    partial class FormUtama
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
            this.panelBG = new System.Windows.Forms.Panel();
            this.btnSearchB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BtnSearchA = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.radioButtonKRS = new System.Windows.Forms.RadioButton();
            this.radioButtonISL = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelBG.Controls.Add(this.btnSearchB);
            this.panelBG.Controls.Add(this.btnRefresh);
            this.panelBG.Controls.Add(this.BtnSearchA);
            this.panelBG.Controls.Add(this.BtnDelete);
            this.panelBG.Controls.Add(this.BtnClear);
            this.panelBG.Controls.Add(this.radioButtonKRS);
            this.panelBG.Controls.Add(this.radioButtonISL);
            this.panelBG.Controls.Add(this.radioButtonAll);
            this.panelBG.Controls.Add(this.txtID);
            this.panelBG.Controls.Add(this.txtSearch);
            this.panelBG.Controls.Add(this.labelID);
            this.panelBG.Controls.Add(this.labelSearch);
            this.panelBG.Controls.Add(this.dataGridViewMain);
            this.panelBG.Controls.Add(this.labelJudul);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(800, 469);
            this.panelBG.TabIndex = 0;
            // 
            // btnSearchB
            // 
            this.btnSearchB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchB.ForeColor = System.Drawing.Color.White;
            this.btnSearchB.Location = new System.Drawing.Point(607, 421);
            this.btnSearchB.Name = "btnSearchB";
            this.btnSearchB.Size = new System.Drawing.Size(92, 36);
            this.btnSearchB.TabIndex = 13;
            this.btnSearchB.Text = "SEARCH B";
            this.btnSearchB.UseVisualStyleBackColor = false;
            this.btnSearchB.Click += new System.EventHandler(this.btnSearchB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(409, 421);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 36);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BtnSearchA
            // 
            this.BtnSearchA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSearchA.ForeColor = System.Drawing.Color.White;
            this.BtnSearchA.Location = new System.Drawing.Point(607, 53);
            this.BtnSearchA.Name = "BtnSearchA";
            this.BtnSearchA.Size = new System.Drawing.Size(92, 36);
            this.BtnSearchA.TabIndex = 11;
            this.BtnSearchA.Text = "SEARCH A";
            this.BtnSearchA.UseVisualStyleBackColor = false;
            this.BtnSearchA.Click += new System.EventHandler(this.BtnSearchA_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(705, 421);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 36);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(526, 421);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 36);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // radioButtonKRS
            // 
            this.radioButtonKRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonKRS.AutoSize = true;
            this.radioButtonKRS.ForeColor = System.Drawing.Color.White;
            this.radioButtonKRS.Location = new System.Drawing.Point(252, 421);
            this.radioButtonKRS.Name = "radioButtonKRS";
            this.radioButtonKRS.Size = new System.Drawing.Size(68, 20);
            this.radioButtonKRS.TabIndex = 8;
            this.radioButtonKRS.TabStop = true;
            this.radioButtonKRS.Text = "Kristen";
            this.radioButtonKRS.UseVisualStyleBackColor = true;
            this.radioButtonKRS.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonISL
            // 
            this.radioButtonISL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonISL.AutoSize = true;
            this.radioButtonISL.ForeColor = System.Drawing.Color.White;
            this.radioButtonISL.Location = new System.Drawing.Point(133, 421);
            this.radioButtonISL.Name = "radioButtonISL";
            this.radioButtonISL.Size = new System.Drawing.Size(60, 20);
            this.radioButtonISL.TabIndex = 7;
            this.radioButtonISL.TabStop = true;
            this.radioButtonISL.Text = "Islam";
            this.radioButtonISL.UseVisualStyleBackColor = true;
            this.radioButtonISL.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.ForeColor = System.Drawing.Color.White;
            this.radioButtonAll.Location = new System.Drawing.Point(15, 421);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 6;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID.Location = new System.Drawing.Point(55, 380);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(97, 60);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(504, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(12, 383);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(12, 63);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(63, 16);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "SEARCH";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(775, 272);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.White;
            this.labelJudul.Location = new System.Drawing.Point(286, 23);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(232, 25);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "QUIZ PERTEMUAN 13";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.panelBG);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz pertemuan 13";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button BtnSearchA;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RadioButton radioButtonKRS;
        private System.Windows.Forms.RadioButton radioButtonISL;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchB;
    }
}

