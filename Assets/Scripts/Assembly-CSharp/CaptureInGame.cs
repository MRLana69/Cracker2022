using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using SYBO.Subway.Themes;
using UnityEngine;

public class CaptureInGame : AScreenCapture
{
	private sealed class _003CCaptureAllFrames_003Ed__2(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CaptureInGame _003C_003E4__this;

		private int _003CframeCount_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected I4, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00e9;
				}
				_003C_003E1__state = -1;
				num = _003CframeCount_003E5__2;
			}
			else
			{
				_003CframeCount_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			int num2 = num + 1;
			_003CframeCount_003E5__2 = num2;
			int num3 = obj + 12;
			string text = ((int*)num3)->ToString();
			string name = "frame_" + text;
			ThemeManager instance = ThemeManager.Instance;
			instance.DistortionYFlipped = true;
			_003C_003E4__this.SaveScreenshot(name);
			ThemeManager instance2 = ThemeManager.Instance;
			instance2.DistortionYFlipped = false;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_00e9;
			IL_00e9:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private GameObject _coroutineObject;

	public CaptureInGame(string captureFolder, int width, int height, Camera camera)
		: base(captureFolder, width, height, camera)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		Time.captureFramerate = 60;
		string[] files = Directory.GetFiles(captureFolder);
		object obj = 0;
		while (files.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)files + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25+10]");
			File.Delete((string)0);
			object obj4 = obj + 1;
			obj = obj4;
		}
		GameObject gameObject = default;
		gameObject._002Ector();
		_coroutineObject = gameObject;
		_coroutineObject.hideFlags = HideFlags.HideAndDontSave;
		Coroutine coroutine = _coroutineObject.AddComponent<NewMonoBehaviour>().StartCoroutine(CaptureAllFrames());
	}

	private IEnumerator CaptureAllFrames()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Cleanup()
	{
		base.Cleanup();
		MonoBehaviour component = _coroutineObject.GetComponent<MonoBehaviour>();
		component.StopAllCoroutines();
		UnityEngine.Object.Destroy(_coroutineObject);
		Time.captureFramerate = 0;
	}
}
