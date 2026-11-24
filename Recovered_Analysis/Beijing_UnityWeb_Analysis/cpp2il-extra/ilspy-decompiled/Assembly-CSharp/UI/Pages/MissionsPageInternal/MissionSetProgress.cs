using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using UI.Pages.DailyChallengePageInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Pages.MissionsPageInternal;

public class MissionSetProgress : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UISprite, bool> _003C_003E9__9_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MissionCell._003C_003Ec obj = default;
			MissionCell._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CBounceNextProgressDot_003Eb__9_0(UISprite s)
		{
			_ = ((UnityEngine.Object)s).m_CachedPtr;
			_ = s.rightAnchor;
			_ = s.topAnchor;
			_ = ((UIRect)s).mGo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+24]");
			return (nint)0 != 0;
		}
	}

	private sealed class _003CBounceObject_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite spriteToBounce;

		public MissionSetProgress _003C_003E4__this;

		public float duration;

		public Action callWhenFinished;

		private UISprite _003CblinkSprite_003E5__2;

		private float _003CcurrentDuration_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04da: Expected I4, but got Unknown
				//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e8: Expected Obj, but got Unknown
				//IL_0051: Expected I, but got Obj
				//IL_0067: Expected Obj, but got I
				//IL_0517: Unknown result type (might be due to invalid IL or missing references)
				//IL_051c: Expected Obj, but got Unknown
				//IL_0554: Expected Obj, but got I4
				//IL_00e3: Expected Obj, but got I4
				//IL_00f2: Expected Obj, but got F4
				//IL_0111: Expected I4, but got Obj
				//IL_0092: Expected I, but got Obj
				//IL_03f5: Expected I, but got Obj
				//IL_040b: Expected Obj, but got I
				//IL_0600: Expected I, but got Obj
				//IL_0616: Expected Obj, but got I
				//IL_0253: Expected Obj, but got I4
				//IL_0649: Expected I4, but got Obj
				//IL_0663: Expected Obj, but got I4
				//IL_0436: Expected I, but got Obj
				//IL_0483: Expected I, but got Obj
				//IL_0301: Expected I, but got Obj
				//IL_0317: Expected Obj, but got I
				//IL_0590: Expected I4, but got Obj
				//IL_05aa: Expected VT, but got I4
				//IL_05bb: Expected I4, but got Obj
				//IL_05d5: Expected Obj, but got I4
				//IL_0387: Unknown result type (might be due to invalid IL or missing references)
				//IL_038c: Expected Obj, but got Unknown
				//IL_0395: Expected Obj, but got I4
				//IL_03a9: Expected Obj, but got I4
				//IL_0342: Expected I, but got Obj
				object obj = default;
				UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 32);
				object obj2 = obj + 16;
				MissionSetProgress missionSetProgress = _003C_003E4__this;
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
					GameObject gameObject = spriteToBounce.gameObject;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = this + 32;
					UISprite uISprite = UnityEngine.Object.Instantiate(spriteToBounce, (Transform)(object)gameObject);
					obj4 = uISprite;
					UISprite uISprite2 = _003CblinkSprite_003E5__2;
					UIWidget uIWidget = (UIWidget)(((UIWidget)uISprite2).mDepth + 1);
					Vector2 localSize = uIWidget.localSize;
					GameObject gameObject2 = _003CblinkSprite_003E5__2.gameObject;
					UIExtensions.RepositionImmediately((UIGrid)(object)gameObject2);
					obj2 = 0;
					_ = 0;
					obj2 = 1f;
					_ = 1f;
					_ = 1f;
					_ = 0f;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					_003CblinkSprite_003E5__2.rawPivot = pivot;
					string tag = _003CblinkSprite_003E5__2.tag;
					missionSetProgress._cachedBlinks.Add((GameObject)(object)tag);
					_003CcurrentDuration_003E5__3 = 0f;
				}
				if (!(_003CcurrentDuration_003E5__3 > duration))
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num3 = _003CcurrentDuration_003E5__3 + fixedDeltaTime;
					_003CcurrentDuration_003E5__3 = num3;
					float defaultValue = _003CcurrentDuration_003E5__3 / duration;
					float num4 = PlayerPrefs.GetFloat((string)(object)missionSetProgress._progressCellScaleEffect, defaultValue);
					float num5 = duration / 10f;
					bool flag = _003CcurrentDuration_003E5__3 > num5;
					float num6 = duration / 5f;
					bool flag2 = _003CcurrentDuration_003E5__3 < num6;
					object obj5 = flag & flag2;
					if (obj5 != null)
					{
						float num7 = duration / 5f;
						float num8 = duration / 10f;
						float num9 = num7 - num8;
						float p = _003CcurrentDuration_003E5__3 / num9;
						float num10 = Easings.BackEaseInOut(p);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					}
					GameObject gameObject3 = spriteToBounce.gameObject;
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v53 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v67 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					Vector3 vector = (Vector3)pivot / num4;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					((Transform)(object)gameObject3).parent = (Transform)pivot;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				string tag2 = _003CblinkSprite_003E5__2.tag;
				bool flag3 = missionSetProgress._cachedBlinks.Remove((GameObject)(object)tag2);
				string tag3 = _003CblinkSprite_003E5__2.tag;
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag3);
				GameObject gameObject4 = spriteToBounce.gameObject;
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num16 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward2 = Vector3.forward;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				((Transform)(object)gameObject4).parent = (Transform)pivot;
				TransformExtensions.Reset((Transform)(object)callWhenFinished);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

	private List<UISprite> _fillSprites;

	private AnimationCurve _progressCellScaleEffect;

	private float _bounceEffectDuration;

	private GameObject _mysteryBoxIcon;

	private GameObject _starIcon;

	private const string INACTIVE_DOT = "mission_progress_dot";

	private const string ACTIVE_DOT = "mission_progress_dot_completed";

	private List<GameObject> _cachedBlinks;

	public unsafe void SetMissionSetProgress(int progress)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = ((int*)progress)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [progress @ L1 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [progress @ L1 (System.Int32)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [progress @ L1 (System.Int32)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [progress @ L1 (System.Int32)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8284");
		((MissionCell)this).RefreshState();
	}

	public void BounceNextProgressDot(Action callback = null)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		List<> list = default;
		list._items = (T[])num;
		list._syncRoot = 0;
		object obj2 = list + 16;
		obj2 = 0;
		List<_00210>.Enumerator enumerator = (List<_00210>.Enumerator)((List<T>)(object)list).GetEnumerator();
		throw new IndexOutOfRangeException();
	}

	public void BounceReward()
	{
		CancelInvoke();
	}

	public unsafe void ChangeToMysteryBoxReward(bool animate = false)
	{
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_023c: Invalid comparison between VT and I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0101: Expected I4, but got Obj
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_011a: Expected VT, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionSetProgress+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v47 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionSetProgress+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__9_0 == null;
		bool flag2 = !flag;
		Func<UISprite, bool> predicate = _003C_003Ec._003C_003E9__9_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v21 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionSetProgress+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v41 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionSetProgress+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<UISprite, bool> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v38 (Il2CppClass<UI.Pages.MissionsPageInternal.MissionSetProgress+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			predicate = func;
		}
		int num7 = Enumerable.Count(_fillSprites, predicate);
		_0021_00210 eventValue = (_0021_00210)((ExpiredLimitedBoardEventManager)(object)_fillSprites).GetEventValue<T>(out *(bool*)num7);
		if (eventValue != (_0021_00210)(object)0)
		{
			UISprite uISprite = _fillSprites.get_Item(num7);
			uISprite.fillCenter = (byte)(int)"mission_progress_dot_completed" != 0;
			IEnumerator routine = ((CelebrationPopup)this).RotateGameObject((Transform)(object)uISprite, _bounceEffectDuration, (Vector3)animate);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	public float GetBounceDuration()
	{
		//IL_001d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionSetProgress)+4C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionSetProgress)+3C]");
		object obj = num + 0;
		float num2 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.MissionsPageInternal.MissionSetProgress)+7C]");
		return num2 + 0f;
	}

	private IEnumerator BounceObject(UISprite spriteToBounce, float duration, Action callWhenFinished = null)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = spriteToBounce;
		_ = ((Delegate)callWhenFinished).method_ptr;
		object obj2 = enumerator + 24;
		obj2 = callWhenFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return enumerator;
	}

	private void TestBounce1()
	{
		//IL_0065: Expected VT, but got I4
		//IL_0029: Expected VT, but got I4
		UISprite component = _mysteryBoxIcon.GetComponent<UISprite>();
		IEnumerator routine = ((CelebrationPopup)this).RotateGameObject((Transform)(object)component, _bounceEffectDuration, (Vector3)0);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		UISprite component2 = _starIcon.GetComponent<UISprite>();
		IEnumerator routine2 = ((CelebrationPopup)this).RotateGameObject((Transform)(object)component2, _bounceEffectDuration, (Vector3)0);
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
	}

	private void TestBounce2()
	{
		UISprite payload = _fillSprites.get_Item(0);
		((FinalDayHelper)this).SetupDay((FinalDayHelper.DailyWordPayload)(object)payload);
	}

	private void TestBounce3()
	{
		UISprite payload = _fillSprites.get_Item(1);
		((FinalDayHelper)this).SetupDay((FinalDayHelper.DailyWordPayload)(object)payload);
	}

	private void TestBounce(UISprite sprite)
	{
		//IL_0062: Expected Obj, but got I4
		//IL_0029: Expected VT, but got I4
		_starIcon.tag = null;
		_mysteryBoxIcon.tag = (string)1;
		if ((object)sprite != null)
		{
			UISprite component = _mysteryBoxIcon.GetComponent<UISprite>();
			IEnumerator routine = ((CelebrationPopup)this).RotateGameObject((Transform)(object)component, _bounceEffectDuration, (Vector3)0);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	private void TestMysteryBoxBounce()
	{
		UISprite payload = _fillSprites.get_Item(2);
		((FinalDayHelper)this).SetupDay((FinalDayHelper.DailyWordPayload)(object)payload);
	}

	public MissionSetProgress()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		throw new ArrayTypeMismatchException();
	}

	private void _003CTestMysteryBoxBounce_003Eb__18_0()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UISprite> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list2 = default;
		((List<T>)(object)list2)._002Ector((IEnumerable<T>)3);
		object obj2 = this + 32;
		obj2 = list2;
		CancelInvoke();
	}
}
