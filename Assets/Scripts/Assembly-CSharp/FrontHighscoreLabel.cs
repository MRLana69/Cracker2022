using System;
using Cpp2ILInjected;
using UnityEngine;

public class FrontHighscoreLabel : MonoBehaviour
{
	private UILabel _highScoreLabel;

	private unsafe void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FrontHighscoreLabel.UpdateHighScore));
		Delegate obj = Delegate.Combine(instance.onHighScoreChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onHighScoreChanged = default;
		instance.onHighScoreChanged = onHighScoreChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UpdateHighScore();
	}

	private unsafe void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FrontHighscoreLabel.UpdateHighScore));
		Delegate obj = Delegate.Remove(instance.onHighScoreChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onHighScoreChanged = default;
		instance.onHighScoreChanged = onHighScoreChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void UpdateHighScore()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = this + 12;
		if (_highScoreLabel == null)
		{
			UILabel component = GetComponent<UILabel>();
			_highScoreLabel = component;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._highScore;
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:0000}";
		((UILabel)obj3).text = text;
	}
}
