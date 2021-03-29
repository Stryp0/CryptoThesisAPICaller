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
using System.Web;
using System.Net;

namespace CryptoThesisAPICaller
{
    public partial class Form1 : Form
    {
        string nl = Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (apiTextBox.Text != "" && blockchainComboBox.SelectedIndex >= 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Hiba! Kérlek, add meg az API kódot és válassz blokkláncot.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getBlocks()
        {
            string APIKey = apiTextBox.Text;
            string _Blockchain = blockchainComboBox.SelectedItem.ToString();
            string Blockchain = "unknown";

            switch (_Blockchain)
            {
                case "Bitcoin":
                    Blockchain = "bitcoin";
                    break;
                case "Bitcoin Cash":
                    Blockchain = "bitcoin-cash";
                    break;
                case "Dash":
                    Blockchain = "dash";
                    break;
            }

            logTextBox.AppendText("A program elindult " + Blockchain + " blokkláncon." + nl);

            DateTime startingDate = new DateTime(2020, 01, 01);
            WebClient client = new WebClient();

            for (int i = 0; i < 366; i++)
            {
                DateTime date = startingDate.AddDays(i);
                try
                {
                    string fileContents = client.DownloadString("https://api.blockchair.com/bitcoin/blocks?q=time(" + date.ToString("yyyy-MM-dd") + ")&s=transaction_count(desc)&limit=1&key=" + APIKey) + nl;
                    File.WriteAllText("C:\\Users\\stryp\\Dropbox\\Corvinus\\Szakdolgozat\\Adatok\\" + Blockchain + "-" + date.ToString("yyyy-MM-dd") + ".json", fileContents);
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText(ex.Message + nl);
                    i--;
                }

                logTextBox.AppendText(date.ToString("yyyy-MM-dd") + " sikeresen lekérve (" + i + ")" + nl);
            }


            logTextBox.AppendText("A futtatás sikeresen véget ért." + nl);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getBlocks();
        }
    }
}
