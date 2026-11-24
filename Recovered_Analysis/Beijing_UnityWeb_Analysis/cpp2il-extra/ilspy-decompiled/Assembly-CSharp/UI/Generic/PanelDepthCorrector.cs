using Cpp2ILInjected;
using Kiloo.Common.Timer;
using UnityEngine;

namespace UI.Generic;

public class PanelDepthCorrector : MonoBehaviour
{
	private enum Execute
	{
		Off,
		OnEnable,
		OnStart,
		OnUpdate,
		OnFixedUpdate,
		OnLateUpdate
	}

	private UIPanel _targetPanel;

	private Execute _execute;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Start()
	{
		if (_execute == Execute.OnEnable)
		{
			this._002Ector();
		}
	}

	private void Update()
	{
		if (_execute == Execute.OnStart)
		{
			this._002Ector();
		}
	}

	private void FixedUpdate()
	{
		if (_execute == Execute.OnUpdate)
		{
			this._002Ector();
		}
	}

	private void LateUpdate()
	{
		if (_execute == Execute.OnFixedUpdate)
		{
			this._002Ector();
		}
	}

	public void CorrectNow()
	{
		if (_execute == Execute.OnLateUpdate)
		{
			this._002Ector();
		}
	}

	public PanelDepthCorrector()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj = text + 16;
		obj = this;
		Timer.Log(text);
	}

	private void _003CCorrectNow_003Eb__8_0()
	{
		CancelInvoke();
	}
}
