using CBTool.Properties;

namespace CBTool
{
    public partial class CBToolCS : Form
    {
        public CBToolCS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "----------------------------------------------------------\r\n" +
                "CBToolCS\r\n" +
                "�汾:v1.1\r\n" +
                "���ֿ�:https://github.com/lovcoxin/classbook\r\n" +
                "��ϵ��(lovcoxin):lovcoxin@126.com\r\n" +
                "��ϵ��(lxxgd):������ȻҪд���(\r\n" +
                "�ֿ�:https://github.com/lovcoxin/ClassBook/tree/CBToolCS\r\n" +
                "ԭ��ֿ�:https://github.com/lovcoxin/ClassBook/tree/CBtool\r\n" +
                "----------------------------------------------------------",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PicNumbering picNumbering = new PicNumbering();
            picNumbering.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBToolCS_Load(object sender, EventArgs e)
        {

        }
    }
}
