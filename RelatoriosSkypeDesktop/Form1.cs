using RelatoriosSkype.Models;
using RelatoriosSkypeDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelatoriosSkypeDesktop{
    public partial class Form1 : Form{
        public Form1() {
            InitializeComponent();
        }

        public List<Conversa> listaConversas = new List<Conversa>();

        private void bGenerate_Click(object sender, EventArgs e){

            this.executa();
        }

        public void executa() {
            Metodos execute = new Metodos();


            if (this.TestParameters()) {
                listaConversas = execute.listConversation(tStartDate.Text, tEndDate.Text, tFrom.Text, tTo.Text, "", tServer.Text, tDatabase.Text, tUsername.Text, tPassword.Text);
                if (!execute.OK) {
                    lError.Visible = true;
                    lError.Text = "Cannot access database.";
                }
            }

            var source = new BindingSource(listaConversas, null);
            gReport.DataSource = source;

        }

        public bool TestParameters() {
            lError.Visible = false;
            if (tServer.Text == "") {
                lError.Text = "The field Server\\Instance cannot be blank.";
                lError.Visible = true;
                return false;
            }
            if (tDatabase.Text == "") {
                lError.Text = "The field Database cannot be blank.";
                lError.Visible = true;
                return false;
            }
            if (tUsername.Text == "") {
                lError.Text = "The field Username cannot be blank.";
                lError.Visible = true;
                return false;
            }
            if (tPassword.Text == "") {
                lError.Text = "The field Password cannot be blank.";
                lError.Visible = true;
                return false;
            }

            if (!TestDate(tStartDate.Text)) {
                lError.Text = "Invalid format for Start Date.";
                lError.Visible = true;
                return false;
            }

            if (!TestDate(tEndDate.Text)){
                lError.Text = "Invalid format for End Date.";
                lError.Visible = true;
                return false;
            }

            return true;
        }

        public bool TestDate(String date) {
            try {
                String[] splitDate = date.Split('-');
                if (int.Parse(splitDate[0]) > 9999 || int.Parse(splitDate[0]) < 1) {
                    return false;
                }
                if (int.Parse(splitDate[1]) > 12 || int.Parse(splitDate[1]) < 1) {
                    return false;
                }
                if (int.Parse(splitDate[2]) > 32 || int.Parse(splitDate[2]) < 1) {
                    return false;
                }
            }
            catch {
                return false;
            }

            return true;
        }

    }
}
