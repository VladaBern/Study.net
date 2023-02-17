using HomeTask1.GrandSlamDBTableAdapters;
using System;
using System.Windows.Forms;

namespace HomeTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrandSlamDB slamDB = new GrandSlamDB();

            new CourtsTableAdapter().Fill(slamDB.Courts);
            new TournamentsTableAdapter().Fill(slamDB.Tournaments);
            new PlayerInfosTableAdapter().Fill(slamDB.PlayerInfos);
            new PlayersTableAdapter().Fill(slamDB.Players);
            new PlayerStatsTableAdapter().Fill(slamDB.PlayerStats);
            new MatchesTableAdapter().Fill(slamDB.Matches);

            courts.DataSource = slamDB.Courts;
            tournaments.DataSource = slamDB.Tournaments;
            playerInfo.DataSource = slamDB.PlayerInfos;
            players.DataSource = slamDB.Players;
            playerStats.DataSource = slamDB.PlayerStats;
            matches.DataSource = slamDB.Matches;
        }
    }
}
