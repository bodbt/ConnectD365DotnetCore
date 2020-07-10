using System;
using Microsoft.PowerPlatform.Cds.Client;
using Microsoft.Crm.Sdk.Messages;

namespace ConnectD365
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                var con = new CdsServiceClient("AuthType=ClientSecret;Url=https://nt20200626.crm7.dynamics.com;Clientid=f0b3a05e-a1b0-4a02-b7f1-bc18b75a903f;ClientSecret=u~0X_JDm4.6.Uv4Nys_wk9ToW7ZrM.Ax1A");
                if (!con.IsReady) {
                    throw new Exception(con.LastCdsError, con.LastCdsException);
                }

                var req = new WhoAmIRequest();
                var response = (WhoAmIResponse)con.Execute(req);

                var userEntity = con.Retrieve("systemuser", response.UserId, new Microsoft.Xrm.Sdk.Query.ColumnSet(true));
                var userName = userEntity.GetAttributeValue<string>("fullname");
                Console.WriteLine(userName);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
