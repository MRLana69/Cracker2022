using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using UnityEngine;

public class CaptureAnimation : AScreenCapture
{
	private sealed class _003CCaptureAnimationToEnd_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CaptureAnimation _003C_003E4__this;

		private int _003CframeCount_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0067: Expected Obj, but got I4
				//IL_007b: Expected Obj, but got I4
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Expected Obj, but got Unknown
				//IL_023c: Expected Obj, but got I4
				//IL_0250: Expected Obj, but got I4
				//IL_00f8: Expected Obj, but got I4
				//IL_011c: Expected Obj, but got I
				//IL_014f: Expected Obj, but got I
				//IL_0161: Expected Obj, but got I4
				//IL_0182: Expected Obj, but got I
				CaptureAnimation captureAnimation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
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
					if (_003CframeCount_003E5__2 != 0)
					{
						int num = _003CframeCount_003E5__2 + 1;
						_003CframeCount_003E5__2 = num;
						object obj = _003CframeCount_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (CaptureAnimation)+24]");
						string text = default;
						string camera = (string)0 + "_" + text;
						((AScreenCapture)captureAnimation).Screenshot((Camera)(object)camera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (CaptureAnimation)+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (CaptureAnimation)+24]");
						bool flag = ((Animation)num2).Play(PlayMode.StopSameLayer);
						float normalizedTime = ((AnimationState)flag).normalizedTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (CaptureAnimation)+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (CaptureAnimation)+24]");
						bool flag2 = ((Animation)num3).Play(PlayMode.StopSameLayer);
						float distance = (flag2 ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
						if (!(normalizedTime < distance))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							return null;
						}
					}
					else
					{
						int num4 = _003CframeCount_003E5__2 + 1;
						_003CframeCount_003E5__2 = num4;
					}
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCaptureAnimationToEnd_003Ed__6(int _003C_003E1__state)
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (_003C_003E1__state == 0)
			{
				return;
			}
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
		}

		void IDisposable.Dispose()
		{
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

	private Animation _animation;

	private string _animationName;

	private Action _onDone;

	private GameObject _coroutineObject;

	public unsafe CaptureAnimation(Animation animation, string captureFolder, string animationName, int width, int height, int fps, Camera camera, Action onDone)
	{
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0395: Expected Obj, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c7: Expected Obj, but got F8
		//IL_0402: Expected I, but got Obj
		//IL_0418: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_055e: Expected I4, but got Obj
		//IL_056f: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0046: Expected I, but got Obj
		//IL_043d: Expected Obj, but got VT
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0481: Expected Obj, but got F8
		//IL_048f: Expected I, but got Obj
		//IL_04a5: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I4
		//IL_0186: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		//IL_058c: Expected I, but got Obj
		//IL_05a2: Expected Obj, but got I
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0269: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CaptureAnimation)+38]");
		object obj6;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CaptureAnimation)+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v73+8]");
			obj6 = 0;
		}
		else
		{
			obj6 = "";
		}
		Animation animation2 = (Animation)obj6;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v103 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		((int*)width)->m_value = (int)bundleIdentifier;
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		obj = bragScoreThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int value = default;
		((int*)height)->m_value = value;
		DateTime utcNow = CDateTime.UtcNow;
		nint num3 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v99 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = utcNow;
		object obj9 = obj2 + 24;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D775");
		object obj10 = default;
		obj3 = obj10;
		double num5 = (double)obj3 * 2.7777777777777777E-11;
		obj4 = num5;
		nint num6 = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v95 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		OverflowException ex = new OverflowException();
		Camera camera2 = (Camera)(object)ex;
		bool soundEffectsEnabled = PreferencesSave.soundEffectsEnabled;
		Action action = (Action)soundEffectsEnabled;
		nint num8 = (nint)onDone;
		bool flag;
		if (onDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v43 (Il2CppClass<System.Action>)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			nint num9 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v82 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num10 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v87 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
			action = (Action)(object)unfilteredLocale;
		}
		nint num11 = (nint)typeof(RemoteNotificationControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v47 (Il2CppClass<RemoteNotificationControl>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num12 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v77 (Il2CppClass<RemoteNotificationControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SocialManager instance = SocialManager.instance;
		string text = (string)(object)instance;
		string text2 = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public CaptureAnimation(Animation animation, string captureFolder, string animationName, int width, int height, int fps, Camera[] camera, Action onDone)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator CaptureAnimationToEnd()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0334: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (base._height != 0)
		{
			if ((object)_animation == null)
			{
				return (IEnumerator)1;
			}
			Dictionary<string, GameCenterProfile>.KeyCollection keys = ((Dictionary<string, GameCenterProfile>)base._height).Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj6 == null)
					{
						object obj7 = obj4 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj4 + obj9;
						obj10 = 90;
						break;
					}
					continue;
				}
				object obj11 = obj4 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj4 + obj13;
				obj14 = 88;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj4 + obj15;
				if ((nint)obj16 == 90)
				{
					object obj17 = obj4 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					return (IEnumerator)1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj4 + obj19;
				if ((nint)obj20 == 88)
				{
					object obj21 = obj4 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_041f;
				}
			}
			object obj23 = default;
			if (obj23 == null)
			{
				return (IEnumerator)1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_041f;
		IL_041f:
		IEnumerator result = default;
		return result;
	}

	public override void Cleanup()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(base._renderTexture);
	}
}
