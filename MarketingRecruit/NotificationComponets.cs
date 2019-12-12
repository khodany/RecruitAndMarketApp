using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MarketingRecruit
{
    public class NotificationComponets
    {
        // we will add fuctionfor register notification (will add sql depende

        public void RegisterNotification(DateTime currentTime)
        {
            string constring = ConfigurationManager.ConnectionStrings[""].ConnectionString;
            string sqlCommand = @"SELECT [ContactID],[ContactNo] from [dbo][Contacts] where [AddedOn]>@AddedOn";

            using(SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, con); ;

                cmd.Parameters.AddWithValue("@AddedOn", currentTime);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                cmd.Notification = null;
                SqlDependency sqlDep = new  SqlDependency(cmd);
                sqlDep.OnChange += sqlDep_Onchange;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // noti
                }
            }
        }

        void sqlDep_Onchange(object sender,SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                SqlDependency sqlDep = sender as SqlDependency;
                sqlDep.OnChange -= sqlDep_Onchange;

                //we sendnot message to client 

                var notificationHub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            }
        }
    }
}