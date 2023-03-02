namespace Azimuth
{
	public abstract class Game
	{
		public abstract void Load();
		public abstract void Unload();
		
		public virtual void Draw()
		{
			
		}

		public virtual void Update(float _deltaTime)
		{
			
		}

	}
}