﻿namespace ET.Client
{
	[Event(SceneType.Client)]
	public class LoginFinish_CreateLobbyUI: AEvent<EventType.LoginFinish>
	{
		protected override async ETTask Run(Scene scene, EventType.LoginFinish args)
		{
			await scene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Lobby);
			scene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
		}
	}
}
