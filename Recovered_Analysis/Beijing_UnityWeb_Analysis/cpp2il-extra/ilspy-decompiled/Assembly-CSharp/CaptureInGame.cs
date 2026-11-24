using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Subway.StateSystem;
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

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0082: Expected Obj, but got I4
				//IL_00b1: Expected I, but got Obj
				//IL_00c7: Expected Obj, but got I
				//IL_01b1: Expected Obj, but got I4
				//IL_00f2: Expected I, but got Obj
				//IL_014f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Expected Obj, but got Unknown
				//IL_015d: Expected Obj, but got I4
				//IL_0171: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CframeCount_003E5__2 = 0;
				}
				int num = _003CframeCount_003E5__2 + 1;
				_003CframeCount_003E5__2 = num;
				object obj = _003CframeCount_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = default;
				string camera = "frame_" + text;
				nint num2 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v23 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(ThemeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v36 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameStateMachine instance = GameStateMachine.Instance;
				instance._002Ector((IScheduler)1);
				((AScreenCapture)_003C_003E4__this).Screenshot((Camera)(object)camera);
				GameStateMachine instance2 = GameStateMachine.Instance;
				instance2._002Ector((IScheduler)null);
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private GameObject _coroutineObject;

	public unsafe CaptureInGame(string captureFolder, int width, int height, Camera camera)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = captureFolder;
		object obj3 = obj2 + 12;
		obj3 = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CharacterModelPreviewFactory._003C_003Ec__DisplayClass11_0._003CGetCharacterModelPreview_003Eb__0);
		object obj4 = action + 16;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		((CoinEarnerVideoAds)(object)this).Init(0, (string)width, (string)null, (string)null, 1, action, (UIScrollView)(object)camera);
	}

	private IEnumerator CaptureAllFrames()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public override void Cleanup()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((CaptureAnimation)this).Cleanup();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CaptureInGame)+2C]");
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
		TouchScreenKeyboard.Internal_Destroy((IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CaptureInGame)+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
