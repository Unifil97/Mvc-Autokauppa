using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Autokauppa.model
{
   public class Autonmallit
    {
        
            //SqlConnection dbYhteys = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autot;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            int id;
            string malliNimi;
            int merkkiId;

            public int Id { get => id; set => id = value; }
            public string MalliNimi { get => malliNimi; set => malliNimi = value; }
            public int MerkkiId { get => merkkiId; set => merkkiId = value; }
           
            
        
    }
}
