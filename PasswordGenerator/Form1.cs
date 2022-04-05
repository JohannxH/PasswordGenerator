namespace PasswordGenerator
{
    public partial class frmPasswordGenerator : Form
    {
        // Declare constants
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";

        public frmPasswordGenerator()
        {
            InitializeComponent();
        }


        public string Generate(bool lowerCase, bool upperCase, bool mumberic, bool Ambiguous, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (Ambiguous)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtNewPassword.Text = Generate(chkLower.Checked, chkUpper.Checked, chkNumeric.Checked, chkAmbiguous.Checked, int.Parse(txtLength.Text));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}