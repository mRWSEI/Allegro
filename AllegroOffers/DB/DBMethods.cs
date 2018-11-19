using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegroOffers
{
    public class DBMethods
    {
        public DBMethods()
        {
            //konstruktor
        }

        private SQLiteDataAdapter m_oDataAdapter = null;
        private DataSet m_oDataSet = null;
        private DataTable m_oDataTable = null;
        private SQLiteConnection m_dbConnection;

        public DataView InitBinding()
        {
            SQLiteConnection oSQLiteConnection = new SQLiteConnection($"Data Source={Definitions.dbFileName}");
            SQLiteCommand oCommand = oSQLiteConnection.CreateCommand();
            oCommand.CommandText = "SELECT * FROM AllegroOffers";
            m_oDataAdapter = new SQLiteDataAdapter(oCommand.CommandText,oSQLiteConnection);
            SQLiteCommandBuilder oCommandBuilder = new SQLiteCommandBuilder(m_oDataAdapter);
            m_oDataSet = new DataSet();
            m_oDataAdapter.Fill(m_oDataSet);
            m_oDataTable = m_oDataSet.Tables[0];
            return  m_oDataTable.DefaultView;
        }

        /*
        public void CreateDB()
        {
            SQLiteConnection.CreateFile(Definitions.dbFileName);

            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={Definitions.dbFileName};Version=3;");
            m_dbConnection.Open();

            string sql = 
@"create table AllegroOffers 
(
Id int identity(1,1) PRIMARY KEY,
AllegroOfferId int,
AllegroOfferName varchar(200),
AllegroSellerName varchar(200),
AllegroSellerId varchar(200),
AllegroCategoryId int,
AllegroOfferPrice decimal(18,2),
Insert_Date Datetime DEFAULT CURRENT_TIMESTAMP
)";
*/

 /*           
         INSERT INTO AllegroOffers
(AllegroOfferId, AllegroOfferName, AllegroSellerName,
AllegroSellerId, AllegroCategoryId, AllegroOfferPrice,
InsertDate)
VALUES
(233, 'Galaxy S7 Gwarancja', 'SmartTel',
74321, 12, 720, 
'2018-11-13 21:02:00')
 */
 /*
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();

            m_dbConnection.Close();
        }
        */

        public void OpenDB()
        {
            m_dbConnection =
                new SQLiteConnection($"Data Source={Definitions.dbFileName};Version=3;");
            m_dbConnection.Open();
            string sql = "select * from CEDIGRecords";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
        }

        public DataTable SelectData()
        {
            DataTable dt = null;
            string sql = "SELECT * From AllegroOffers";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command = new SQLiteCommand(sql, m_dbConnection);
            //dt = command.ExecuteReader();

            return dt;
        }

        public void InsertData()
        {
            string sql = "insert into highscores (name, score) values ('Me', 9001)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void AddRecord()
        {
                DataRow oDataRow = m_oDataTable.NewRow();
                oDataRow[0] = 1;
                oDataRow[1] = "Jan";
                oDataRow[2] = "Kowalski";
                oDataRow[3] = 25;
                m_oDataTable.Rows.Add(oDataRow);
                m_oDataAdapter.Update(m_oDataSet);
        }

        public void EditRecord()
        {
            /* to do formsa 
            if(0 == lstItems.SelectedItems.Count)
            {
                return;
            }
            
            DataRow oDataRow = ((DataRowView)lstItems.SelectedItem).Row;
            */
            DataRow oDataRow= null; // dla bezlednej komp
            oDataRow.BeginEdit();
            oDataRow[2] = "Nowak";
            oDataRow[3] = 28;
            oDataRow.EndEdit();
            m_oDataAdapter.Update(m_oDataSet);
        }

        public void DeleteRecord()
        {
            /* forms
            if(0 == lstItems.SelectedItems.Count)
            {
                return;
            }
            DataRow oDataRow = ((DataRowView)lstItems.SelectedItem).Row;
            */
            DataRow oDataRow = null; // dla bezblednej
            oDataRow.Delete();
            m_oDataAdapter.Update(m_oDataSet);
        }
    }
}
