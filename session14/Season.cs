public class Season 
{ 
    public List<SoccerTeam> Teams { get; set; }
    
    public Season(List<SoccerTeam>)void ReadSeasonFromFile (string filename)
    { 
        using( FileStream stream = new FileStream (filename, FileMode.Open, FileAccess.Read))
        { 
            using( StreamReader reader = new StreamReader (stream))
            { 
                string line = reader.ReadLine ();
                while (line != null)
                { 
                    string[] parts = line.Split (',');
                    string team1 = parts[2];
                    string team2 = parts[5];
                    string result = parts[3];

                    SoccerTeam scteam1 = new SoccerTeam ();
                    scteam1.Team = team1;
                    //scteam1.Points = points;
                    
                    Teams.Add (scteam1);
                    SoccerTeam scteam2 = new SoccerTeam ();
                    scteam2.Team = team2;
                    //scteam1.Points = points;
                    
                    Teams.Add (scteam1);
                    
                    line = reader.ReadLine ();
                }
            }

        }
    }
}