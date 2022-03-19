namespace Katlı_Sıralama_Uygulaması
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDivisibleTerm = new System.Windows.Forms.ComboBox();
            this.txtDivisibleNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.chItalic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFrom.Location = new System.Drawing.Point(290, 111);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(148, 26);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(524, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTo.Location = new System.Drawing.Point(588, 112);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(148, 26);
            this.txtTo.TabIndex = 1;
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCount.Location = new System.Drawing.Point(290, 248);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(176, 75);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(562, 248);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 75);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Divisible Term";
            // 
            // cmbDivisibleTerm
            // 
            this.cmbDivisibleTerm.FormattingEnabled = true;
            this.cmbDivisibleTerm.Location = new System.Drawing.Point(290, 185);
            this.cmbDivisibleTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            this.cmbDivisibleTerm.Size = new System.Drawing.Size(180, 28);
            this.cmbDivisibleTerm.TabIndex = 2;
            this.cmbDivisibleTerm.SelectedIndexChanged += new System.EventHandler(this.cmbDivisibleTerm_SelectedIndexChanged);
            this.cmbDivisibleTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDivisibleTerm_KeyPress);
            // 
            // txtDivisibleNumber
            // 
            this.txtDivisibleNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDivisibleNumber.Location = new System.Drawing.Point(0, 345);
            this.txtDivisibleNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDivisibleNumber.Multiline = true;
            this.txtDivisibleNumber.Name = "txtDivisibleNumber";
            this.txtDivisibleNumber.Size = new System.Drawing.Size(1102, 239);
            this.txtDivisibleNumber.TabIndex = 8;
            this.txtDivisibleNumber.TextChanged += new System.EventHandler(this.txtDivisibleNumber_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Controls.Add(this.rbBlue);
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Controls.Add(this.rbBlack);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(808, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBlack.Location = new System.Drawing.Point(0, 19);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(65, 21);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRed.Location = new System.Drawing.Point(0, 46);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(55, 21);
            this.rbRed.TabIndex = 1;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBlue.Location = new System.Drawing.Point(0, 73);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(58, 21);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGreen.Location = new System.Drawing.Point(0, 100);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(71, 21);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // chBold
            // 
            this.chBold.AutoSize = true;
            this.chBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBold.Location = new System.Drawing.Point(12, 265);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(64, 24);
            this.chBold.TabIndex = 4;
            this.chBold.Text = "Bold";
            this.chBold.UseVisualStyleBackColor = true;
            this.chBold.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
            // 
            // chItalic
            // 
            this.chItalic.AutoSize = true;
            this.chItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chItalic.Location = new System.Drawing.Point(83, 266);
            this.chItalic.Name = "chItalic";
            this.chItalic.Size = new System.Drawing.Size(61, 24);
            this.chItalic.TabIndex = 5;
            this.chItalic.Text = "Italic";
            this.chItalic.UseVisualStyleBackColor = true;
            this.chItalic.CheckedChanged += new System.EventHandler(this.chItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 584);
            this.Controls.Add(this.chBold);
            this.Controls.Add(this.chItalic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDivisibleNumber);
            this.Controls.Add(this.cmbDivisibleTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDivisibleTerm;
        private System.Windows.Forms.TextBox txtDivisibleNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
    }
}

