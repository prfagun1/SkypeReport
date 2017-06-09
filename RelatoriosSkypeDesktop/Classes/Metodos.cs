using HtmlAgilityPack;
using RelatoriosSkype.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosSkypeDesktop.Classes{
    class Metodos{

        public bool OK = true;

        public List<Conversa> listConversation(String startDate, String endDate, String from, String to, String message, String server, String database, String username, String password){
            List<Conversa> conversas = new List<Conversa>();

            try { 
                String connectionString = "Driver={SQL Server};Server=" + server + ";UID=" + username + ";PWD=" + password +";Database=" + database + ";";
                int type;

                String sql = "  select top(10000) m.MessageIdTime as 'Date', uf.UserUri as 'From', ut.UserUri as 'To', m.Body as 'Message',  m.ContentTypeId as 'Type'";
                sql += "  from Messages m";
                sql += "  join Users uf on m.FromId = uf.UserId";
                sql += "  join Users ut on m.ToId = ut.UserId";
                sql += "  where m.MessageIdTime >= '" + startDate + "'";
                sql += "  and m.MessageIdTime <= '" + endDate + "'";
                sql += "  and (ut.UserUri like '%" + from + "%' or uf.UserUri = '%" + to + "%')";
                sql += "  order by m.MessageIdTime desc";


                OdbcConnection cn;
                OdbcCommand cmd;
                cn = new OdbcConnection(connectionString);

                cmd = new OdbcCommand(sql, cn);
                cmd.CommandTimeout = 500;

                cn.Open();

                OdbcDataReader myReader = null;
                myReader = cmd.ExecuteReader();

                while (myReader.Read()) {
                    try{
                        Conversa messages = new Conversa();
                        messages.Date = myReader["Date"].ToString();
                        messages.From = (String)myReader["From"];
                        messages.To = (String)myReader["To"];
                        messages.Message = (String)myReader["Message"];
                        type = (int)myReader["Type"];

                        if (type == 3){
                            messages.Message = this.converteRFTtoText(messages.Message);
                        }
                        if (type == 1) {
                            messages.Message = converteHTMLtoText(message);
                        }


                        conversas.Add(messages);
                    }
                    catch { }
                }
                cn.Close();
            }
            catch {
                OK = false;
                return null;
            }

            OK = true;
            return conversas;
        }

        public String converteRFTtoText(String mensagem){
            String converte = "";
            System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();

            try {
                rtBox.Rtf = mensagem;
                converte = rtBox.Text;
            }
            catch{
                return mensagem;
            }

            return converte;
        }

        public String converteHTMLtoText(String html) {
            String converte = "";

            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()")){
                converte += node.InnerText;
            }

            return converte;
        }
    }
}
