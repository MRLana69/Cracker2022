using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway;
using UI.Screens.UpgradeScreenInternal;
using UnityEngine;

public class SlideinPowerupButton : UIButtonSender
{
	public enum SlideInButtonType
	{
		scorebooster,
		headstart
	}

	private sealed class _003CAnimateSpriteColor_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color32 startValue;

		public Color32 endValue;

		private float _003CanimationLerpFactor_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected VT, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0046: Expected Obj, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Expected Obj, but got Unknown
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected Obj, but got Unknown
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Expected Obj, but got Unknown
				//IL_0151: Expected Obj, but got VT
				//IL_0166: Expected F4, but got Obj
				//IL_0161: Expected native int or pointer, but got VT
				//IL_0182: Expected Obj, but got VT
				//IL_0197: Expected F4, but got Obj
				//IL_0192: Expected native int or pointer, but got VT
				//IL_01b1: Expected I4, but got Obj
				//IL_01cb: Expected F4, but got Obj
				//IL_01c6: Expected native int or pointer, but got VT
				//IL_01e0: Expected F4, but got I
				//IL_01db: Expected native int or pointer, but got VT
				//IL_01f7: Expected I4, but got VT
				//IL_01f7: Expected Ref, but got VT
				//IL_0209: Expected native int or pointer, but got VT
				//IL_021b: Expected native int or pointer, but got VT
				//IL_022f: Expected I4, but got VT
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_023a: Expected Obj, but got Unknown
				//IL_0243: Expected Obj, but got I4
				//IL_0257: Expected Obj, but got I4
				Matrix4x4 matrix4x2 = default;
				Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 80);
				int num = matrix4x2 - -64;
				object obj = matrix4x2 + 56;
				object obj2 = matrix4x2 + 40;
				object obj3 = matrix4x2 + 60;
				object obj4 = matrix4x2 + 32;
				object obj5 = matrix4x2 + 16;
				object obj6 = matrix4x2 + 36;
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
					_003CanimationLerpFactor_003E5__2 = 0f;
				}
				if (_003CanimationLerpFactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime * speedFactor;
					float num3 = _003CanimationLerpFactor_003E5__2 + num2;
					_003CanimationLerpFactor_003E5__2 = num3;
					obj = startValue;
					obj3 = obj;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
					Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
					obj4 = endValue;
					obj6 = obj4;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, _003CanimationLerpFactor_003E5__2);
					((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
					((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
					spriteToAnimate.rawPivot = (UIWidget.Pivot)matrix4x;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
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

	private SlideinPowerupHelper _helper;

	private int _powerupNumber;

	private GameObject _headstartModel;

	private UISprite _background;

	private int _counter;

	private const float FADE_OUT_ANIMATION_SPEED_FACTOR = 2f;

	private SlideInButtonType buttonType;

	public unsafe void InitSlideinButton(SlideinPowerupHelper helper, int powerupNumber)
	{
		//IL_006e: Expected F4, but got Obj
		//IL_0069: Expected native int or pointer, but got VT
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_001b: Expected F4, but got Obj
		//IL_0016: Expected native int or pointer, but got VT
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		Color color = default;
		((Color*)(nint)color)->b = (float)ex;
		object obj = color + 16;
		obj = powerupNumber;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		Color color2 = default;
		((Color*)(nint)color2)->b = (float)ex2;
		object obj2 = color2 + 16;
		obj2 = powerupNumber;
		((UIExclusiveContainerHelper)(object)this).SetupExclusiveMessage((string)(object)helper, color, color2);
	}

	private void OnDisable()
	{
		CancelInvoke();
	}

	protected override void Send(bool isPressed)
	{
		//IL_04a2: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_015e: Expected I, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I4
		//IL_024b: Expected I4, but got Obj
		//IL_01ec: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I4
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_05bb: Expected I4, but got Obj
		//IL_05bb: Expected Obj, but got I4
		//IL_05cb: Expected I4, but got Obj
		//IL_05cb: Expected Obj, but got I4
		//IL_029a: Expected I, but got Obj
		//IL_02b0: Expected Obj, but got I
		//IL_0413: Expected I, but got Obj
		//IL_0429: Expected Obj, but got I
		//IL_03b7: Expected I, but got Obj
		//IL_0539: Expected Obj, but got I4
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_02db: Expected I, but got Obj
		//IL_0454: Expected I, but got Obj
		//IL_059b: Expected I4, but got Obj
		//IL_059b: Expected Obj, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		object obj = (isPressed ? 1 : 0) - 1;
		object obj8;
		if (!isPressed)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3 || (nint)obj == 4 || ((nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9))
				{
					return;
				}
				if (((UpgradeHelper)_powerupNumber).animState == UpgradeHelper.AnimState.Closed)
				{
					nint num = (nint)typeof(Upgrades);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v57 (Il2CppClass<Info.Upgrades>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(Upgrades);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v73 (Il2CppClass<Info.Upgrades>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Upgrade upgrade = Upgrades.upgrades.get_Item(isPressed ? UpgradeType.hoverboard : UpgradeType._notset);
					CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)isPressed);
					object obj3 = array + 1;
					object obj7;
					if (upgrade.pricesRaw != null)
					{
						object obj4 = upgrade.pricesRaw + 16;
						object obj5 = obj3 << 2;
						object obj6 = obj4 + obj5;
						obj7 = obj6;
					}
					else
					{
						obj7 = -1;
					}
					obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] array2 = default;
					string text = string.Concat(array2);
					((UILabel)trigger).fontSize = (int)text;
					return;
				}
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v31 (Il2CppClass<NGUITools>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v52 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.DestroyChildren((Transform)(object)_helper);
				((UILabel)trigger).fontSize = (int)"";
				((UILabel)_counter).fontSize = (int)"Max";
				BoxCollider component = ((GameObject)(object)_background).GetComponent<BoxCollider>();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(component);
				return;
			}
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_headstartModel).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v13 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("UPGRADES_HELPER_YOU_HAVE");
		int tier = InventorySave.GetTier(isPressed ? UpgradeType.hoverboard : UpgradeType._notset);
		obj8 = tier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text2 = string.Format(format, args);
		((UILabel)(object)_headstartModel).fontSize = (int)text2;
	}

	protected override void Send()
	{
		this._002Ector();
	}

	public void OnPressButton()
	{
		//IL_0055: Expected VT, but got Obj
		//IL_001d: Expected I4, but got Obj
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_ = 1;
		if (_powerupNumber == -1)
		{
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string msg = string.ConcatArray((string[])(object)values, (int)" was used without being initialized");
			SDebug.LogFormat(msg, (object[])(object)this);
		}
		else
		{
			_helper.HidePowerup1((byte)_powerupNumber != 0);
		}
	}

	public void OnReleaseButton()
	{
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C4]");
		if ((nint)0 != 0)
		{
			return;
		}
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType == SlideInButtonType.headstart)
			{
				SetPowerup1Color(animateIn: true);
			}
		}
		else
		{
			((SlideinPowerupHelper)(object)this).ScreenDidChange((string)1);
		}
	}

	private unsafe void SetPowerup2Color(bool animateIn)
	{
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected VT, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_001d: Expected I4, but got Obj
		//IL_0151: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I4
		//IL_018a: Expected F4, but got Obj
		//IL_0185: Expected native int or pointer, but got VT
		//IL_01a4: Expected F4, but got Obj
		//IL_019f: Expected native int or pointer, but got VT
		//IL_01b9: Expected F4, but got I
		//IL_01b4: Expected native int or pointer, but got VT
		//IL_01d9: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0212: Expected F4, but got Obj
		//IL_020d: Expected native int or pointer, but got VT
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_00b1: Expected F4, but got Obj
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00cb: Expected F4, but got Obj
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_00e0: Expected F4, but got I
		//IL_00db: Expected native int or pointer, but got VT
		//IL_030b: Expected F4, but got Obj
		//IL_0306: Expected native int or pointer, but got VT
		//IL_0320: Expected F4, but got I
		//IL_031b: Expected native int or pointer, but got VT
		//IL_032d: Expected I4, but got VT
		//IL_0100: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0139: Expected F4, but got Obj
		//IL_0134: Expected native int or pointer, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj - -64);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 56;
		object obj5 = obj + 16;
		object obj6 = obj + 52;
		object obj7 = obj + 48;
		object obj8 = obj + 44;
		if (_powerupNumber == -1)
		{
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string msg = string.ConcatArray((string[])(object)values, (int)" was used without being initialized");
			SDebug.LogFormat(msg, (object[])(object)this);
			return;
		}
		Renderer component = _headstartModel.GetComponent<Renderer>();
		Material sharedMaterial = component.sharedMaterial;
		UIWidget background;
		if (animateIn)
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = 100;
			_ = 100;
			_ = 100;
			_ = 0;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			sharedMaterial.SetVector("_Color", (Vector4)matrix4x);
			obj5 = 0;
			obj5 = 0;
			obj5 = 0;
			_ = 0;
			_ = 0;
			_ = -36;
			obj6 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			background = _background;
		}
		else
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = -1;
			_ = -1;
			_ = -1;
			_ = 0;
			obj7 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			sharedMaterial.SetVector("_Color", (Vector4)matrix4x);
			obj5 = 0;
			obj5 = 0;
			obj5 = 0;
			_ = 0;
			_ = 0;
			_ = -128;
			obj8 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			background = _background;
		}
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		background.rawPivot = (UIWidget.Pivot)matrix4x;
		if ((_counter & 1) != 0)
		{
			_helper.HidePowerup1((byte)_powerupNumber != 0);
		}
		int counter = _counter + 1;
		_counter = counter;
	}

	private unsafe void SetPowerup1Color(bool animateIn)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected VT, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected VT, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got VT
		//IL_0205: Expected Obj, but got VT
		//IL_0222: Expected I4, but got Obj
		//IL_021d: Expected native int or pointer, but got VT
		//IL_022f: Expected F4, but got Obj
		//IL_022a: Expected native int or pointer, but got VT
		//IL_00a8: Expected I, but got Obj
		//IL_0196: Expected I4, but got VT
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01a3: Expected Obj, but got I4
		//IL_01b0: Expected F4, but got Obj
		//IL_01ab: Expected native int or pointer, but got VT
		//IL_01ca: Expected F4, but got Obj
		//IL_01c5: Expected native int or pointer, but got VT
		//IL_01df: Expected F4, but got I
		//IL_01da: Expected native int or pointer, but got VT
		//IL_01ee: Expected I4, but got VT
		//IL_0037: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 40);
		Color32 color = (Color32)(obj + 32);
		object obj2 = obj + 8;
		object obj3 = obj + 28;
		object obj4 = obj + 24;
		object obj5 = obj + 4;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<GlobalColors>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		if (animateIn)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v57 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color32*)(nint)color)->rgba = (int)GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
			obj3 = color.rgba;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_background.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		if (!flag)
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
		obj = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
		obj4 = obj2;
		obj5 = obj;
		((Color32*)(nint)color)->rgba = (int)obj4;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		IEnumerator routine = ((SlideinPowerupHelper)null).AnimateSpriteColor(_background, color, (Color32)matrix4x, 2f);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private IEnumerator AnimateSpriteColor(UISprite spriteToAnimate, Color32 startValue, Color32 endValue, float speedFactor)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = spriteToAnimate;
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = startValue.rgba;
		object obj4 = obj3 + 8;
		obj4 = obj2;
		obj3 = endValue.rgba;
		obj4 = obj3;
		return enumerator;
	}

	public void ResetPowerupButtonColorToInitial()
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C4]");
		if ((nint)0 != 0)
		{
			return;
		}
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType == SlideInButtonType.headstart)
			{
				SetPowerup1Color(animateIn: false);
			}
		}
		else
		{
			((SlideinPowerupHelper)(object)this).ScreenDidChange((string)null);
		}
	}

	public unsafe SlideinPowerupButton()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected VT, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got VT
		//IL_01bb: Expected F4, but got Obj
		//IL_01b6: Expected native int or pointer, but got VT
		//IL_01d5: Expected F4, but got Obj
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_01ea: Expected F4, but got I
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_01f9: Expected I4, but got VT
		//IL_0078: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0207: Expected Obj, but got VT
		//IL_021c: Expected F4, but got Obj
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0236: Expected F4, but got Obj
		//IL_0231: Expected native int or pointer, but got VT
		//IL_024b: Expected F4, but got I
		//IL_0246: Expected native int or pointer, but got VT
		//IL_025a: Expected I4, but got VT
		//IL_0106: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 24;
		object obj4 = obj + 20;
		if (buttonType != SlideInButtonType.scorebooster)
		{
			if (buttonType != SlideInButtonType.headstart)
			{
				return;
			}
			nint num = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v27 (Il2CppClass<GlobalColors>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v38 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_background.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9 (Il2CppClass<GlobalColors>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v20 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;
		obj3 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_background.rawPivot = (UIWidget.Pivot)matrix4x;
	}
}
