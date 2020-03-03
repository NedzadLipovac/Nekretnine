using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
namespace Nekretnine.WebApi.Hubs
{
    public class Notification
    {
        private readonly IHubContext<MyHub> _context;
        string connectionString = @"Server=.;Database=Nekretnine;Trusted_Connection=True;ConnectRetryCount=0";

        public Notification(IHubContext<MyHub> context)
        {
            _context = context;
        }
        public void getNottif()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDependency.Start(connectionString);

                string commandText = "select PorukaId from dbo.Poruka";

                SqlCommand cmd = new SqlCommand(commandText, conn);

                SqlDependency dependency = new SqlDependency();

                dependency.OnChange += new OnChangeEventHandler(dbChangeNotification);

                var reader = cmd.ExecuteReader();

                //while (reader.Read())
                //{
                //    var employee = new Employee
                //    {
                //        Id = Convert.ToInt32(reader["Id"]),
                //        Name = reader["Name"].ToString(),
                //        Age = Convert.ToInt32(reader["Age"])
                //    };

                //    employees.Add(employee);
                //}
            }
          
        }
        private void dbChangeNotification(object sender, SqlNotificationEventArgs e)
        {
            _context.Clients.All.SendAsync("refreshEmployees");
        }

    }
}
