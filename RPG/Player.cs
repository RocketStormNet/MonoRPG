using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
    class Player
    {
        private Vector2 position = new Vector2(200, 200);
        private int health = 3;
        private int speed = 200;
        private Dir direction = Dir.Down;

        public int Health { get; set; }

        public Vector2 Position { get; }

        public void setX(float newX)
        {
            position.X = newX;
        }

        public void setY(float newY)
        {
            position.Y = newY;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
            }

            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
            }
        }
    }
}
