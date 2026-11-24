using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using TopRun.UI;
using UnityEngine;

namespace UI.Generic;

public class UIScaleAnimation : MonoBehaviour
{
	private sealed class _003CWaitForSecondsAndRestart_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float restPeriod;

		public UIScaleAnimation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.ResetAllSprites();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = restPeriod;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
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

	private const float COMPLETION_THRESHOLD = 0.01f;

	private float _duration;

	private Vector2 _scaleRange;

	private float _fadeFrom;

	private float _fadeTo;

	private float _restPeriod;

	private float _spawnRate;

	private int _spawnAmount;

	private UISprite _originalSprite;

	private UISprite[] _sprites;

	private float[] _spawnTimes;

	private float _timer;

	private Vector3 _startScale;

	private Vector3 _endScale;

	private void Awake()
	{
		//IL_000b: Expected F4, but got I4
		_duration = 1f;
		CancelInvoke();
	}

	private unsafe void OnEnable()
	{
		//IL_0488: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected VT, but got Unknown
		//IL_054a: Expected F4, but got Obj
		//IL_0545: Expected native int or pointer, but got VT
		//IL_055f: Expected F4, but got I
		//IL_055a: Expected native int or pointer, but got VT
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_057a: Expected F4, but got Obj
		//IL_058b: Expected F4, but got Obj
		//IL_0586: Expected native int or pointer, but got VT
		//IL_059d: Expected F4, but got I
		//IL_0598: Expected native int or pointer, but got VT
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got F4
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006a: Expected F4, but got Obj
		//IL_0065: Expected native int or pointer, but got VT
		//IL_007f: Expected F4, but got I
		//IL_007a: Expected native int or pointer, but got VT
		//IL_0094: Expected F4, but got I
		//IL_00a5: Expected F4, but got Obj
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00ba: Expected F4, but got I
		//IL_00b5: Expected native int or pointer, but got VT
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got F4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got F4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v105 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 40;
		Vector3 forward = Vector3.forward;
		object obj4 = this + 16;
		Vector3 vector = (Vector3)(obj3 + 56);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Transform transform = (Transform)(obj3 + 24);
		Vector3 vector3 = vector / (float)obj4;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj5 = this + 60;
		obj5 = vector.x;
		_ = vector.z;
		object obj6 = obj3 + 12;
		Vector3 forward2 = Vector3.forward;
		object obj7 = this + 16;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v31+4]");
		Vector3 vector6 = vector5 / 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj8 = this + 72;
		obj8 = vector.x;
		_ = vector.z;
		object obj9 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj9 = obj10;
		object obj11 = 0;
		while ((nint)obj11 < _spawnAmount)
		{
			object obj12 = _spawnTimes + 16;
			object obj13 = obj11 << 2;
			object obj14 = obj12 + obj13;
			float num3 = (float)obj11 * _spawnRate;
			obj14 = num3;
			object obj15 = obj11 + 1;
			obj11 = obj15;
		}
		object obj16 = this + 44;
		UISprite component = GetComponent<UISprite>();
		obj16 = component;
		object obj17 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj18 = default;
		obj17 = obj18;
		_originalSprite.tag = null;
		object obj19 = 0;
		if ((nint)obj19 < _spawnAmount)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Stream stream = default;
			UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
			int layer = ((GameObject)(object)stream).layer;
			GameObject gameObject = base.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
			((Transform)layer).parentInternal = parentInternal;
			((GameObject)(object)stream).SetActive(true);
			UISprite uISprite = ((GameObject)(object)stream).AddComponent<UISprite>();
			throw new ArrayTypeMismatchException();
		}
		Update();
	}

	private void RestartAnimation()
	{
		ResetAllSprites();
	}

	private void ResetAllSprites()
	{
		Update();
		_timer = 0f;
	}

	private void Update()
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		object obj2 = _sprites + 12;
		object obj3 = default;
		object obj9 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = _sprites + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj6 != null))
			{
				string text = ((Component)obj6).tag;
				((GameObject)(object)text).tag = null;
				GameObject gameObject = ((Component)obj6).gameObject;
				object obj8 = this + 60;
				obj = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v7+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				((Transform)(object)gameObject).parent = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				string text2 = ((Component)obj6).tag;
				((GameObject)(object)text2).tag = (string)1;
			}
			obj3 = obj9 + 1;
		}
	}

	private IEnumerator WaitForSecondsAndRestart(float restPeriod)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	public unsafe UIScaleAnimation()
	{
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected VT, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected VT, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0426: Expected F4, but got Obj
		//IL_0421: Expected native int or pointer, but got VT
		//IL_043b: Expected F4, but got I
		//IL_0436: Expected native int or pointer, but got VT
		//IL_0448: Expected F4, but got Obj
		//IL_0443: Expected native int or pointer, but got VT
		//IL_045d: Expected F4, but got I
		//IL_0458: Expected native int or pointer, but got VT
		//IL_04a6: Expected I, but got Obj
		//IL_04bc: Expected Obj, but got I
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_018f: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_01dc: Expected I, but got Obj
		//IL_02db: Expected F4, but got Obj
		//IL_02d6: Expected native int or pointer, but got VT
		//IL_02f0: Expected F4, but got I
		//IL_02eb: Expected native int or pointer, but got VT
		//IL_02fd: Expected Obj, but got VT
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		Vector3 vector2 = (Vector3)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		obj4 = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		string text = parentInternal.tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		object obj5 = _sprites + 12;
		object obj6 = default;
		object obj10 = default;
		object obj11;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj7 = _sprites + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				if (!((UIWidget)obj9).hasVertices)
				{
					obj6 = obj10 + 1;
					continue;
				}
				obj11 = 0;
				break;
			}
			return;
		}
		while ((nint)obj11 < _spawnAmount)
		{
			float num = (float)obj11 * _spawnRate;
			float num2 = _timer - num;
			if (num2 < 0f)
			{
				break;
			}
			object obj12 = this + 60;
			obj2 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v34+8]");
			_ = 0;
			object obj13 = this + 72;
			obj3 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v39+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			float num5 = num2 / _duration;
			Vector3 vector3 = Vector3.LerpUnclamped(vector2, vector, num5);
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S2_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S2_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num8 = Mathf.LerpUnclamped(_fadeFrom, _fadeTo, num5);
			object obj16 = _sprites + 16;
			object obj17 = obj11 << 2;
			object obj18 = obj16 + obj17;
			string text3 = ((Component)obj18).tag;
			float num9 = 1f - num5;
			if (!(num9 > 0.01f))
			{
				((GameObject)(object)text3).tag = null;
				object obj19 = _spawnAmount - 1;
				if (obj11 == obj19)
				{
					IEnumerator list = ((TopRunOnlineScreen)this).AnimateMedalAfterSeconds(_restPeriod);
					Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				}
			}
			else
			{
				((GameObject)(object)text3).tag = (string)1;
				object obj20 = _sprites + 16;
				object obj21 = obj11 << 2;
				object obj22 = obj20 + obj21;
				GameObject gameObject2 = ((Component)obj22).gameObject;
				((Vector3*)(nint)vector)->x = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector)->z = 0f;
				((Transform)(object)gameObject2).parent = (Transform)vector;
				object obj23 = _sprites + 16;
				object obj24 = obj11 << 2;
				object obj25 = obj23 + obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			}
			object obj26 = obj11 + 1;
			obj11 = obj26;
		}
		float unscaledTime = Time.unscaledTime;
		float timer = _timer + unscaledTime;
		_timer = timer;
	}
}
