using System;


string[] lines = File.ReadAllLines("D:\\Zelle01.txt");
string[,] room = new string[lines[0].Length, lines.Length];


for (int l = 0; l < lines.Length; l++)
{
    for (int c = 0; c < lines[l].Length; c++)
    {
        room[c, l] = lines[l][c].ToString();



    }
}
    int postionX = 6;
    int postionY = 6;
    int space = 0;

// hier wird der Spieler als X dargestellt und kann sich durch den raum bewegen mit W A S D
while (true)
    {
        Print(room, postionX, postionY);

        ConsoleKeyInfo key = Console.ReadKey();

        switch (key.KeyChar)
        {

            case 'w':
                if (postionY > 0 && room[postionX, postionY - 1] == " ")
                    postionY--;
                    space = 0;
                break;

            case 'a':
                if (postionX > 0 && room[postionX - 1, postionY] == " ")
                    postionX--;
                    space = 0;
            break;

            case 's':
                if (postionY < room.GetLength(1) - 1 && room[postionX, postionY + 1] == " ")
                    postionY++;
                    space = 0;
            break;

            case 'd':
                if (postionX < room.GetLength(0) - 1 && room[postionX + 1, postionY] == " ")
                    postionX++;
                    space = 0;
            break;

        }

        postionX = Math.Clamp(postionX, 0, room.GetLength(0) - 1);
        postionY = Math.Clamp(postionY, 0, room.GetLength(1) - 1);
    

    // hier wird der Positon vom Spieler ermittelt und gezählt auf wieviel Felder er gehen könnte
    for (int x = -1; x <= 1; x++)
    {
        for (int y = -1; y <= 1; y++)
        {
            if (postionY + y >= 0 && postionY + y < room.GetLength(1) &&
                postionX + x >= 0 && postionX + x < room.GetLength(0) &&
                room[postionX + x, postionY + y] == " " && !(x == 0 && y == 0))
            {
                space++;
            }
            
        }
    }

}

    //hier wird die ausgabe auf der console erstellt
    void Print(string[,] room, int playerX, int playerY)
    {
        Console.Clear();
        Console.WriteLine($"Du kannst dich auf {space} Felderbewegen");

    for (int y = 0; y < room.GetLength(1); y++)
        {
            for (int x = 0; x < room.GetLength(0); x++)
            {
                if (playerX == x && playerY == y)
                {
                    Console.Write("X");

                }
                else
                {
                    Console.Write(room[x, y]);
                }
            }
            Console.WriteLine();

        }

    }
  







//    string[,] wall = new string[5, 5];
//    oben
//    wall[0, 0] = "-";
//    wall[1, 0] = "-";
//    wall[2, 0] = "-";
//    wall[3, 0] = "-";
//    wall[4, 0] = "-";

//    links
//    wall[0, 1] = "|";
//    wall[0, 2] = " ";
//    wall[0, 3] = "|";

//    rechts
//    wall[4, 1] = "|";
//    wall[4, 2] = " ";
//    wall[4, 3] = "|";

//    unten
//    wall[0, 4] = "-";
//    wall[1, 4] = "-";
//    wall[2, 4] = "-";
//    wall[3, 4] = "-";
//    wall[4, 4] = "-";

//    innenraum
//    wall[1, 1] = "#";
//    wall[1, 2] = "#";
//    wall[1, 3] = "#";

//    wall[2, 1] = "#";
//    wall[2, 2] = "#";
//    wall[2, 3] = "#";

//    wall[3, 1] = "#";
//    wall[3, 2] = "#";
//    wall[3, 3] = "#";


