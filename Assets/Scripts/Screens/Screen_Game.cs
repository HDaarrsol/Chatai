using UnityDev_Devesh.UI_Screen_Controller;

public class Screen_Game : USC_BaseScreen
{
	public override void Initialize()
	{
		base.screen_type = USC_SCREENS.Game;
	}


	public override void Show()
	{
		base.Show();
	}
	protected override void ShowCompleted()
	{
		base.ShowCompleted();
	}


	public override void Hide()
	{
		base.Hide();
	}
	protected override void HideCompleted()
	{
		base.HideCompleted();
	}
}
