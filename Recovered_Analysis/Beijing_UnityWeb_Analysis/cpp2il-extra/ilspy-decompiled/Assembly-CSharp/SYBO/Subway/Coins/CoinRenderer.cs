using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class CoinRenderer : MonoBehaviour
{
	private Renderer _renderer;

	private Glow _glow;

	private PickupRotate _pickupRotate;

	private Transform _transform;

	private bool _actualRendering;

	private bool _renderersEnabled;

	private void Awake()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj = this + 24;
		obj = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Coin> list = default;
		list._002Ector(400);
		object obj2 = this + 28;
		obj2 = list;
		((Validator<>)(object)this)._002Ector();
	}

	public void UpdateCoinRenderer(float time, float characterZ, bool lowPerformanceLevel)
	{
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got I4
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_0532: Expected Obj, but got I4
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_054f: Expected Obj, but got I4
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_056c: Expected Obj, but got I4
		//IL_0580: Expected I, but got Obj
		//IL_0596: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0654: Expected I, but got Obj
		//IL_066a: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_03b8: Expected VT, but got I
		//IL_0712: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I4
		//IL_07cb: Expected Obj, but got I
		//IL_07f5: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got F4
		//IL_0435: Expected Obj, but got F4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 152;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 136;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 120;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 104;
		obj5 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v165 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj7 = this + 104;
			UIPanel component = GetComponent<UIPanel>();
			obj7 = component;
		}
		object obj8 = obj2 + 56;
		object obj9 = obj2 + 40;
		object obj10 = obj2 + 24;
		object obj11 = obj2 + 16;
		((UIScrollView)this).UpdateScrollbars();
		Transform transform = (Transform)(obj2 + 176);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (UnityEngine.Transform)+10]");
		_ = 0;
		object obj12 = obj2 + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj13 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		if (obj12 == obj13)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (UnityEngine.Transform)+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v40+4]");
		if (num3 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
		Vector2 clipSoftness = ((UIPanel)0).clipSoftness;
		obj3 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		obj12 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v40+8]");
		float num4 = 0f * 0.5f;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v39+C]");
		float num5 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		float num6 = (float)obj8 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		float num7 = (float)obj9 - num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v30+4]");
		float num8 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		float num9 = 0f - num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v80+D8]");
		bool flag = (nint)0 == 3;
		bool flag2 = !flag;
		float b = num8;
		float a = num6;
		float a2 = num9;
		float b2 = num7;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v143+EC]");
			transform = (Transform)0;
			float num10 = num6 - (float)transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v148+EC]");
			obj12 = 0;
			float num11 = num7 + (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v153+EC]");
			obj13 = 0;
			float num12 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v39+4]");
			float num13 = num12 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v158+EC]");
			obj8 = 0;
			float num14 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26+4]");
			float num15 = num14 + 0f;
			b = num13;
			a = num10;
			a2 = num15;
			b2 = num11;
		}
		nint num16 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v85 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num17 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v134 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num18 = Mathf.LerpUnclamped(a, b2, time);
		float num19 = Mathf.LerpUnclamped(a2, b, characterZ);
		if (!lowPerformanceLevel)
		{
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+64]");
			transform2.localPosition = (Vector3)0;
			obj5 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			if (((UIScrollView)this).canMoveVertically)
			{
				transform = (Transform)obj3;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				float num20 = (float)transform - num18;
				float num21 = (float)obj5 + num20;
				obj5 = num21;
			}
			if (((UIScrollView)this).shouldMoveHorizontally)
			{
				object obj20 = obj5 + 4;
				transform = (Transform)obj3;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (UnityEngine.Transform)+4]");
				float num22 = 0f - num19;
				float num23 = (float)obj20 + num22;
				obj20 = num23;
			}
			transform = (Transform)obj5;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		if (((UIScrollView)this).canMoveVertically)
		{
			obj3 = num18;
		}
		if (((UIScrollView)this).shouldMoveHorizontally)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
		object obj21 = (nint)0 + (nint)220;
		obj12 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S1_v83+8]");
		_ = 0;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v40+8]");
		_ = 0;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		_ = 0;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
		_ = 0;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		_ = 0;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
		_ = 0;
		obj2 = 0;
		object obj22 = obj13 - obj8;
		obj2 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28+4]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v30+4]");
		object obj23 = num24 - 0;
		obj11 = obj2;
		transform = (Transform)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+68]");
		((UIPanel)0).clipTexture = (Texture2D)(object)transform;
		if (lowPerformanceLevel)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinRenderer)+B8]");
			bool flag3 = (nint)0 == -10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public void ToggleRenderers(bool enabled)
	{
		((CoinManager)this).Update();
		((CoinManager)this).ResetCoins();
	}

	public CoinRenderer()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		object obj = this + 20;
		PickupRotate component = GetComponent<PickupRotate>();
		obj = component;
		object obj2 = this + 24;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
	}
}
