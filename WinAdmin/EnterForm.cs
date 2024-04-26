namespace WinAdmin
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084)
            {
                m.Result = (IntPtr)2;
                return;
            }
            base.WndProc(ref m);
        }

        private void labelButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
