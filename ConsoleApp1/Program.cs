﻿class Program
{
    static void Main(string[] args)
    {
        Team FbTeam1 = new Team(5);//Create Football team for 5 players
        FbTeam1[0] = new FbPlayer { Name = "Tom", NumOnField = 11 };
        FbTeam1[1] = new FbPlayer { Name = "Bob", NumOnField = 12 };
        FbTeam1[2] = new FbPlayer { Name = "Sam", NumOnField = 10 };

        FbPlayer Tom = FbTeam1[0];
        FbPlayer Bob = FbTeam1[1];
        FbPlayer Sam = FbTeam1[2];

        Console.WriteLine($"Имя: {Tom.Name}, Номер: {Tom.NumOnField}");

        for (int i = 0; i < FbTeam1.getLength(); i++)
        {
            Console.WriteLine(i);
            //Console.WriteLine($"Имя: {player.Name}, Номер: {player.NumOnField}");
        }
    }
}

class FbPlayer
{
    internal string? Name { get; set; }
    internal int NumOnField { get; set; }
    //Create Football player with Name and Number
}
class Team
{
    FbPlayer[] data;
    internal int size;
    public Team (int SizeOfArray)
    {
        this.size = SizeOfArray;
        data = new FbPlayer[SizeOfArray];
        //FbPlayer as type for array, not new objects
    }
    public FbPlayer this[int Index]
    {
        get
        {
            return data[Index];
        }
        set 
        {
            data[Index] = value;
        }
    }
    public int getLength() => this.size;
    //Create Football Team with array of objects(FbPlayer) and indexers for this array
}