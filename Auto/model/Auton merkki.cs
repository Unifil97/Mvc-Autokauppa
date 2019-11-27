using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;
using Autokauppa.controller;

namespace Autokauppa.model
{
   public class AutonMerkki
    {
        //SqlConnection dbYhteys = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autot;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        int id;
       
        string merkkinimi;

        public int Id { get => id; set => id = value; }
       
        public string Merkkinimi { get => merkkinimi; set => merkkinimi = value; }

   
        
    }
}
