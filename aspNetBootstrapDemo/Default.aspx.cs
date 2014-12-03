using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;
using System.Configuration;

namespace aspNetBootstrapDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           PopulateGrid1();
            
            //PopulateGrid2();
        }


        protected void PopulateGrid1()
        {
            String connectionString = "Data Source=" + Server.MapPath(@"~\AppData\vukovi2015.db") + "; Version=3;";
            String selectCommand = "select ime Ime, prezime Prezime, pozicija Pozicija, datum [Datum testiranja], benchTezina [Tezina bencha], bench Bench, deadliftTezina [Tezina mrtvog dizanja], deadlift [Mrtvo dizanje], broadjump [Skok u dalj] from Testiranje t join Bench b on b.benchId = t.benchId join Deadlift d on d.deadliftId=t.deadliftId join Players p on p.playersId=t.playersId join Pozicija poz on poz.pozicijaId=p.pozicijaId";


            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCommand, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            gv3.DataSource = ds;
            gv3.DataBind();
        }


        protected void PopulateDDL()
        {
            DataTable players = new DataTable();
            String connectionString = "Data Source=" + Server.MapPath(@"~\AppData\vukovi2015.db") + "; Version=3;";
            String selectCommand = "select prezime, playersId from Players";
            using(SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                try
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter(selectCommand, con);
                    da.Fill(players);
                    ddlPlayers.DataSource = players;
                    ddlPlayers.DataTextField = "prezime";
                    ddlPlayers.DataValueField = "playersId";
                    ddlPlayers.DataBind();
                }
                catch (Exception ex)
                {
                    string greska = ex.Message;
                }
            }



            //SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCommand, connectionString);

            //DataSet ds = new DataSet();
            //dataAdapter.Fill(ds);

            //ddlPlayers.DataSource = ds;
            //ddlPlayers.DataBind();

        }

        protected void PopulateGrid2()
        {
            String connectionString = "Data Source=" + Server.MapPath(@"~\AppData\vukovi2015.db") + "; Version=3;";
            String selectCommand = "select datum [Datum testiranja], benchTezina [Tezina bencha], bench Bench, deadliftTezina [Tezina mrtvog dizanja], deadlift [Mrtvo dizanje], broadjump [Skok u dalj] from Testiranje t join Bench b on b.benchId = t.benchId join Deadlift d on d.deadliftId=t.deadliftId where playersId ="+ddlPlayers.SelectedValue.ToString();

            
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCommand, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();
        }

        protected void ddlPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateGrid2();
        }

        protected void btnPosebno_Click(object sender, EventArgs e)
        {
            PopulateDDL();
            ddlPlayers.Visible = true;
        }
    }
}