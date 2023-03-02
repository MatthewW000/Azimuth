using Azimuth;
using Azimuth.UI;

using Raylib_cs;

using System.Numerics;

namespace Azimuth_Test
{
	public class AzimuthTestGame : Game
	{
		private ImageWidget image;
		private Button button;

		private void OnClickButton()
		{
			Console.WriteLine("hello world");
		}
		
		public override void Load()
		{
			int counter = 0;
			
			image = new ImageWidget(Vector2.Zero, new Vector2(200, 400), "imageWidget");
			button = new Button(Vector2.Zero, new Vector2(150, 75), Button.RenderSettings.normal);
			button.SetDrawLayer(100);
			button.AddListener(OnClickButton);
				//UIManager.Add(image);
			button.AddListener(() =>
			{
				if(counter % 2 == 0)
				{
					UIManager.Add(image);
				}
				else
				{
					UIManager.Remove(image);
				}

				counter++;
			});
			UIManager.Add(button);

		}

		public override void Unload()
		{
			
		}
	}
}