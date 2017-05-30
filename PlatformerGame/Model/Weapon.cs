using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace PlatformerGame.Model
{
    public class Weapon
    {
		private Texture2D texture;
		private Vector2 origin;
		private SoundEffect collectedSound;

		public const int PointValue = 30;
		public readonly Color Color = Color.Yellow;

		// The gem is animated from a base position along the Y axis.
		private Vector2 basePosition;
		private float bounce;

		public Level Level
		{
			get { return level; }
		}
		Level level;

		/// <summary>
		/// Gets the current position of this gem in world space.
		/// </summary>
		public Vector2 Position
		{
			get
			{
				return basePosition + new Vector2(0.0f, bounce);
			}
		}

		/// <summary>
		/// Gets a circle which bounds this gem in world space.
		/// </summary>
		public Circle BoundingCircle
		{
			get
			{
				return new Circle(Position, Tile.Width / 3.0f);
			}
		}

        public Weapon()
        {
        }
    }
}
