using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;

namespace WaterWheel
{
	public class Entity
	{

		// CHANGES

		public int Hp;
		public bool InAir;
		public bool IsIdle;
		public Vector2 Location;
		public Vector2 TargetLocation;

		// DOESN'T CHANGE (USED IN CONSTRUCTOR)
		public Rectangle Hitbox;
		public int MaxHP;
		public int ID;
		public int Width;
		public int Height;
		

		public Entity() { }

		public Entity(Rectangle hitbox, int maxHp, int iD, int width, int height)
		{
			// BASIC ENTITY CONSTUCTOR

			Hitbox = hitbox;
			MaxHP = maxHp;
			ID = iD;
			Width = width;
			Height = height;
		}
	}
}
