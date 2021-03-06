﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        //BindingList<CarReprot> Reports = new BindingList<CarReprot>();

        public Form1()
        {
            InitializeComponent();
            //dgvPerson.DataSource = Reports;
        }

        private CarReprot.CarMaker GetCarMaker()
        {
            if (rbToyota.Checked == true)
                return CarReprot.CarMaker.トヨタ;

            if (rbNissan.Checked == true)
                return CarReprot.CarMaker.日産;

            if (rbHonda.Checked == true)
                return CarReprot.CarMaker.ホンダ;

            if (rbSubaru.Checked == true)
                return CarReprot.CarMaker.スバル;

            if (rbGaisya.Checked == true)
                return CarReprot.CarMaker.外車;

            if (rbSonota.Checked == true)
                return CarReprot.CarMaker.その他;

            return CarReprot.CarMaker.DEFAULT;

        }

        //データの追加
        private void btAdd_Click(object sender, EventArgs e)
        {
            CarReprot obj = new CarReprot
            {
                CreateDate = dateTimePicker1.Value,
                Author = cbAuthor.Text,
                Maker = GetCarMaker(),
                Name = cbName.Text,
                Report = tbMemo.Text,
                Picture = pbImage.Image
            };

            //記録者をコンボボックスの入力候補に登録
            setComboBoxName(cbAuthor.Text);

            //車名をコンボボックスの入力候補に登録
            setComboBoxCarName(cbName.Text);

            //リストの先頭に追加
            //Reports.Insert(0,obj);

            //次の入力に備えて各項目をクリア
            inputItemAllClear();
        }

        //記録者のコンボボックス入力候補
        private void setComboBoxName(string Name)
        {
            if (!cbAuthor.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(Name);
            }
        }

        //車名のコンボボックス入力候補
        private void setComboBoxCarName(string CarName)
        {
            if (!cbName.Items.Contains(CarName))
            {
                //コンボボックスの候補に追加
                cbName.Items.Add(CarName);
            }
        }

        //各項目をクリア
        private void inputItemAllClear()
        {
            cbAuthor.Text = "";

            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbGaisya.Checked = false;
            rbSonota.Checked = false;

            cbName.Text = "";
            tbMemo.Text = "";
            pbImage.Image = null;
        }


        //画像の参照
        private void btOpen2_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);

                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //画像のClear
        private void btDelete1_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                //メッセージボックスの追加
                MessageBox.Show("画像が存在しませんので、削除できません。");
                return;
            }

            //ボタンを押したら、画像をクリア
            pbImage.Image = null;
        }

        //追加済みデータの修正
        private void btModify_Click(object sender, EventArgs e)
        {
            dgvCarReport.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReport.CurrentRow.Cells[3].Value = GetCarMaker();
            dgvCarReport.CurrentRow.Cells[4].Value = cbName.Text;
            dgvCarReport.CurrentRow.Cells[5].Value = tbMemo.Text;

            if (pbImage.Image != null)
            {
                dgvCarReport.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            }
            else
            {
                dgvCarReport.CurrentRow.Cells[6].Value = null;
            }

            //データベースの更新
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202032DataSet);
        }

        private void btDelete2_Click(object sender, EventArgs e)
        {
            // 選択されている行をすべて削除（オブジェクト指定）
            foreach (DataGridViewRow row in this.dgvCarReport.SelectedRows)
            {
                this.dgvCarReport.Rows.Remove(row);
            }
        }

        //終了
        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //保存
        private void btSave_Click(object sender, EventArgs e)
        {
            //if (sfdSaveDate.ShowDialog() == DialogResult.OK)
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();

            //    using (FileStream fs = new FileStream(sfdSaveDate.FileName, FileMode.Create))
            //    {
            //        try
            //        {
            //            formatter.Serialize(fs, Reports);
            //        }
            //        catch (SerializationException se)
            //        {
            //            Console.WriteLine("Faile to serialize. Reason" + se.Message);
            //            throw;
            //        }
            //    }
            //}
        }

        //保存したファイルを開く
        private void btOpen1_Click(object sender, EventArgs e)
        {
            //if (ofdOpenDate.ShowDialog() == DialogResult.OK)
            //{
            //    using (FileStream fs = new FileStream(ofdOpenDate.FileName, FileMode.Open))
            //    {
            //        try
            //        {
            //            BinaryFormatter formatter = new BinaryFormatter();
            //            //逆シリアル化して読み込む
            //            Reports = (BindingList<CarReprot>)formatter.Deserialize(fs);
            //            //データグリッドビューに再設定
            //            dgvPerson.DataSource = Reports;
            //            ////選択されている箇所を各コントロールへ表示
            //            //dgvCarReportDate_Click(sender, e);
            //        }
            //        catch (SerializationException se)
            //        {
            //            Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
            //            throw;
            //        }
            //    }
            //}
        }

        //表をクリックしたら履歴を表示
        private void dgvCarReportDate_Click(object sender, EventArgs e)
        {
            //選択したコードを取り出す
            //データグリッドビューで選択した行のインデックス
            //BindingListのデータを取得する
            //CarReprot selectedCar = Reports[dgvPerson.CurrentRow.Index];

            //選択したデータの表示
            //dateTimePicker1.Value = selectedCar.CreateDate;
            //cbAuthor.Text = selectedCar.Author;
            //cbName.Text = selectedCar.Name;
            //tbMemo.Text = selectedCar.Report;
            //pbImage.Image = selectedCar.Picture;

            //switch (selectedCar.Maker)
            //{
            //    case CarReprot.CarMaker.トヨタ:
            //        {
            //            rbToyota.Checked = true;
            //            break;
            //        }
            //    case CarReprot.CarMaker.日産:
            //        {
            //            rbNissan.Checked = true;
            //            break;
            //        }
            //    case CarReprot.CarMaker.ホンダ:
            //        {
            //            rbHonda.Checked = true;
            //            break;
            //        }
            //    case CarReprot.CarMaker.スバル:
            //        {
            //            rbSubaru.Checked = true;
            //            break;
            //        }
            //    case CarReprot.CarMaker.外車:
            //        {
            //            rbGaisya.Checked = true;
            //            break;
            //        }
            //    case CarReprot.CarMaker.その他:
            //        {
            //            rbSonota.Checked = true;
            //            break;
            //        }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputItemAllClear();
            //Reports.Clear();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ofdOpenDate.ShowDialog() == DialogResult.OK)
            //{
            //    using (FileStream fs = new FileStream(ofdOpenDate.FileName, FileMode.Open))
            //    {
            //        try
            //        {
            //            BinaryFormatter formatter = new BinaryFormatter();
            //            //逆シリアル化して読み込む
            //            Reports = (BindingList<CarReprot>)formatter.Deserialize(fs);
            //            //データグリッドビューに再設定
            //            dgvPerson.DataSource = Reports;
            //            ////選択されている箇所を各コントロールへ表示
            //            //dgvCarReportDate_Click(sender, e);
            //        }
            //        catch (SerializationException se)
            //        {
            //            Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
            //            throw;
            //        }
            //    }
            //}
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (sfdSaveDate.ShowDialog() == DialogResult.OK)
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();

            //    using (FileStream fs = new FileStream(sfdSaveDate.FileName, FileMode.Create))
            //    {
            //        try
            //        {
            //            formatter.Serialize(fs, Reports);
            //        }
            //        catch (SerializationException se)
            //        {
            //            Console.WriteLine("Faile to serialize. Reason" + se.Message);
            //            throw;
            //        }
            //    }
            //}
        }


        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //データベースの更新
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202032DataSet);
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202032DataSet.memoTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202032DataSet.CarReport);
            dgvCarReport.Columns[0].Visible = false;   //idを非表示
        }

        private void carReportDataGridView_Click(object sender, EventArgs e)
        {
            //選択した行のインデックスで指定した項目を取り戻す
            var maker = dgvCarReport.CurrentRow.Cells[3].Value;

            //編集者
            cbAuthor.Text = dgvCarReport.CurrentRow.Cells[2].Value.ToString();
            cbName.Text = dgvCarReport.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = dgvCarReport.CurrentRow.Cells[5].Value.ToString();

            //if (dgvCarReport != null)
            //{
            //    dgvCarReport.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            //}
            //else
            //{
            //    dgvCarReport.CurrentRow.Cells[6].Value = null;
            //}

            SetRadioButton((string)maker);
        }

        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void SetRadioButton(string carMaker)
        {
            switch (carMaker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;

                case "日産":
                    rbNissan.Checked = true;
                    break;

                case "ホンダ":
                    rbHonda.Checked = true;
                    break;

                case "スバル":
                    rbSubaru.Checked = true;
                    break;

                case "外車":
                    rbGaisya.Checked = true;
                    break;

                case "その他":
                    rbSonota.Checked = true;
                    break;

            }
        }

        //車名検索
        private void btSearchExe_Click(object sender, EventArgs e)
        {
            //this.carReportTableAdapter.FillByCarName(this.infosys202032DataSet.CarReport, tbSearchCarName.Text);
            this.carReportTableAdapter.FillByCreatedDate(this.infosys202032DataSet.CarReport, tbSearchCarName.Text,tbSearchMaker.Text );
            //if (dtpSearchDate == default || tbSearchAuthor == null || tbSearchMaker == null)
            //{
            //    this.carReportTableAdapter.FillByCarName(this.infosys202032DataSet.CarReport, tbSearchCarName.Text);
            //}
        }

        //日付検索
        private void btSearchExeDate_Click(object sender, EventArgs e)
        {
        }

        private void btSerchAut_Click(object sender, EventArgs e)
        {

        }

        private void btSerMa_Click(object sender, EventArgs e)
        {
        }
    }
}