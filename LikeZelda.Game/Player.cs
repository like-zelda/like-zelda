using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace LikeZelda
{
	public class Player
	{
		#region Fields

		public Texture2D sprite { get; set; }

		float x;
		float y;

		#endregion

		public Player ()
		{
			x = 10;
			y = 10;
		}

		public void drawTo (SpriteBatch spriteBatch) {
			spriteBatch.Draw (sprite, new Vector2 (x, y), Color.White);
		}
	}
}

