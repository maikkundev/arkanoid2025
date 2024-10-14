using System.Numerics;
using Raylib_cs;  // Import raylib-cs namespace

public class Brick {
  public Rectangle Rectangle;
  public Texture2D Texture;
  public Color Color;
  public bool Visible;

  // Constructor
  public Brick(Rectangle rectangle, Texture2D texture, Color color, bool visible) {
    this.Rectangle = rectangle;
    this.Texture = texture;
    this.Color = color;
    this.Visible = visible;
  }

  // Intersects function: Checks if this brick intersects with a ball
  private bool Intersects(Rectangle ball) {
    return Raylib.CheckCollisionRecs(Rectangle, ball);
  }

  // Draw function: Draws the brick if it's visible
  public void Draw() {
    if(Visible) {
      Raylib.DrawTexturePro(
          Texture,  // Texture to draw
          new Rectangle(0, 0, Texture.Width, Texture.Height),  // Source rectangle (full texture)
          Rectangle,  // Destination rectangle (where to draw on screen)
          new Vector2(0, 0),  // Origin for rotation (top-left in this case)
          0.0f,  // No rotation
          Color  // Tint color
      );
    }
  }

  // CheckHit function: Checks if the brick is hit by the ball
  public bool CheckHit(Rectangle ball) {
    if(this.Visible && Intersects(ball)) {
      Visible = false;  // Hide the brick when hit
      return true;
    }
    return false;
  }
}
