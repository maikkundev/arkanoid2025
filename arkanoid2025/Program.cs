using Raylib_cs;

public class Game {
    public static void Main() {
        // Initialize the window and raylib
        Raylib.InitWindow(800, 600, "Brick Game");
        Raylib.SetTargetFPS(60);

        // Load a texture
        Texture2D texture = Raylib.LoadTexture("brick.png");

        // Create a brick
        Brick brick = new Brick(new Rectangle(100, 100, 64, 32), texture, Color.Red, true);

        while(!Raylib.WindowShouldClose()) // Main game loop
        {
            // Start drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            // Draw the brick
            brick.Draw();

            // End drawing
            Raylib.EndDrawing();
        }

        // Unload the texture when finished
        Raylib.UnloadTexture(texture);

        // Close the window
        Raylib.CloseWindow();
    }
}
