using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Popups.ConsumablesPopupInternal;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace UI.Popups.BoardBundlePopupInternal;

[Serializable]
public class BoardBundleItem
{
	private sealed class _003CTeleboardEffect_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardBundleItem _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0255: Unknown result type (might be due to invalid IL or missing references)
				//IL_025a: Expected Obj, but got Unknown
				//IL_0263: Unknown result type (might be due to invalid IL or missing references)
				//IL_0268: Expected Obj, but got Unknown
				//IL_0226: Unknown result type (might be due to invalid IL or missing references)
				//IL_022b: Expected Obj, but got Unknown
				//IL_0247: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_0099: Expected Obj, but got I
				//IL_02c4: Expected Obj, but got I4
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Expected Obj, but got Unknown
				//IL_013a: Expected Obj, but got I4
				//IL_00c4: Expected I, but got Obj
				//IL_016a: Expected I, but got Obj
				//IL_0180: Expected Obj, but got I
				//IL_030c: Expected VT, but got Obj
				//IL_033a: Expected Obj, but got I4
				//IL_01ab: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 24);
				object obj2 = obj + 12;
				BoardBundleItem boardBundleItem = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						int layer = boardBundleItem._boardRoot.layer;
						nint num = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 one = Vector3.one;
						transform = (Transform)obj2;
						Transform transform2 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
						((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
						((Transform)layer).parent = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A9F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.4f;
						object obj4 = this + 12;
						object obj5 = default;
						obj4 = obj5;
						_003C_003E1__state = 2;
						return 1;
					}
					if (_003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					int layer2 = boardBundleItem._boardRoot.layer;
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v38 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					transform = (Transform)obj2;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 vector = (Vector3)transform / 11f;
					transform = (Transform)obj;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					((Transform)layer2).parent = transform;
				}
				else
				{
					_003C_003E1__state = -1;
				}
				float num5 = ScrollRect.RubberDelta(1.5f, 3f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = this + 12;
				object obj8 = default;
				obj7 = obj8;
				_003C_003E1__state = 1;
				return 1;
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

	private const float DEFAULT_SCALE_FACTOR = 11f;

	private const float TRAIL_PARTICLE_SYSTEM_START_ROTATION = 150f;

	private const float TRAIL_PARTICLE_SYSTEM_END_ROTATION = 210f;

	private const float TRAIL_PARTICLE_SYSTEM_RATE_OVER_TIME = 3f;

	private static readonly Vector3 MODEL_POSITION;

	private static readonly Vector3 MODEL_LOCAL_ROTATION;

	private static readonly Vector3 TRAIL_SCALE;

	private static readonly Quaternion TRAIL_ROTATION;

	private static readonly Vector3 TRAIL_PARTICLE_SYSTEM_POSITION;

	private Transform _boardAnchor;

	private Transform _boardBottomAnchor;

	private HorizontalLayout _boardLayouter;

	private BundleIcon _boardIcon;

	private UILabel _boardPriceLabel;

	private List<BundleIcon> _bundleIcons;

	private Boards.BoardId _boardId;

	private ATeleboardMenuEffect _teleboardMenuEffect;

	private GameObject _boardRoot;

	public void Init(Boards.BoardId boardId, string price)
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_02df: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_01c3: Expected I, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		if (this != null)
		{
			if ((nint)this != 1)
			{
				if ((nint)this != 2)
				{
					if ((nint)this == 3)
					{
						nint num = (nint)typeof(CloudSaveConfirmationPopupPayload);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v65 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(CloudSaveConfirmationPopupPayload);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v72 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AB9");
					}
				}
				else
				{
					nint num3 = (nint)typeof(CloudSaveConfirmationPopupPayload);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v51 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(CloudSaveConfirmationPopupPayload);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v58 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AB9");
				}
			}
			else
			{
				nint num5 = (nint)typeof(CloudSaveConfirmationPopupPayload);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v37 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(CloudSaveConfirmationPopupPayload);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v44 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AB9");
			}
		}
		else
		{
			nint num7 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v23 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(CloudSaveConfirmationPopupPayload);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v30 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AB9");
		}
		nint num9 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v8 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v18 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AAD");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AAD");
		object obj9 = default;
		object obj8 = obj9 + 12;
		obj8 = price;
	}

	public void GainFocus()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void Show()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		string tag = _boardAnchor.tag;
		((GameObject)(object)tag).tag = (string)1;
		string tag2 = _boardBottomAnchor.tag;
		((GameObject)(object)tag2).tag = (string)1;
	}

	public unsafe void LoseFocus()
	{
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected VT, but got Unknown
		//IL_0195: Expected F4, but got Obj
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01aa: Expected F4, but got I
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01c9: Expected F4, but got Obj
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_01de: Expected F4, but got I
		//IL_01d9: Expected native int or pointer, but got VT
		//IL_01eb: Expected Obj, but got VT
		//IL_01eb: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		int layer = _boardRoot.layer;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 forward = Vector3.forward;
		Vector3 vector = (Vector3)(obj3 + 24);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / 11f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Transform)layer).parent = (Transform)vector;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) != 0)
		{
			MonoBehaviour.print(_teleboardMenuEffect);
			string content = ((ListContentElement)this).content;
			Coroutine coroutine = _teleboardMenuEffect.StartCoroutine_Auto((IEnumerator)(object)content);
		}
	}

	public unsafe void SetupBoard(List<int> themes)
	{
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected I4, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I4
		//IL_01e0: Expected I4, but got Obj
		//IL_0128: Expected Obj, but got I4
		//IL_014a: Expected I4, but got Obj
		//IL_016f: Expected Obj, but got I4
		//IL_0191: Expected I4, but got Obj
		//IL_01a7: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v50 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 32);
		object obj3 = obj2 + 16;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		if (themes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardBundlePopupInternal.BoardBundleItem)+144]");
			if ((nint)0 != 1)
			{
				_ = 1;
				_ = 1;
				_ = 1;
			}
			object obj4 = (flag ? 1 : 0) + 188;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v24+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
			_ = 0;
			((UIWidget)this).rawPivot = pivot;
			object obj5 = (flag ? 1 : 0) + 124;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v34+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardBundlePopupInternal.BoardBundleItem)+144]");
			if ((nint)0 != 0)
			{
				_ = 0;
				_ = 1;
				_ = 1;
			}
			object obj6 = (flag ? 1 : 0) + 140;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v9+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16+8]");
			_ = 0;
			((UIWidget)this).rawPivot = pivot;
		}
	}

	private unsafe void SetupBoard(Transform modelPosition, Boards.BoardId boardId, List<int> themes)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0010: Expected Obj, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = boardId;
		object obj4 = obj2 + 16;
		obj4 = themes;
		if ((object)_boardBottomAnchor == null)
		{
			_boardBottomAnchor = (Transform)1;
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			if ((object)modelPosition != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Action action = default;
				((Delegate)action).method_ptr = method_ptr;
				((Delegate)action).method = (nint)__ldftn(SellConsumablesHelper._003C_003Ec__DisplayClass15_0._003CMakePurchase_003Eb__0);
				object obj5 = action + 16;
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Action action2 = default;
				((Delegate)action2).method_ptr = method_ptr2;
				((Delegate)action2).method = (nint)__ldftn(SellConsumablesHelper._003C_003Ec__DisplayClass15_0._003CMakePurchase_003Eb__1);
				object obj6 = action2 + 16;
				obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
				((PurchaseHandler)(object)instance).PurchaseSkipMission(0, action, action2);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr3 = 0;
				Action action3 = default;
				((Delegate)action3).method_ptr = method_ptr3;
				((Delegate)action3).method = (nint)__ldftn(SellConsumablesHelper._003C_003Ec__DisplayClass15_0._003CMakePurchase_003Eb__2);
				object obj7 = action3 + 16;
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr4 = 0;
				Action action4 = default;
				((Delegate)action4).method_ptr = method_ptr4;
				((Delegate)action4).method = (nint)__ldftn(SellConsumablesHelper._003C_003Ec__DisplayClass15_0._003CMakePurchase_003Eb__3);
				object obj8 = action4 + 16;
				obj8 = obj2;
				((PurchaseHandler)(object)instance).PurchaseSkipMission(1, action3, action4);
			}
		}
	}

	private IEnumerator TeleboardEffect()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
		IEnumerator result = default;
		return result;
	}

	private void SetupTrail(GameObject trail)
	{
		//IL_0016: Expected I4, but got Obj
		//IL_0016: Expected I4, but got Obj
		SetupThemeInfo((Boards.BoardId)_boardAnchor, (int)_boardId, (int)trail);
	}

	private void SetupTrailParticleSystem(ParticleSystem trailParticleSystem)
	{
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		int layer = ((GameObject)(object)trailParticleSystem).layer;
		nint num = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(BoardBundleItem);
		if (!flag)
		{
			nint num3 = (nint)typeof(BoardBundleItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v22 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(BoardBundleItem);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(BoardBundleItem);
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ L0_v2 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v5+8]");
		_ = 0;
		Transform transform = (Transform)(obj3 + 32);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)layer).parent = transform;
		int layer2 = ((GameObject)(object)trailParticleSystem).layer;
		nint num4 = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v16 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj5 = (nint)0 + (nint)36;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v18+8]");
		_ = 0;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
	}

	public void SetupThemeInfo(int theme, int powerIndex)
	{
		//IL_0028: Expected Obj, but got I4
		_boardId = (Boards.BoardId)theme;
		_boardPriceLabel.fontSize = powerIndex;
		((ListContentElement)(object)_boardIcon).content = (string)theme;
	}

	private unsafe void SetupThemeInfo(Boards.BoardId boardId, int theme, int powerIndex)
	{
		//IL_0903: Expected I, but got Obj
		//IL_0919: Expected Obj, but got I
		//IL_0d7f: Expected I, but got Obj
		//IL_0d95: Expected Obj, but got I
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected Obj, but got Unknown
		//IL_0980: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_09ac: Expected Obj, but got VT
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected Obj, but got Unknown
		//IL_0a04: Expected I, but got Obj
		//IL_0a1a: Expected Obj, but got I
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected VT, but got Unknown
		//IL_0a5b: Expected Obj, but got F4
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected Obj, but got Unknown
		//IL_0a8c: Expected VT, but got Obj
		//IL_0aba: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_0acd: Expected Obj, but got I4
		//IL_0acd: Expected Obj, but got I4
		//IL_0173: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_0adc: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_02a8: Expected I, but got Obj
		//IL_02be: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I4
		//IL_05e6: Expected I, but got Obj
		//IL_05fc: Expected Obj, but got I
		//IL_0b0b: Expected Obj, but got I
		//IL_0c58: Expected Obj, but got I
		//IL_02e9: Expected I, but got Obj
		//IL_0627: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I4
		//IL_034e: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I4
		//IL_068c: Expected I, but got Obj
		//IL_06a2: Expected Obj, but got I
		//IL_0b3e: Expected Obj, but got I
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0ca3: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_038f: Expected I, but got Obj
		//IL_0715: Expected Obj, but got I4
		//IL_072b: Expected VT, but got Obj
		//IL_06cd: Expected I, but got Obj
		//IL_04c4: Expected Obj, but got I4
		//IL_04da: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_074c: Expected VT, but got Obj
		//IL_0bac: Expected Obj, but got I
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected Obj, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected Obj, but got Unknown
		//IL_0be8: Expected I, but got Obj
		//IL_0bfe: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I4
		//IL_0414: Expected I, but got Obj
		//IL_042a: Expected Obj, but got I
		//IL_075f: Expected I, but got Obj
		//IL_0775: Expected Obj, but got I
		//IL_051b: Expected I, but got Obj
		//IL_0cef: Expected I4, but got Obj
		//IL_0cef: Expected Ref, but got VT
		//IL_0cfc: Expected Obj, but got F4
		//IL_0568: Expected I, but got Obj
		//IL_0455: Expected I, but got Obj
		//IL_07a0: Expected I, but got Obj
		//IL_05b1: Expected Obj, but got I4
		//IL_05bb: Expected I4, but got Obj
		//IL_0825: Expected I, but got Obj
		//IL_083b: Expected Obj, but got I
		//IL_0866: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v173 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)theme);
		nint num3 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v169 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 40;
		CoinMagnet instance = CoinMagnet.Instance;
		IEnumerator enumerator = ((AvatarAnimations)(object)instance).PlayAnimationsInOrder((AnimationClip[])(object)board.boardModelName, (byte)theme != 0);
		obj3 = enumerator;
		UnityEngine.Object.DestroyImmediate(_boardRoot, (byte)(int)board.name != 0);
		int layer = _boardRoot.layer;
		((Transform)layer).parentInternal = (Transform)boardId;
		nint num5 = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v30 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		nint num6 = (nint)typeof(BoardBundleItem);
		if (!flag)
		{
			nint num7 = (nint)typeof(BoardBundleItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v163 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num6 = (nint)typeof(BoardBundleItem);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(BoardBundleItem);
			}
		}
		object obj5 = default;
		Transform transform = (Transform)(obj5 + 36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ L2_v2 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		nint num8 = 0;
		transform = (Transform)MODEL_POSITION;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v17 (Il2CppStaticFields<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Transform transform3 = (Transform)(obj5 + 48);
		transform3 = transform;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 eulerAngles = transform3.eulerAngles;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v159 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj5 + 24);
		Vector3 forward = Vector3.forward;
		transform3 = (Transform)vector.x;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v47 (UnityEngine.Vector2)+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj7 = obj5 + 12;
		Vector3 vector2 = (Vector3)transform3 / 11f;
		transform3 = (Transform)obj7;
		Transform transform5 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v51+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		((Transform)layer).parent = transform3;
		nint num11 = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v42 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj8 = (nint)0 + (nint)12;
		obj5 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v44+8]");
		_ = 0;
		transform3 = (Transform)obj5;
		Transform transform6 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform3.right;
		if (powerIndex != 0)
		{
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)layer).GetComponentsInChildren<T>();
			if (((List<int>)powerIndex).Contains(1))
			{
				object obj9 = componentsInChildren.Length + 20;
				object obj10 = obj9;
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v116 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num13 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v152 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v127+18]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					object obj12 = componentsInChildren.Length + 20;
					object obj13 = obj12;
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num15 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v148 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v133+10]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						bool flag4 = ((SpriteAtlas)layer).CanBindTo(null);
						string tag = ((Component)flag4).tag;
						object obj15 = componentsInChildren.Length + 20;
						object obj16 = obj15;
						nint num16 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S2_v70 (Il2CppClass<NGUITools>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num17 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S2_v75 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S1_v146+10]");
						int num18 = NGUITools.CalculateNextDepth((GameObject)(object)tag, ignoreChildrenWithColliders: false);
					}
					bool flag5 = ((SpriteAtlas)layer).CanBindTo(null);
					string tag2 = ((Component)flag5).tag;
					object obj18 = componentsInChildren.Length + 20;
					object obj19 = obj18;
					nint num19 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S2_v51 (Il2CppClass<NGUITools>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num20 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S2_v63 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v134+18]");
					int num21 = NGUITools.CalculateNextDepth((GameObject)(object)tag2, ignoreChildrenWithColliders: false);
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S2_v57 (Il2CppMethodInfo)+18]");
					object obj21 = 0;
					object obj22 = obj21;
					object obj23 = obj22 & 0x1FFF;
					object obj24 = obj23 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v269 @ S3_v15 (should have been resolved before IL gen)");
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v143 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num24 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v151 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					ComputeShader computeShader = default;
					if (computeShader.FindKernel(null) != 0)
					{
						((BoardBundleItem)null).SetupTrailParticleSystem((ParticleSystem)num21);
						((BundleIcon)null).SetupDefaultTheme((Boards.BoardId)computeShader);
					}
				}
			}
			if (((List<int>)powerIndex).Contains(2))
			{
				object obj26 = componentsInChildren.Length + 24;
				object obj27 = obj26;
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num26 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v74+24]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					object obj29 = componentsInChildren.Length + 24;
					object obj30 = obj29;
					nint num27 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v83 (Il2CppClass<NGUITools>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num28 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v120 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj32 = this + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v80+24]");
					int num29 = NGUITools.CalculateNextDepth(null, ignoreChildrenWithColliders: false);
					ATeleboardMenuEffect component = ((GameObject)num29).GetComponent<ATeleboardMenuEffect>();
					obj32 = component;
					GameObject gameObject = _teleboardMenuEffect.gameObject;
					Transform parentInternal = ((Transform)layer).parentInternal;
					((Transform)(object)gameObject).Translate((Vector3)parentInternal, Space.Self);
					GameObject gameObject2 = _teleboardMenuEffect.gameObject;
					transform.localScale = (Vector3)gameObject2;
					nint num30 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v94 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						nint num31 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform3 = transform;
					((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
					((Vector2*)vector)->set_Item((int)transform3, 40f);
					transform3 = (Transform)vector.x;
					Transform transform7 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v47 (UnityEngine.Vector2)+8]");
					((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
					((Transform)(object)gameObject2).parent = transform3;
					GameObject gameObject3 = _teleboardMenuEffect.gameObject;
					Vector3 one = Vector3.one;
					transform3 = (Transform)obj7;
					Transform transform8 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v51+8]");
					((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles2 = transform3.eulerAngles;
					nint num32 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj34 = (nint)0 & (nint)0x200;
					if (obj34 != null)
					{
						nint num33 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) != 0)
					{
						int layer2 = _boardRoot.layer;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
						MonoBehaviour.print(_teleboardMenuEffect);
						string content = ((ListContentElement)this).content;
						Coroutine coroutine = _teleboardMenuEffect.StartCoroutine_Auto((IEnumerator)(object)content);
					}
				}
			}
		}
		((AssignTextureAndMaterial)boardId)._003CAwake_003Eb__3_0((Material)29);
	}

	public void Align()
	{
		string tag = _boardAnchor.tag;
		((GameObject)(object)tag).tag = null;
		string tag2 = _boardBottomAnchor.tag;
		((GameObject)(object)tag2).tag = null;
	}

	public BoardBundleItem()
	{
		((RewardForVideoButton)(object)_boardLayouter).Init((VideoButtonPayload)null);
	}

	static BoardBundleItem()
	{
		//IL_05c1: Expected I, but got Obj
		//IL_05d7: Expected Obj, but got I
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_064a: Expected I, but got Obj
		//IL_0660: Expected Obj, but got I
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_028a: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_040a: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_058a: Expected I, but got Obj
		//IL_05a0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v188 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSaveConfirmationPopupPayload cloudSaveConfirmationPopupPayload = default;
		object obj2 = cloudSaveConfirmationPopupPayload + 16;
		string text = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_DESCRIPTION_DISCONNECT");
		obj2 = text;
		object obj3 = cloudSaveConfirmationPopupPayload + 20;
		string text2 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_DISCONNECT");
		obj3 = text2;
		nint num3 = (nint)typeof(CloudSaveConfirmationPopupPayload._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(CloudSaveConfirmationPopupPayload._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v182 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj7 = cloudSaveConfirmationPopupPayload + 12;
		obj7 = obj6;
		object obj8 = cloudSaveConfirmationPopupPayload + 24;
		string text3 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_CANCEL");
		obj8 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj10 = default;
		object obj9 = obj10 + 16;
		obj9 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj11 = cloudSaveConfirmationPopupPayload + 8;
		obj11 = obj10;
		object obj12 = cloudSaveConfirmationPopupPayload + 28;
		obj12 = "ic_cloud";
		object obj13 = cloudSaveConfirmationPopupPayload + 32;
		obj13 = "ic_x_red";
		object obj14 = cloudSaveConfirmationPopupPayload + 36;
		obj14 = "Disconnect";
		CloudSaveConfirmationPopupPayload.DISCONNECT_PAYLOAD = cloudSaveConfirmationPopupPayload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj16 = default;
		object obj15 = obj16 + 16;
		string text4 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_DESCRIPTION_LOCAL");
		obj15 = text4;
		object obj17 = obj16 + 20;
		string text5 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_CANCEL");
		obj17 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj19 = default;
		object obj18 = obj19 + 16;
		obj18 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj20 = obj16 + 12;
		obj20 = obj19;
		object obj21 = obj16 + 24;
		string text6 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_UPLOAD");
		obj21 = text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj23 = default;
		object obj22 = obj23 + 16;
		obj22 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj24 = obj16 + 8;
		obj24 = obj23;
		object obj25 = obj16 + 28;
		obj25 = "ic_phone";
		object obj26 = obj16 + 32;
		obj26 = "ic_upload";
		object obj27 = obj16 + 36;
		obj27 = "KeepLocal";
		nint num9 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v95 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+5C]");
		object obj28 = (nint)0 + (nint)4;
		obj28 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj30 = default;
		object obj29 = obj30 + 16;
		string text7 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_DESCRIPTION_CLOUD");
		obj29 = text7;
		object obj31 = obj30 + 20;
		string text8 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_CANCEL");
		obj31 = text8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		object obj33 = default;
		object obj32 = obj33 + 16;
		obj32 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj34 = obj30 + 12;
		obj34 = obj33;
		object obj35 = obj30 + 24;
		string text9 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_DOWNLOAD");
		obj35 = text9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj37 = default;
		object obj36 = obj37 + 16;
		obj36 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj38 = obj30 + 8;
		obj38 = obj37;
		object obj39 = obj30 + 28;
		obj39 = "ic_cloud";
		object obj40 = obj30 + 32;
		obj40 = "ic_download";
		object obj41 = obj30 + 36;
		obj41 = "KeepCloud";
		nint num12 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v137 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+5C]");
		object obj42 = (nint)0 + (nint)8;
		obj42 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj44 = default;
		object obj43 = obj44 + 16;
		string text10 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_DESCRIPTION_LOAD");
		obj43 = text10;
		object obj45 = obj44 + 20;
		string text11 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_CANCEL");
		obj45 = text11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		object obj47 = default;
		object obj46 = obj47 + 16;
		obj46 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj48 = obj44 + 12;
		obj48 = obj47;
		object obj49 = obj44 + 24;
		string text12 = Strings.GetDefault("CLOUDSAVE_CONFIRMATION_BUTTON_LOAD");
		obj49 = text12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		object obj51 = default;
		object obj50 = obj51 + 16;
		obj50 = CloudSaveConfirmationPopupPayload._003C_003Ec._003C_003E9;
		object obj52 = obj44 + 8;
		obj52 = obj51;
		object obj53 = obj44 + 28;
		obj53 = "ic_cloud";
		object obj54 = obj44 + 32;
		obj54 = "ic_download";
		object obj55 = obj44 + 36;
		obj55 = "LoadProgress";
		nint num15 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v179 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+5C]");
		object obj56 = (nint)0 + (nint)12;
		obj56 = obj44;
	}
}
