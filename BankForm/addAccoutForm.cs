using BankAbstract;
namespace BankForm
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void frmAddAccoutForm_Load(object sender, EventArgs e)
        {
            panCom.Visible = false;
            panSaving.Visible = false;

            panSaving.Location = new Point(0, 0);
            panCom.Location = new Point(0, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(radCommonAccount.Checked)
            {
                MessageBox.Show((new CommonAccount((float) numOverdraft.Value, txtRef.Text, (float)numBalance.Value, DateTime.Now).ToString()));
            }
            else if(radSavingAccount.Checked)
            {
                MessageBox.Show((new SavingAccount((float)numInterest.Value, txtRef.Text, (float)numBalance.Value, DateTime.Now).ToString()));
            }
        }

        private void radCommonAccount_Click(object sender, EventArgs e)
        {
            panSaving.Visible = false;
            panSaving.Location = new Point(0,0);
            panCom.Visible = true;
            panCom.Location = new Point(25, 143);
        }

        private void radSavingAccount_Click(object sender, EventArgs e)
        {
            panCom.Visible = false;
            panCom.Location = new Point(0, 0);
            panSaving.Visible = true;
            panSaving.Location = new Point(25, 143);
        }
    }
}