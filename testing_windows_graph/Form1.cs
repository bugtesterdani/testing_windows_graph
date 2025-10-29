namespace testing_windows_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "Running";
            if (Task.Run(async () => await testservice.Main(tBox_cID.Text, tBox_dPath.Text, tBox_fPath.Text)).Result == true)
                lbl_Status.Text = "SUCCESS";
            else
                lbl_Status.Text = "FAILED";
        }
    }
}
