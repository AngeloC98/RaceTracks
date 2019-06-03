using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Racetracks
{
    class Car : Body
    { 
        /// <summary>Creates a user controlled Car</summary>        
        public Car(Vector2 position) : base(position, "car")
        {
            offsetDegrees = -90;
        }

        /// <summary>Updates this Car</summary>        
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        /// <summary>Handle user input for this Car</summary>        
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.A))
            {
                addAngularForce(-3f);
            }
            if (inputHelper.IsKeyDown(Keys.D))
            {
                addAngularForce(3f);
            }
            if (inputHelper.IsKeyDown(Keys.W))
            {
                addForce(Forward * 5f);
            }
            if (inputHelper.IsKeyDown(Keys.S))
            {
                addForce(Forward * -5f);
            }

        }

    }
}
