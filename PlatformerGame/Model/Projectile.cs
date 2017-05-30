using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformerGame.Model
{
    public class Projectile
    {

        public Vector2 position;

        public bool Active;

        public int Damage;

        Viewport viewport;

        //public int Width
        //{
        //    get { return Texture.Width;  }
        //}

        //public int Height
        //{
        //    get { return Texture.Height; }
        //}

        float projectileMoveSpeed;

        public Projectile()
        {
        }
    }
}
