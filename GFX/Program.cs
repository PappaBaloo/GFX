using System;
using Raylib_cs;

namespace GFX
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "lmao");

            string scene = "Start";

            float cx = 30;
            float cy = 30;

            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();

                if (scene == "Start")
                {
                    Raylib.ClearBackground(Color.DARKGREEN);
                    Raylib.DrawText("Press [ENTER] To START", 100, 50, 20, Color.WHITE);

                    cx = 30;
                    cy = 30;

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "game";
                    }
                }
                else if (scene == "game")
                {
                    Raylib.ClearBackground(Color.DARKPURPLE);

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        cy += 0.3f;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        cy -= 0.3f;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        cx += 0.3f;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        cx -= 0.3f;
                    }

                    Raylib.DrawText("To go back to menu press [TAB]", 10, 10, 10, Color.WHITE);
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Start";
                    }

                    if (cy > Raylib.GetScreenHeight() || cx > Raylib.GetScreenWidth())
                    {
                        scene = "gameover";
                    }
                    if (cy < 0 || cx < 0)
                    {
                        scene = "gameover";
                    }

                    Raylib.DrawCircle((int)cx, (int)cy, 10, Color.GOLD);



                }
                else if (scene == "gameover")
                {
                    Raylib.ClearBackground(Color.BLACK);
                    Raylib.DrawText("GAME OVER", 350, 250, 20, Color.WHITE);
                    Raylib.DrawText("CLOSE THE GAME NOW", 350, 300, 20, Color.WHITE);

                }


                Raylib.EndDrawing();

            }
        }
    }
}
