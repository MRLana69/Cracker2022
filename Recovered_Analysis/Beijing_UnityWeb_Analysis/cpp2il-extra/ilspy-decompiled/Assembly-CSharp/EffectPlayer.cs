using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class EffectPlayer : MonoBehaviour
{
	private List<GameObject> _effectList;

	private float _delay;

	private float _duration;

	private float _maxDuration;

	private float _minimumRotation;

	private float _maximumRotation;

	private bool _doLoop;

	private int _loopFrame;

	private bool _doRandomizeStartingIndex;

	private float _currentDelay;

	private int _currentIndex;

	private float _currentWait;

	private int _startingIndex;

	private float _selectedDuration;

	public unsafe int LoopFrame
	{
		set
		{
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Expected Obj, but got Unknown
			//IL_04a0: Expected Obj, but got I4
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Expected Obj, but got Unknown
			//IL_04bd: Expected Obj, but got I4
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected Obj, but got Unknown
			//IL_04da: Expected Obj, but got I4
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ee: Expected Obj, but got Unknown
			//IL_04f7: Expected Obj, but got I4
			//IL_050b: Expected I, but got Obj
			//IL_0521: Expected Obj, but got I
			//IL_070c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Expected Obj, but got Unknown
			//IL_071b: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I
			//IL_0105: Expected VT, but got I
			//IL_0013: Expected I, but got Obj
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected Obj, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_016d: Expected Obj, but got F4
			//IL_017e: Expected VT, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0191: Expected I, but got Obj
			//IL_01a7: Expected Obj, but got I
			//IL_0555: Unknown result type (might be due to invalid IL or missing references)
			//IL_055a: Expected VT, but got Unknown
			//IL_0567: Expected F4, but got Obj
			//IL_0562: Expected native int or pointer, but got VT
			//IL_057c: Expected F4, but got I
			//IL_0577: Expected native int or pointer, but got VT
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Expected Obj, but got Unknown
			//IL_05b1: Expected VT, but got Obj
			//IL_05e1: Expected Obj, but got F4
			//IL_05f3: Expected I, but got F4
			//IL_0602: Expected F4, but got I4
			//IL_0602: Expected VT, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_0231: Invalid comparison between F4 and I4
			//IL_0245: Invalid comparison between F4 and I4
			//IL_01d2: Expected I, but got Obj
			//IL_0471: Expected Obj, but got F4
			//IL_0483: Expected Obj, but got I4
			//IL_03a2: Expected Obj, but got F4
			//IL_03e6: Expected I, but got Obj
			//IL_03fc: Expected Obj, but got I
			//IL_0357: Expected Obj, but got F4
			//IL_0369: Expected Obj, but got I4
			//IL_0694: Expected F4, but got Obj
			//IL_068f: Expected native int or pointer, but got VT
			//IL_06a9: Expected F4, but got I
			//IL_06a4: Expected native int or pointer, but got VT
			//IL_06d0: Expected VT, but got Obj
			//IL_0288: Expected Obj, but got F4
			//IL_02cc: Expected I, but got Obj
			//IL_02e2: Expected Obj, but got I
			//IL_0427: Expected I, but got Obj
			//IL_0618: Expected F4, but got Obj
			//IL_0613: Expected native int or pointer, but got VT
			//IL_062d: Expected F4, but got I
			//IL_0628: Expected native int or pointer, but got VT
			//IL_0654: Expected VT, but got Obj
			//IL_030d: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 84;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 72;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 60;
			obj4 = 0;
			_ = 0;
			object obj5 = obj2 + 48;
			obj5 = 0;
			_ = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform = (Transform)(obj2 + 108);
			if ((UnityEngine.Object)value != null)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v92 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v97 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one = Vector3.one;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+F0]");
				object obj8 = 0;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v115+C8]");
				transform2.position = (Vector3)0;
			}
			obj5 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
			object obj9 = obj2 + 36;
			obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
			Transform transform3 = (Transform)(obj2 + 24);
			GameObject gameObject = ((Component)_currentDelay).gameObject;
			transform3.position = (Vector3)gameObject;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v40 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 96);
			((Vector3*)(nint)vector)->x = (float)obj9;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v35+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			object obj11 = obj2 + 12;
			Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)transform);
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v50+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
			transform = (Transform)vector.x;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
			Vector3 vector3 = (Vector3)transform / _loopFrame;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			bool flag = _delay != 0f;
			if (_minimumRotation != 0f)
			{
				if (!flag)
				{
					GameObject gameObject2 = ((Component)_maxDuration).gameObject;
					obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					transform3 = (Transform)obj3;
					Transform transform4 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					nint num7 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v98 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num8 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S1_v110 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj9;
					Vector3 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v35+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					transform = transform3;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					Vector3 vector5 = vector - (Vector3)transform;
					transform = (Transform)obj11;
					Transform transform5 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v50+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					Vector3 localPosition = transform.localPosition;
				}
				string text = ((Component)_maxDuration).tag;
				((GameObject)(object)text).tag = (string)1;
				return;
			}
			if (!flag)
			{
				GameObject gameObject3 = ((Component)_duration).gameObject;
				obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				transform3 = (Transform)obj3;
				Transform transform6 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v73 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S1_v85 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj9;
				Vector3 vector6 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v35+8]");
				((Vector3*)(nint)vector6)->z = 0f;
				transform = transform3;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
				Vector3 vector7 = vector - (Vector3)transform;
				transform = (Transform)obj11;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v50+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition2 = transform.localPosition;
			}
			string text2 = ((Component)_duration).tag;
			((GameObject)(object)text2).tag = (string)1;
		}
	}

	public float Duration
	{
		get
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected Obj, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_00f2: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_0112: Expected F4, but got Obj
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I
			//IL_00d1: Expected F4, but got Obj
			nint num = default;
			if (num >= 37)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @467B");
				return 0f;
			}
			object obj = this + 5832;
			object obj2 = obj & 0x40;
			if (obj2 != null)
			{
				object obj3 = this + 5476;
				object obj4 = obj3 + num;
				if (obj4 != null)
				{
					object obj5 = this + 5328;
					object obj6 = num << 2;
					object obj7 = obj5 + obj6;
					return (float)obj7;
				}
			}
			object obj8 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12+3C4]");
			object obj9 = (nint)0 + (nint)1032;
			object obj10 = num << 2;
			object obj11 = obj9 + obj10;
			return (float)obj11;
		}
	}

	private void Awake()
	{
		((ColorTeleboardEffect)this).StartTeleBoardEffect();
	}

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 52)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void Reset()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got F4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		if (~(_doRandomizeStartingIndex ? 1u : 0u) == 0)
		{
			List<GameObject> effectList = _effectList;
			int startingIndex = UnityEngine.Random.RandomRangeInt(0, effectList._size);
			_startingIndex = startingIndex;
		}
		else
		{
			_startingIndex = 0;
		}
		if (_maxDuration > _duration)
		{
			object obj = this - -64;
			float num = ScrollRect.RubberDelta(_duration, _maxDuration);
			obj = num;
		}
		else
		{
			object obj2 = this - -64;
			obj2 = _duration;
		}
		Update();
	}

	private unsafe void Toggle(GameObject gameObject, bool toggle)
	{
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0061: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_00ef: Expected I, but got Obj
		MeshRenderer[] componentsInChildren = ((Component)(object)gameObject).GetComponentsInChildren<MeshRenderer>(true);
		if (componentsInChildren == null)
		{
			return;
		}
		bool value = ((bool*)(toggle ? 1 : 0))->m_value;
		nint num = (nint)typeof(ColorTeleboardMenuEffect._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<ColorTeleboardMenuEffect+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorTeleboardMenuEffect._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v50 (Il2CppClass<ColorTeleboardMenuEffect+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ColorTeleboardMenuEffect._003C_003Ec._003C_003E9__5_0 == null;
		bool flag2 = !flag;
		Func<MeshRenderer, Material> selector = ColorTeleboardMenuEffect._003C_003Ec._003C_003E9__5_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(ColorTeleboardMenuEffect._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v24 (Il2CppClass<ColorTeleboardMenuEffect+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ColorTeleboardMenuEffect._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v44 (Il2CppClass<ColorTeleboardMenuEffect+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<MeshRenderer, Material> func = default;
			object obj3 = func + 16;
			obj3 = ColorTeleboardMenuEffect._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(ColorTeleboardMenuEffect._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v41 (Il2CppClass<ColorTeleboardMenuEffect+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			selector = func;
		}
		IEnumerable<Material> enumerable = Enumerable.Select(componentsInChildren, selector);
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S3_v4+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v5+38]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S4_v5 (should have been resolved before IL gen)");
	}

	private void SetActiveIndex(int index)
	{
		_loopFrame = index;
	}

	private void Update()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		_currentDelay = _delay;
		((playThruster)this).InitializeMenu((HoverboardModelPreviewFactory)_startingIndex);
		object obj = this - -64;
		List<GameObject> effectList = _effectList;
		float currentWait = (float)obj / (float)effectList._size;
		_currentWait = currentWait;
	}

	public EffectPlayer()
	{
		//IL_0124: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected I4, but got Unknown
		//IL_01b3: Expected I4, but got Obj
		if (_currentDelay > 0f)
		{
			float unscaledTime = Time.unscaledTime;
			float currentDelay = _currentDelay - unscaledTime;
			_currentDelay = currentDelay;
			if (_currentDelay > 0f)
			{
				return;
			}
		}
		if (_loopFrame >= 0)
		{
			if (_currentIndex != _loopFrame)
			{
				_currentWait = 0f;
				((playThruster)this).InitializeMenu((HoverboardModelPreviewFactory)_loopFrame);
			}
			return;
		}
		if (_currentWait > 0f)
		{
			float unscaledTime2 = Time.unscaledTime;
			float currentWait = _currentWait - unscaledTime2;
			_currentWait = currentWait;
			return;
		}
		HoverboardModelPreviewFactory hoverboardModelPreviewFactory = (HoverboardModelPreviewFactory)(_currentIndex + 1);
		List<GameObject> effectList = _effectList;
		bool flag = (nint)hoverboardModelPreviewFactory >= effectList._size;
		bool flag2 = !flag;
		HoverboardModelPreviewFactory factory = hoverboardModelPreviewFactory;
		if (!flag2)
		{
			if (~(_doLoop ? 1u : 0u) != 0)
			{
				int index = hoverboardModelPreviewFactory - 1;
				GameObject gameObject = _effectList.get_Item(index);
				((HoverboardBundle)null).AddCustomBaseModel((int)gameObject, false);
				_currentIndex = 0;
				string text = tag;
				((GameObject)(object)text).tag = null;
				return;
			}
			factory = null;
		}
		((playThruster)this).InitializeMenu(factory);
		object obj = this - -64;
		List<GameObject> effectList2 = _effectList;
		float currentWait2 = (float)obj / (float)effectList2._size;
		_currentWait = currentWait2;
	}
}
