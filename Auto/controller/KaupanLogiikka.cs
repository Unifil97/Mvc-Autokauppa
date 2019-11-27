using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;
using System.Windows.Forms;

namespace Autokauppa.controller
{
    
    public class KaupanLogiikka
    {
        DatabaseHallinta dbController = new DatabaseHallinta();
      

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbController.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(model.Auto biili)
        {
            bool didItGoIntoDatabase = dbController.savecar(biili);
            return didItGoIntoDatabase;
        }
        public  Auto seurcar(int ID)
        {
            Auto uusi = dbController.nextcar(ID);
            if (uusi.ID1 == 0)
            {
                uusi = dbController.Last();
                return uusi;
            }

            else
            {
                return uusi;
            }
            
        }
        public Auto edellcar(int ID)
        {
            Auto uusi = dbController.prevcar(ID);
            if (uusi.ID1 == 0)
            {
                uusi = dbController.first();
                return uusi;
            }

            else
            {               
                return uusi;
            }
            
        }
       
        public List<AutonMerkki> getAllAutoMakers()
        {
            return dbController.GetMerkit();
        }

        public List<Autonmallit> getAutoModels(int MerkkiId)
        {

            return dbController.GetMallit(MerkkiId);
        }
        public List<Polttoaine> GetFuel()
        {
            return dbController.GetPolttoaine();
        }
        public List<Vari> GetColor()
        {
            return dbController.GetVarit();
        }

       
    }
}
