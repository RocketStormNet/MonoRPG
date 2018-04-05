﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
    class Player
    {
        private Vector2 position = new Vector2(200, 200);
        private int health = 3;
        private int speed = 10;
        private Dir direction = Dir.Down;
        private bool isMoving = false;

        public AnimatedSprite anim;
        public AnimatedSprite[] animations = new AnimatedSprite[4];

        public int Health { get; set; }

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }

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

            anim = animations[(int)direction];

            if (isMoving)
            {
                anim.Update(gameTime);
            }
            else
            {
                anim.setFrame(1);
            }

            isMoving = false;

            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
                isMoving = true;
            }

            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
                isMoving = true;
            }

            if (isMoving)
            {
                switch (direction)
                {
                    case Dir.Right:
                        position.X += speed + dt;
                        break;
                    case Dir.Left:
                        position.X -= speed + dt;
                        break;
                    case Dir.Up:
                        position.Y -= speed + dt;
                        break;
                    case Dir.Down:
                        position.Y += speed + dt;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
