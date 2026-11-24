using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using UI.Screens;
using UnityEngine;

public class TableElementAlwaysVisible : MonoBehaviour
{
	private sealed class _003CMovePanelAfterFrames_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public TableElementAlwaysVisible _003C_003E4__this;

		public float noOfPixels;

		private int _003CnumberOfFrames_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Expected Obj, but got Unknown
				//IL_00d1: Expected Obj, but got I4
				//IL_00e5: Expected Obj, but got I4
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
					_003CnumberOfFrames_003E5__2 = 0;
				}
				if (_003CnumberOfFrames_003E5__2 < frames)
				{
					int num = _003CnumberOfFrames_003E5__2 + 1;
					_003CnumberOfFrames_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				((MoveGameObject)(object)_003C_003E4__this).SpeedMultiplier = noOfPixels;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0016: Expected Obj, but got I4
			frames = 1;
			_003C_003E4__this = (TableElementAlwaysVisible)1;
		}

		private bool MoveNext()
		{
			//IL_017e: Expected Obj, but got I
			//IL_00de: Expected I4, but got Obj
			//IL_00ec: Expected I4, but got Obj
			//IL_00fa: Expected I4, but got Obj
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_0116: Expected I4, but got Obj
			//IL_0124: Expected I4, but got Obj
			//IL_0108: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TableElementAlwaysVisible+<MovePanelAfterFrames>d__20)+24]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TableElementAlwaysVisible+<MovePanelAfterFrames>d__20)+24]");
			if ((nint)0 != 1)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj != 2 && (nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj == 5)
							{
								return (byte)(int)"Smooth Drift" != 0;
							}
							if ((nint)obj == 6)
							{
								return (byte)(int)"Zap sideways" != 0;
							}
							if ((nint)obj == 7)
							{
								return (byte)(int)"Trail" != 0;
							}
						}
						object obj2 = this + 36;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					return (byte)(int)"Speed up" != 0;
				}
				return (byte)(int)"Stay low" != 0;
			}
			return (byte)(int)"Super jump" != 0;
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

	private UIPanel _scrollPanel;

	private TweenHeight _largestTweenHeight;

	private float _scrollPanelStartY;

	private int _index;

	private UpgradeScreen _upgradeScreen;

	private unsafe UIPanel scrollPanel
	{
		get
		{
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected Obj, but got Unknown
			//IL_026b: Expected Obj, but got I4
			//IL_0279: Expected I, but got Obj
			//IL_028f: Expected Obj, but got I
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected I, but got Unknown
			//IL_0368: Expected I, but got Obj
			//IL_0383: Expected I, but got Obj
			//IL_0399: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00c0: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected Obj, but got Unknown
			//IL_013d: Expected I, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_01cb: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v69 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(Trophies.Trophy);
			nint num3 = (nint)(obj2 + 8);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type enumType = Type.internal_from_handle((IntPtr)num3);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v12 (Il2CppClass<System.Enum>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v37 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj6 = default;
			object obj5 = obj6 + 12;
			object obj7 = 0;
			object obj13 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj8 = obj6 + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				nint num6 = (nint)typeof(Trophies);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v36 (Il2CppClass<Info.Trophies>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num7 = (nint)typeof(Trophies);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v65 (Il2CppClass<Info.Trophies>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((Upgrade)obj10).GetName();
				if (text != null)
				{
					nint num8 = (nint)typeof(Trophies);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v46 (Il2CppClass<Info.Trophies>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num9 = (nint)typeof(Trophies);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v59 (Il2CppClass<Info.Trophies>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
					if (obj13 != null)
					{
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v55+C]");
						if (0 == (nint)this)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
						}
					}
				}
				object obj15 = obj7 + 1;
				obj7 = obj15;
			}
			UIPanel result = default;
			return result;
		}
	}

	public float ScrollPanelStartY
	{
		set
		{
		}
	}

	public bool IsExpanded
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0132: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected Obj, but got Unknown
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_scrollPanel))
			{
				string go = tag;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj3 = this + 12;
				UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
				obj3 = uIPanel;
			}
			return (byte)(int)_scrollPanel != 0;
		}
	}

	public unsafe int index
	{
		get
		{
			int height = _largestTweenHeight.height;
			TweenHeight largestTweenHeight = _largestTweenHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3 (System.Int32)+68]");
			return ((nint)0 != largestTweenHeight.from) ? 1 : 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0637: Unknown result type (might be due to invalid IL or missing references)
			//IL_063c: Expected Ref, but got Unknown
			//IL_064e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0653: Expected Obj, but got Unknown
			//IL_065c: Expected Obj, but got I4
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected Obj, but got Unknown
			//IL_067f: Expected Obj, but got I4
			//IL_0688: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected Obj, but got Unknown
			//IL_06bb: Expected Obj, but got I
			//IL_06cb: Expected Obj, but got I
			//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e1: Expected Obj, but got Unknown
			//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ef: Expected Obj, but got Unknown
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_0728: Expected Obj, but got I4
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected Obj, but got Unknown
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected Obj, but got Unknown
			//IL_0322: Expected Obj, but got I4
			//IL_032b: Expected Obj, but got I4
			//IL_0062: Expected I, but got Obj
			//IL_03b5: Expected Obj, but got I
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Expected Obj, but got Unknown
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Expected Obj, but got Unknown
			//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ac: Expected Obj, but got Unknown
			//IL_04d8: Expected Obj, but got I4
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected Obj, but got Unknown
			//IL_0579: Expected Obj, but got I
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Expected Obj, but got Unknown
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 80;
			ref int reference = ref *(int*)(obj2 - -64);
			reference = ref *(int*)null;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v3+60]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S4_v4 (should have been resolved before IL gen)");
			bool flag = value == 0;
			object obj11 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<TableElementAlwaysVisible, UIntPtr>(ref this))
			{
				nint num2 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v157 (Il2CppClass<MysteryBox>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num3 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v209 (Il2CppClass<MysteryBox>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount((MysteryBox.Type)value);
				object obj13 = megaJackpotAmount + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj14 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj14 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			}
			object obj15 = obj5 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj5 + obj17;
			obj18 = 265;
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
				object obj20 = (nint)0 << 2;
				object obj21 = obj5 + obj20;
				if ((nint)obj21 == 265)
				{
					object obj22 = obj5 + 4;
					if ((nint)obj22 > -1)
					{
						object obj23 = obj22 + -1;
						obj22 = obj23;
					}
					goto IL_08ad;
				}
			}
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_08ad;
			IL_08ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj24 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj24 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj25 = obj5 + 4;
			object obj26 = obj25 + 1;
			obj25 = obj26;
			object obj27 = obj26 << 2;
			object obj28 = obj5 + obj27;
			obj28 = 308;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
				object obj29 = (nint)0 << 2;
				object obj30 = obj5 + obj29;
				if ((nint)obj30 == 308)
				{
					object obj31 = obj5 + 4;
					if ((nint)obj31 > -1)
					{
						object obj32 = obj31 + -1;
						obj31 = obj32;
					}
					return;
				}
			}
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	private UpgradeScreen upgradeScreen
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (UpgradeScreen)_index;
		}
	}

	private void TheElementIsOnBottom(float bottomPointOnScreen, float bottomPointOfTable)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void TheElementIsOnTop(float topPointOnScreen, float topPointOfTable)
	{
		//IL_0068: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		if (Layers.FindLayer((string)(object)this) != 0)
		{
			if (AreAllClosed())
			{
				float depth = topPointOfTable - topPointOnScreen;
				Vector3[] sides = NGUITools.GetSides((Camera)(object)this, depth, (Transform)3);
				Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)sides);
			}
		}
		else if (WillExpand())
		{
			if (AreAllClosed())
			{
				float speedMultiplier = topPointOfTable - topPointOnScreen;
				((MoveGameObject)this).SpeedMultiplier = speedMultiplier;
			}
		}
		else if (hasAnotherElementOpenOnBottom() && AreAllClosed())
		{
			float num = topPointOfTable - topPointOnScreen;
			TweenHeight largestTweenHeight = _largestTweenHeight;
			TweenHeight largestTweenHeight2 = _largestTweenHeight;
			object obj = largestTweenHeight.to - largestTweenHeight2.from;
			float speedMultiplier2 = num - (float)obj;
			((MoveGameObject)this).SpeedMultiplier = speedMultiplier2;
		}
	}

	private void OnClick()
	{
	}

	public void ToggleButtonScale()
	{
		OnDestroy();
	}

	private IEnumerator MovePanelAfterFrames(float noOfPixels, int frames)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = frames;
		return enumerator;
	}

	private void MovePanelBy(float noOfPixels)
	{
		_scrollPanelStartY = noOfPixels;
	}

	private bool hasAnotherElementOpenOnTop()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0062: Expected I4, but got Obj
		_0021_00210[] array;
		if ((object)_upgradeScreen != null)
		{
			array = (_0021_00210[])(object)_upgradeScreen;
		}
		else
		{
			object obj = this + 28;
			_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
			obj = componentsInParent;
			array = componentsInParent;
		}
		return (byte)(int)array != 0;
	}

	private bool hasAnotherElementOpenOnBottom()
	{
		bool flag = hasAnotherElementOpenOnTop();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Boolean)+78]");
		if ((nint)0 < (nint)_index)
		{
			bool flag2 = hasAnotherElementOpenOnTop();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v8 (System.Boolean)+78]");
			return (nint)0 != -1;
		}
		return false;
	}

	private bool WillExpand()
	{
		bool flag = hasAnotherElementOpenOnTop();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Boolean)+78]");
		if ((nint)0 > (nint)_index)
		{
			bool flag2 = hasAnotherElementOpenOnTop();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v8 (System.Boolean)+78]");
			return (nint)0 != -1;
		}
		return false;
	}

	private bool AreAllClosed()
	{
		int height = _largestTweenHeight.height;
		TweenHeight largestTweenHeight = _largestTweenHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3 (System.Int32)+68]");
		return (nint)0 == largestTweenHeight.from;
	}

	private void OnDestroy()
	{
		//IL_0076: Expected VT, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_020a: Expected VT, but got Obj
		//IL_004c: Expected VT, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		bool flag = AreAllClosed();
		string text = tag;
		int layer = ((GameObject)(object)text).layer;
		float num;
		Transform transform = default;
		if (flag)
		{
			transform.localPosition = (Vector3)layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			num = 0f - 0f;
		}
		else
		{
			transform.localPosition = (Vector3)layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			num = 0f + 0f;
		}
		bool isExpanded = IsExpanded;
		GameObject gameObject = ((Component)isExpanded).gameObject;
		transform.localPosition = (Vector3)gameObject;
		bool flag2 = AreAllClosed();
		TweenHeight largestTweenHeight = _largestTweenHeight;
		int num2 = ((!flag2) ? largestTweenHeight.from : largestTweenHeight.to);
		float num3 = num - (float)num2;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		float num5 = num4 + 0f;
		bool isExpanded2 = IsExpanded;
		object obj = (isExpanded2 ? 1 : 0) + 220;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v16+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		float num6 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		float num7 = num6 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+C]");
		object obj2 = -0;
		float num8 = (float)obj2 + _scrollPanelStartY;
		if (num5 < num8)
		{
			TheElementIsOnTop(num5, num8);
		}
		if (hasAnotherElementOpenOnBottom())
		{
			TweenHeight largestTweenHeight2 = _largestTweenHeight;
			TweenHeight largestTweenHeight3 = _largestTweenHeight;
			object obj3 = largestTweenHeight2.to - largestTweenHeight3.from;
			float num9 = num7 + (float)obj3;
			if (num9 > _scrollPanelStartY)
			{
				((LoadLevelCtrl)this).SetCurrentProgress(num7, _scrollPanelStartY);
				goto IL_02ca;
			}
		}
		if (num7 > _scrollPanelStartY)
		{
			((LoadLevelCtrl)this).SetCurrentProgress(num7, _scrollPanelStartY);
		}
		goto IL_02ca;
		IL_02ca:
		if (!AreAllClosed())
		{
			bool flag3 = hasAnotherElementOpenOnTop();
			_ = _index;
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public TableElementAlwaysVisible()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 28;
		obj = 0;
	}
}
