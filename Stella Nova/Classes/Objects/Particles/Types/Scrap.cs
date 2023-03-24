using Microsoft.Xna.Framework;
using Stella_Nova.Classes.Utilities;
using System.Collections.Generic;

namespace Stella_Nova.Classes.Objects.Particles.Types
{
    public class Scrap : Particle
    {
        public override List<Vector2> GenerateShape()
        {
            switch (Main.random.Next(3))
            {
                case 0:
                    return Drawing.Rectangle(32, 10);
                case 1:
                    return Drawing.Rectangle(12, 32);
                default:
                    return Drawing.Ellipse(5, 8);
            }
        }
        public override SpaceObject Clone()
        {
            return (SpaceObject)MemberwiseClone();
        }
    }
}