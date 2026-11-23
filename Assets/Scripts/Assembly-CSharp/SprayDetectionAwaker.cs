using System;
using UnityEngine;

public class SprayDetectionAwaker : MonoBehaviour
{
	private RunnerAnimPlayer runnerAnimPlayer;

	private void Start()
	{
		RunnerAnimPlayer runnerAnimPlayer = Utils.FindObject<RunnerAnimPlayer>();
		this.runnerAnimPlayer = runnerAnimPlayer;
		if (UIScreenController.IsInstanced)
		{
			UIScreenController instance = UIScreenController.Instance;
			throw new ArgumentException();
		}
	}

	private void CheckScreen(string screenName)
	{
		RunnerAnimPlayer runnerAnimPlayer = this.runnerAnimPlayer;
		bool playPaintSound = screenName == "FrontUI";
		runnerAnimPlayer.playPaintSound = playPaintSound;
	}
}
