using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeYapi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ws.CrmServiceClient client = new ws.CrmServiceClient();

                ws.Opp Lead = new ws.Opp();
                Lead.username = "emlaktasondakika";
                Lead.password = "egeyapi-@k9*";
                Lead.firstname = "dincer";
                Lead.lastname = "genc";
                Lead.ilgilendigiproje = "MODERNYAKA";
                Lead.mobile = "05497176001";
                Lead.email = "dincer@egeyapi.com";
                Lead.aciklama = "description";
                Lead.googleID = "";
                Lead.utmcampaign = "";
                Lead.utmsource = "";
                Lead.utmcontent = "";
                Lead.utmterm = "";
                Lead.utmmedium = "";
                Lead.emailizin = "Var";
                Lead.smsizin = "Var";
                Lead.cihazturu = "Desktop / Mobile";
                Lead.referrer = "";
                Lead.form = "wishne";
                Lead.formlink = "";
                Lead.browserlang = "tr-TR";
                Lead.kayittarihi = DateTime.Now; ;
                string sonuc = client.CreateOpportunity2(Lead);
                Console.WriteLine(sonuc.ToString());
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                                
            }

        }
    }
}
