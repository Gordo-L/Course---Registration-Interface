using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 个人信息登记
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void 设置字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1.创建一个字体对话框
            System.Windows.Forms.FontDialog fontDlg = new FontDialog();
            //2.显示字体对话框
            fontDlg.ShowDialog();
            //3.将字体对话框运行时设定的字体赋予列表框（ListBox）的字体（Font）属性:
            listBox1.Font = fontDlg.Font;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("请尽快填写!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } 

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //如果是按下鼠标右键
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //根据当前鼠标的位置生成一一个点
                Point pos = new Point(e.X,e.Y);//在该点上显示右键菜单
                contextMenuStrip1.Show(this, pos);

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label4.Text = "现在的时间是" + now.Year.ToString() + "年" + now.Month.ToString() + "月" + now.Day.ToString() + "日  " + now.ToLongTimeString() + "  " + now.DayOfWeek.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.创建一个字体对话框
            System.Windows.Forms.FontDialog fontDlg = new FontDialog();
            //2.显示字体对话框
            fontDlg.ShowDialog();
            //3.将字体对话框运行时设定的字体赋予列表框（ListBox）的字体（Font）属性:
            listBox1.Font = fontDlg.Font;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            listBox1.ForeColor = colorDlg.Color;
        }

        private void 设置字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //1.创建一个字体对话框
            System.Windows.Forms.FontDialog fontDlg = new FontDialog();
            //2.显示字体对话框
            fontDlg.ShowDialog();
            //3.将字体对话框运行时设定的字体赋予列表框（ListBox）的字体（Font）属性:
            listBox1.Font = fontDlg.Font;
        }

        private void 设置颜色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            listBox1.ForeColor = colorDlg.Color;
        }

        private void 设置颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            listBox1.ForeColor = colorDlg.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDlg =new System.Windows.Forms.OpenFileDialog();
            //调用ShowDialog方法,显示这个对话框
            openFileDlg.ShowDialog();
            // 由Image类的静态函数FormFile(文件名)生成一个Image对象
            //赋给pi ctureBox1的Image属性
            pictureBox1.Image = Image.FromFile(openFileDlg.FileName);
        }

        private void 选择一个头像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDlg = new System.Windows.Forms.OpenFileDialog();
            openFileDlg.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDlg.FileName);
        }

        private void 选择一个头像ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDlg = new System.Windows.Forms.OpenFileDialog();
            openFileDlg.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDlg.FileName);
        }

        private void button4_Click(object sender, EventArgs e)//预览
        {
            listBox1.Items.Clear();
            string sex = "";
            if (radioButton1.Checked == true)
            {
                sex = "男";
            }
            if (radioButton2.Checked == true)
            {
                sex = "女";
            }
            string interests = "";
            interests += (checkBox1.Checked ? "唱歌 " : "")
                      + (checkBox2.Checked ? "阅读 " : "")
                      + (checkBox3.Checked ? "运动 " : "")
                      + (checkBox4.Checked ? "游戏 " : "");

            string position = treeView1.SelectedNode.Text;
            while (treeView1.SelectedNode.Parent != null)
            {
                position = treeView1.SelectedNode.Parent.Text + "-" + position;
                treeView1.SelectedNode = treeView1.SelectedNode.Parent;
            }


            listBox1.Items.Add("姓名：" + textBox1.Text);
            listBox1.Items.Add("血型：" + comboBox1.Text);
            listBox1.Items.Add("生日：" + dateTimePicker1.Text);
            listBox1.Items.Add("性别：" + sex);
            listBox1.Items.Add("籍贯：" + position);
            listBox1.Items.Add("兴趣爱好：" + interests);
            listBox1.Items.Add("个人简介：" + richTextBox1.Text);
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved.", "关于本产品", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void 项目PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(open.FileName);

                //赋值
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
                listBox1.Items.Add(sr.ReadLine());
            }
        }

        private void button5_Click(object sender, EventArgs e)//保存
        {
            string sex = "";
            if (radioButton1.Checked == true)
            {
                sex = "男";
            }
            if (radioButton2.Checked == true)
            {
                sex = "女";
            }
            string interests = "";
            interests += (checkBox1.Checked ? "唱歌 " : "")
                      + (checkBox2.Checked ? "阅读 " : "")
                      + (checkBox3.Checked ? "运动 " : "")
                      + (checkBox4.Checked ? "游戏 " : "");

            string position = treeView1.SelectedNode.Text;
            while (treeView1.SelectedNode.Parent != null)
            {
                position = treeView1.SelectedNode.Parent.Text + "-" + position;
                treeView1.SelectedNode = treeView1.SelectedNode.Parent;
            }            
            StreamWriter sw = new StreamWriter(textBox1.Text + "个人信息");
            sw.WriteLine("姓名：" + textBox1.Text);
            sw.WriteLine("血型：" + comboBox1.Text);
            sw.WriteLine("生日：" + dateTimePicker1.Text);
            sw.WriteLine("性别：" + sex);
            sw.WriteLine("籍贯：" + position);
            sw.WriteLine("兴趣爱好：" + interests);
            sw.WriteLine("个人简介：" + richTextBox1.Text);
            sw.Close();
            MessageBox.Show("保存成功", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
