using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PasswordManager
{
    public partial class PassMan : Form
    {
        public PassMan()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MasPasBtn_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load("Accounts.xml");

            XElement root = new XElement("MasterPassword");
            bool b = doc.Descendants("MasterPass").Any();
            if (b == false)
            {
                string masterPass = MasterPassTxt.Text;
               

                root.Add(new XElement("MasterPass", masterPass.ToString()));
                doc.Element("root").Add(root);
                doc.Save("Accounts.xml");
            }
            else
            {
                MessageBox.Show("There is already a master password, a new one cannot be created.", "Error, Master Password Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            XDocument doc = new XDocument();
            doc = XDocument.Load("Accounts.xml");

            XElement masterPassWordNode = doc.Element("root").Element("MasterPassword").Element("MasterPass");
            var masterPasswordPass = masterPassWordNode.Value;
            string MasterPass = MasterPassTxt.Text;

            

            if (MasterPass.Equals(masterPasswordPass))
            {
                XElement root = new XElement("Passwords", new XAttribute("Website", SiteTxt.Text));

                root.Add(new XElement("Website", SiteTxt.Text));
                root.Add(new XElement("Password", PasswordTxt.Text));

                doc.Element("root").Add(root);
                doc.Save("Accounts.xml");
            }
            else
            {
                Console.WriteLine(MasterPass);
                Console.WriteLine(masterPasswordPass);

                MessageBox.Show("The Password you have entered in the Master Password field is incorrect, you will not be able to add/edit/view/delete any password until the correct Master Password has been entered", "Incorrect Master Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load("Accounts.xml");
           
            

            string masterPassword = MasterPassTxt.Text;

            if (masterPassword.ToString().Equals(doc.Element("root").Element("MasterPassword").Element("MasterPass").Value))
            {
                doc.Descendants("root").Elements("Passwords").Where(n => n.Attribute("Website").Value == SiteTxt.Text).Remove();
            }
            else
            {
                MessageBox.Show("The Password you have entered in the Master Password field is incorrect, you will not be able to add/edit/view/delete any password until the correct Master Password has been entered", "Incorrect Master Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            doc.Save("Accounts.xml");

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load("Accounts.xml");


            if(MasterPassTxt.Text == doc.Element("root").Element("MasterPassword").Element("MasterPass").Value.ToString())
            {

                string password = doc.Descendants("root").Elements("Passwords")
                    .Where(n => (string)n.Attribute("Website") == SiteTxt.Text).Elements("Password").Select(n => (string)n)
                    .FirstOrDefault();

                PasswordTxt.Text = password.ToString();
            }
            else
            {
                MessageBox.Show("The Password you have entered in the Master Password field is incorrect, you will not be able to add/edit/view/delete any password until the correct Master Password has been entered", "Incorrect Master Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





            



        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            XDocument doc = new XDocument();
            doc = XDocument.Load("Accounts.xml");

            if (MasterPassTxt.Text == doc.Element("root").Element("MasterPassword").Element("MasterPass").Value.ToString())
            {
                if(SiteTxt.Text != string.Empty && PasswordTxt.Text != string.Empty )
                {
                    var pass = doc
                    .Element("root")
                    .Elements("Passwords")
                    .Where(n => (string)n.Attribute("Website") == SiteTxt.Text)
                    .Single();

                    string PassChange = PasswordTxt.Text;
                    pass.Element("Password").Value = PassChange.ToString();
                    doc.Save("Accounts.xml");
                }
                else
                {
                    MessageBox.Show("Please make sure that none of the fields are empty.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                
                
                

               


            }
            else
            {
                MessageBox.Show("The Password you have entered in the Master Password field is incorrect, you will not be able to add/edit/view/delete any password until the correct Master Password has been entered", "Incorrect Master Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
