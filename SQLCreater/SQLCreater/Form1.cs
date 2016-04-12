using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testdataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testdataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aigsTestDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aigsTestDataSet.testdata' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.testdataTableAdapter.Fill(this.aigsTestDataSet.testdata);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.testdataTableAdapter.FillBy(this.aigsTestDataSet.testdata);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 切り取りTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
