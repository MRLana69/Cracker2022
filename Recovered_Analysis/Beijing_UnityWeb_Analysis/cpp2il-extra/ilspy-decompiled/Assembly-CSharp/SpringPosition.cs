using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class SpringPosition : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPosition current;

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public bool updateScrollView;

	public OnFinished onFinished;

	private GameObject eventReceiver;

	public string callWhenFinished;

	private Transform mTrans;

	private float mThreshold;

	private UIScrollView mSv;

	private void Start()
	{
		//IL_000b: Expected VT, but got F4
		target = (Vector3)1f;
		_ = 1f;
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_005e: Expected I, but got Obj
		object obj = this + 44;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		if (~(updateScrollView ? 1u : 0u) != 0)
		{
			return;
		}
		string go = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 52;
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>((GameObject)(object)go);
		obj3 = uIScrollView;
	}

	private void Update()
	{
		mThreshold = 0f;
	}

	private unsafe void NotifyListeners()
	{
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0546: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected VT, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected VT, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0851: Expected VT, but got Obj
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		//IL_0886: Expected F4, but got Obj
		//IL_0881: Expected native int or pointer, but got VT
		//IL_0898: Expected F4, but got I
		//IL_0893: Expected native int or pointer, but got VT
		//IL_08a5: Expected F4, but got Obj
		//IL_08a0: Expected native int or pointer, but got VT
		//IL_08b7: Expected F4, but got I
		//IL_08b2: Expected native int or pointer, but got VT
		//IL_08df: Expected F4, but got Obj
		//IL_08da: Expected native int or pointer, but got VT
		//IL_08f4: Expected F4, but got I
		//IL_08ef: Expected native int or pointer, but got VT
		//IL_08fd: Expected Obj, but got VT
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03cf: Expected VT, but got Obj
		//IL_03dd: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0312: Expected VT, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_0574: Expected VT, but got Obj
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05a9: Expected F4, but got Obj
		//IL_05a4: Expected native int or pointer, but got VT
		//IL_05bb: Expected F4, but got I
		//IL_05b6: Expected native int or pointer, but got VT
		//IL_05c8: Expected F4, but got Obj
		//IL_05c3: Expected native int or pointer, but got VT
		//IL_05da: Expected F4, but got I
		//IL_05d5: Expected native int or pointer, but got VT
		//IL_0602: Expected F4, but got Obj
		//IL_05fd: Expected native int or pointer, but got VT
		//IL_0617: Expected F4, but got I
		//IL_0612: Expected native int or pointer, but got VT
		//IL_0620: Expected Obj, but got VT
		//IL_09f7: Expected F4, but got Obj
		//IL_09f2: Expected native int or pointer, but got VT
		//IL_0a0c: Expected F4, but got I
		//IL_0a07: Expected native int or pointer, but got VT
		//IL_0a19: Expected F4, but got Obj
		//IL_0a14: Expected native int or pointer, but got VT
		//IL_0a2b: Expected F4, but got I
		//IL_0a26: Expected native int or pointer, but got VT
		//IL_0a7b: Expected Obj, but got I
		//IL_0aa5: Expected Obj, but got I
		//IL_0abc: Invalid comparison between F4 and Obj
		//IL_0913: Expected F4, but got Obj
		//IL_090e: Expected native int or pointer, but got VT
		//IL_0925: Expected F4, but got I
		//IL_0920: Expected native int or pointer, but got VT
		//IL_0932: Expected F4, but got Obj
		//IL_092d: Expected native int or pointer, but got VT
		//IL_0944: Expected F4, but got I
		//IL_093f: Expected native int or pointer, but got VT
		//IL_0994: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01ba: Expected VT, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00fd: Expected VT, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_080f: Expected I, but got Obj
		//IL_0825: Expected Obj, but got I
		//IL_041e: Expected I, but got Obj
		//IL_0361: Expected I, but got Obj
		//IL_071a: Expected F4, but got Obj
		//IL_0715: Expected native int or pointer, but got VT
		//IL_072f: Expected F4, but got I
		//IL_072a: Expected native int or pointer, but got VT
		//IL_073c: Expected F4, but got Obj
		//IL_0737: Expected native int or pointer, but got VT
		//IL_074e: Expected F4, but got I
		//IL_0749: Expected native int or pointer, but got VT
		//IL_079e: Expected Obj, but got I
		//IL_07c8: Expected Obj, but got I
		//IL_07df: Invalid comparison between F4 and Obj
		//IL_0636: Expected F4, but got Obj
		//IL_0631: Expected native int or pointer, but got VT
		//IL_0648: Expected F4, but got I
		//IL_0643: Expected native int or pointer, but got VT
		//IL_0655: Expected F4, but got Obj
		//IL_0650: Expected native int or pointer, but got VT
		//IL_0667: Expected F4, but got I
		//IL_0662: Expected native int or pointer, but got VT
		//IL_06b7: Expected Obj, but got I
		//IL_06e1: Expected Obj, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0475: Expected F4, but got Obj
		//IL_0470: Expected native int or pointer, but got VT
		//IL_048a: Expected F4, but got I
		//IL_0485: Expected native int or pointer, but got VT
		//IL_0497: Expected native int or pointer, but got VT
		//IL_04a9: Expected native int or pointer, but got VT
		//IL_04b7: Expected Obj, but got VT
		//IL_0209: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		//IL_04e0: Expected I, but got Obj
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0260: Expected F4, but got Obj
		//IL_025b: Expected native int or pointer, but got VT
		//IL_0275: Expected F4, but got I
		//IL_0270: Expected native int or pointer, but got VT
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0294: Expected native int or pointer, but got VT
		//IL_02a2: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		float deltaTime = ((~(ignoreTimeScale ? 1u : 0u) != 0) ? Time.unscaledTime : Time.fixedDeltaTime);
		Quaternion quaternion = (Quaternion)(obj2 + 96);
		Quaternion quaternion2 = (Quaternion)(obj2 + 84);
		Transform transform = (Transform)(obj2 + 60);
		Transform transform2 = (Transform)(obj2 + 48);
		object obj3 = obj2 + 36;
		object obj4 = obj2 + 24;
		Transform transform3 = (Transform)(obj2 + 12);
		bool flag = mThreshold == 0f;
		if (~(worldSpace ? 1u : 0u) == 0)
		{
			if (flag)
			{
				object obj5 = this + 12;
				transform = (Transform)obj5;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v147+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				transform2.position = (Vector3)mTrans;
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v87 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v99 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion2)->x = (float)transform;
				((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Quaternion*)(nint)quaternion)->x = (float)transform2;
				((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion3 = Quaternion.FromToRotation((Vector3)quaternion2, (Vector3)quaternion);
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
				_ = 0;
				object obj7 = obj * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				object obj8 = num3 * 0;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				object obj10 = num4 * 0;
				object obj11 = obj9 + obj10;
				float num5 = (float)obj11 * 0.001f;
				mThreshold = num5;
			}
			transform.position = (Vector3)mTrans;
			object obj12 = this + 12;
			transform2 = (Transform)obj12;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v84+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			((Quaternion*)(nint)quaternion2)->x = (float)transform;
			((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Quaternion*)(nint)quaternion)->x = (float)transform2;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Quaternion quaternion4 = NGUIMath.SpringLerp(quaternion2, quaternion, strength, deltaTime);
			((Quaternion*)(nint)quaternion)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Vector3 localPosition = ((Transform)quaternion).localPosition;
			object obj13 = this + 12;
			obj4 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S2_v103+8]");
			_ = 0;
			transform3.position = (Vector3)mTrans;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v118 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S1_v142 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion2)->x = (float)obj4;
			Quaternion quaternion5 = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			((Quaternion*)(nint)quaternion5)->z = 0f;
			((Quaternion*)(nint)quaternion)->x = (float)transform3;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			Quaternion quaternion6 = Quaternion.FromToRotation((Vector3)quaternion2, (Vector3)quaternion);
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj15 = obj * obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			object obj16 = num8 * 0;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			object obj18 = num9 * 0;
			object obj19 = obj17 + obj18;
			float num10 = mThreshold;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
			{
				object obj20 = this + 12;
				((Quaternion*)(nint)quaternion2)->x = (float)obj20;
				Quaternion quaternion7 = quaternion2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S2_v133+8]");
				((Quaternion*)(nint)quaternion7)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = quaternion2.x;
				((Quaternion*)(nint)quaternion)->z = quaternion2.z;
				Vector3 localPosition2 = ((Transform)quaternion).localPosition;
				this._002Ector();
				tag = null;
			}
		}
		else
		{
			if (flag)
			{
				object obj21 = this + 12;
				transform = (Transform)obj21;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v74+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				transform2.localPosition = (Vector3)mTrans;
				nint num11 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num12 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v67 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion2)->x = (float)transform;
				((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Quaternion*)(nint)quaternion)->x = (float)transform2;
				((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion8 = Quaternion.FromToRotation((Vector3)quaternion2, (Vector3)quaternion);
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
				_ = 0;
				object obj23 = obj * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				object obj24 = num13 * 0;
				object obj25 = obj23 + obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				object obj26 = num14 * 0;
				object obj27 = obj25 + obj26;
				float num15 = (float)obj27 * 1E-05f;
				mThreshold = num15;
			}
			transform.localPosition = (Vector3)mTrans;
			object obj28 = this + 12;
			transform2 = (Transform)obj28;
			Transform transform7 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v10+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			((Quaternion*)(nint)quaternion2)->x = (float)transform;
			((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Quaternion*)(nint)quaternion)->x = (float)transform2;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Quaternion quaternion9 = NGUIMath.SpringLerp(quaternion2, quaternion, strength, deltaTime);
			((Quaternion*)(nint)quaternion)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Vector3 eulerAngles = ((Transform)quaternion).eulerAngles;
			object obj29 = this + 12;
			obj4 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S2_v29+8]");
			_ = 0;
			transform3.localPosition = (Vector3)mTrans;
			nint num16 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S1_v46 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num17 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v69 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion2)->x = (float)obj4;
			Quaternion quaternion10 = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
			((Quaternion*)(nint)quaternion10)->z = 0f;
			((Quaternion*)(nint)quaternion)->x = (float)transform3;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
			Quaternion quaternion11 = Quaternion.FromToRotation((Vector3)quaternion2, (Vector3)quaternion);
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj31 = obj * obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			object obj32 = num18 * 0;
			object obj33 = obj31 + obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			object obj34 = num19 * 0;
			object obj35 = obj33 + obj34;
			float num20 = mThreshold;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num20) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
			{
				object obj36 = this + 12;
				((Quaternion*)(nint)quaternion2)->x = (float)obj36;
				Quaternion quaternion12 = quaternion2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S2_v58+8]");
				((Quaternion*)(nint)quaternion12)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = quaternion2.x;
				((Quaternion*)(nint)quaternion)->z = quaternion2.z;
				Vector3 eulerAngles2 = ((Transform)quaternion).eulerAngles;
				this._002Ector();
				tag = null;
			}
		}
		nint num21 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSv).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got F4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		SpringPanel component = go.GetComponent<SpringPanel>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = component != null;
		bool flag2 = !flag;
		SpringPanel springPanel = component;
		if (!flag2)
		{
			SpringPanel springPanel2 = go.AddComponent<SpringPanel>();
			springPanel = springPanel2;
		}
		object obj2 = pos.x;
		_ = pos.z;
		object obj3 = springPanel + 12;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		springPanel.strength = strength;
		object obj4 = springPanel + 28;
		obj4 = 0;
		springPanel.tag = (string)1;
		return (SpringPosition)(object)springPanel;
	}

	public SpringPosition()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) != 0)
		{
			string text = callWhenFinished;
			if (callWhenFinished != null && text.m_stringLength != 0)
			{
				eventReceiver.BroadcastMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
			}
		}
		current = null;
	}
}
