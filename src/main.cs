using Raylib_cs;
using System;

namespace HelloWorld;

class Program
{
    public static void Main(string[] args)
    {
        Raylib.InitWindow(800, 480, "Hello World");
        int x = 100;
        int y = 100;
        int key_up = 87;
        int key_down = 83;
        while (!Raylib.WindowShouldClose())
        {
            Raylib.SetTargetFPS(10);
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.White);
            if (Raylib.IsKeyDown(KeyboardKey.Up)) {
                y -= 10;
            }
            if (Raylib.IsKeyDown(KeyboardKey.Down)) {
                y += 10;
            }
            Raylib.DrawCircle(x, y, 10, Color.White);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}