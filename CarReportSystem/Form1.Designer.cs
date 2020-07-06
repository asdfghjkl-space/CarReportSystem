namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpen1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btOpen2 = new System.Windows.Forms.Button();
            this.btDelete1 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "記録者:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(62, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(115, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(230, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "外車";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(172, 17);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 16);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "スバル";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(283, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "車名:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(77, 173);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(367, 107);
            this.tbMemo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "レポート:";
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(77, 286);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowTemplate.Height = 21;
            this.dgvPerson.Size = new System.Drawing.Size(711, 152);
            this.dgvPerson.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "記事一覧:";
            // 
            // btOpen1
            // 
            this.btOpen1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen1.Location = new System.Drawing.Point(12, 301);
            this.btOpen1.Name = "btOpen1";
            this.btOpen1.Size = new System.Drawing.Size(59, 32);
            this.btOpen1.TabIndex = 19;
            this.btOpen1.Text = "開く";
            this.btOpen1.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 339);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(59, 34);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEnd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btEnd.Location = new System.Drawing.Point(691, 444);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(97, 23);
            this.btEnd.TabIndex = 21;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = false;
            // 
            // btOpen2
            // 
            this.btOpen2.Location = new System.Drawing.Point(610, 12);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(75, 23);
            this.btOpen2.TabIndex = 22;
            this.btOpen2.Text = "開く";
            this.btOpen2.UseVisualStyleBackColor = true;
            // 
            // btDelete1
            // 
            this.btDelete1.Location = new System.Drawing.Point(699, 12);
            this.btDelete1.Name = "btDelete1";
            this.btDelete1.Size = new System.Drawing.Size(75, 23);
            this.btDelete1.TabIndex = 23;
            this.btDelete1.Text = "削除";
            this.btDelete1.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(484, 257);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 23);
            this.btAdd.TabIndex = 24;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(586, 257);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(99, 23);
            this.btModify.TabIndex = 25;
            this.btModify.Text = "修正";
            this.btModify.UseVisualStyleBackColor = true;
            // 
            // btDelete2
            // 
            this.btDelete2.Location = new System.Drawing.Point(691, 257);
            this.btDelete2.Name = "btDelete2";
            this.btDelete2.Size = new System.Drawing.Size(97, 23);
            this.btDelete2.TabIndex = 26;
            this.btDelete2.Text = "削除";
            this.btDelete2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "画像:";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Aqua;
            this.pbImage.Location = new System.Drawing.Point(542, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(232, 210);
            this.pbImage.TabIndex = 28;
            this.pbImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(77, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 53);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btDelete2);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete1);
            this.Controls.Add(this.btOpen2);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpen1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btOpen2;
        private System.Windows.Forms.Button btDelete1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

