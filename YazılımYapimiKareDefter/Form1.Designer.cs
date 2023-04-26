namespace YazılımYapimiKareDefter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioNine = new System.Windows.Forms.RadioButton();
            this.radioEight = new System.Windows.Forms.RadioButton();
            this.radioSeven = new System.Windows.Forms.RadioButton();
            this.radioSix = new System.Windows.Forms.RadioButton();
            this.radioFive = new System.Windows.Forms.RadioButton();
            this.GameBoard = new System.Windows.Forms.DataGridView();
            this.grpPossibleMoves = new System.Windows.Forms.GroupBox();
            this.lblMoveCounter = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.OyunHakkında = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.grpPossibleMoves.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.radioNine);
            this.groupBox1.Controls.Add(this.radioEight);
            this.groupBox1.Controls.Add(this.radioSeven);
            this.groupBox1.Controls.Add(this.radioSix);
            this.groupBox1.Controls.Add(this.radioFive);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(157, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Modu";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(254, 362);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioNine
            // 
            this.radioNine.AutoSize = true;
            this.radioNine.BackColor = System.Drawing.Color.Transparent;
            this.radioNine.Location = new System.Drawing.Point(291, 50);
            this.radioNine.Margin = new System.Windows.Forms.Padding(4);
            this.radioNine.Name = "radioNine";
            this.radioNine.Size = new System.Drawing.Size(48, 20);
            this.radioNine.TabIndex = 0;
            this.radioNine.TabStop = true;
            this.radioNine.Text = "9x9";
            this.radioNine.UseVisualStyleBackColor = false;
            // 
            // radioEight
            // 
            this.radioEight.AutoSize = true;
            this.radioEight.BackColor = System.Drawing.Color.Transparent;
            this.radioEight.Location = new System.Drawing.Point(236, 50);
            this.radioEight.Margin = new System.Windows.Forms.Padding(4);
            this.radioEight.Name = "radioEight";
            this.radioEight.Size = new System.Drawing.Size(48, 20);
            this.radioEight.TabIndex = 0;
            this.radioEight.TabStop = true;
            this.radioEight.Text = "8x8";
            this.radioEight.UseVisualStyleBackColor = false;
            // 
            // radioSeven
            // 
            this.radioSeven.AutoSize = true;
            this.radioSeven.BackColor = System.Drawing.Color.Transparent;
            this.radioSeven.Location = new System.Drawing.Point(167, 50);
            this.radioSeven.Margin = new System.Windows.Forms.Padding(4);
            this.radioSeven.Name = "radioSeven";
            this.radioSeven.Size = new System.Drawing.Size(48, 20);
            this.radioSeven.TabIndex = 0;
            this.radioSeven.TabStop = true;
            this.radioSeven.Text = "7x7";
            this.radioSeven.UseVisualStyleBackColor = false;
            // 
            // radioSix
            // 
            this.radioSix.AutoSize = true;
            this.radioSix.BackColor = System.Drawing.Color.Transparent;
            this.radioSix.Location = new System.Drawing.Point(97, 50);
            this.radioSix.Margin = new System.Windows.Forms.Padding(4);
            this.radioSix.Name = "radioSix";
            this.radioSix.Size = new System.Drawing.Size(48, 20);
            this.radioSix.TabIndex = 0;
            this.radioSix.TabStop = true;
            this.radioSix.Text = "6x6";
            this.radioSix.UseVisualStyleBackColor = false;
            // 
            // radioFive
            // 
            this.radioFive.AutoSize = true;
            this.radioFive.BackColor = System.Drawing.Color.Transparent;
            this.radioFive.Checked = true;
            this.radioFive.Location = new System.Drawing.Point(30, 50);
            this.radioFive.Margin = new System.Windows.Forms.Padding(4);
            this.radioFive.Name = "radioFive";
            this.radioFive.Size = new System.Drawing.Size(48, 20);
            this.radioFive.TabIndex = 0;
            this.radioFive.TabStop = true;
            this.radioFive.Text = "5x5";
            this.radioFive.UseVisualStyleBackColor = false;
            // 
            // GameBoard
            // 
            this.GameBoard.AllowUserToAddRows = false;
            this.GameBoard.AllowUserToDeleteRows = false;
            this.GameBoard.AllowUserToResizeColumns = false;
            this.GameBoard.AllowUserToResizeRows = false;
            this.GameBoard.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GameBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GameBoard.ColumnHeadersHeight = 10;
            this.GameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GameBoard.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GameBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.GameBoard.Location = new System.Drawing.Point(773, 132);
            this.GameBoard.Margin = new System.Windows.Forms.Padding(4);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GameBoard.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GameBoard.RowHeadersVisible = false;
            this.GameBoard.RowHeadersWidth = 60;
            this.GameBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GameBoard.RowTemplate.Height = 24;
            this.GameBoard.Size = new System.Drawing.Size(576, 501);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OyunTahtasi_CellClick);
            this.GameBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameBoard_CellContentClick);
            // 
            // grpPossibleMoves
            // 
            this.grpPossibleMoves.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPossibleMoves.BackgroundImage")));
            this.grpPossibleMoves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpPossibleMoves.Controls.Add(this.lblMoveCounter);
            this.grpPossibleMoves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPossibleMoves.Location = new System.Drawing.Point(157, 416);
            this.grpPossibleMoves.Margin = new System.Windows.Forms.Padding(4);
            this.grpPossibleMoves.Name = "grpPossibleMoves";
            this.grpPossibleMoves.Size = new System.Drawing.Size(339, 100);
            this.grpPossibleMoves.TabIndex = 1;
            this.grpPossibleMoves.TabStop = false;
            this.grpPossibleMoves.Text = "Gidilebilecek Kare Sayısı";
            this.grpPossibleMoves.Visible = false;
            // 
            // lblMoveCounter
            // 
            this.lblMoveCounter.AutoSize = true;
            this.lblMoveCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveCounter.Location = new System.Drawing.Point(27, 48);
            this.lblMoveCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoveCounter.Name = "lblMoveCounter";
            this.lblMoveCounter.Size = new System.Drawing.Size(93, 16);
            this.lblMoveCounter.TabIndex = 0;
            this.lblMoveCounter.Text = "Kontrol Sayacı";
            // 
            // grpResult
            // 
            this.grpResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpResult.BackgroundImage")));
            this.grpResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpResult.Controls.Add(this.lblGameResult);
            this.grpResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpResult.Location = new System.Drawing.Point(179, 553);
            this.grpResult.Margin = new System.Windows.Forms.Padding(4);
            this.grpResult.Name = "grpResult";
            this.grpResult.Padding = new System.Windows.Forms.Padding(4);
            this.grpResult.Size = new System.Drawing.Size(293, 100);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Oyun Durum";
            this.grpResult.Visible = false;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Location = new System.Drawing.Point(37, 50);
            this.lblGameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(86, 16);
            this.lblGameResult.TabIndex = 0;
            this.lblGameResult.Text = "Oyun Sonucu";
            // 
            // OyunHakkında
            // 
            this.OyunHakkında.AutoSize = true;
            this.OyunHakkında.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OyunHakkında.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyunHakkında.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OyunHakkında.Location = new System.Drawing.Point(145, 118);
            this.OyunHakkında.Name = "OyunHakkında";
            this.OyunHakkında.Size = new System.Drawing.Size(466, 95);
            this.OyunHakkında.TabIndex = 2;
            this.OyunHakkında.Text = "\r\nOyun Nasıl Oynanır?\r\nSatrançtaki atın hareketlerine yönelik hamleler yaparak bi" +
    "rdaha aynı\r\n kareye basmamak şartıyla atılabildiği kadar hamle oynamak\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 769);
            this.Controls.Add(this.OyunHakkında);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpPossibleMoves);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kare Defter Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.grpPossibleMoves.ResumeLayout(false);
            this.grpPossibleMoves.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton radioNine;
        private System.Windows.Forms.RadioButton radioEight;
        private System.Windows.Forms.RadioButton radioSeven;
        private System.Windows.Forms.RadioButton radioSix;
        private System.Windows.Forms.RadioButton radioFive;
        private System.Windows.Forms.DataGridView GameBoard;
        private System.Windows.Forms.GroupBox grpPossibleMoves;
        private System.Windows.Forms.Label lblMoveCounter;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.Label OyunHakkında;
    }
}

