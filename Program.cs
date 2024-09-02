using System.Diagnostics;
using Raylib_cs;
using static Raylib_cs.Raylib;

public class RaylibGame
{
    public static int Main()
    {
        Console.WriteLine("Je suis passé par là");
        InitWindow(800, 600, "Premier programme Raylib !");

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.White);
            EndDrawing();
        }

        CloseWindow();
        return 0;
    }
}