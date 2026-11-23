using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class BatTeleboardMenuEffect : ATeleboardMenuEffect
{
	private sealed class _003CDelayEndPoof_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterModel characterModel;

		public BatTeleboardMenuEffect _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00ac: Expected Obj, but got I
			//IL_00c9: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I
			//IL_03b1: Invalid comparison between Obj and F4
			//IL_0436: Expected I, but got Obj
			//IL_045f: Expected Obj, but got I
			//IL_046f: Expected Obj, but got I
			//IL_0112: Expected VT, but got Obj
			//IL_02a7: Expected F4, but got I
			//IL_02a2: Expected native int or pointer, but got VT
			//IL_02c6: Expected F4, but got I
			//IL_02c1: Expected native int or pointer, but got VT
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected Obj, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected VT, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			BatTeleboardMenuEffect batTeleboardMenuEffect = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					batTeleboardMenuEffect.SetRenderersActive(this.characterModel, state: true);
				}
			}
			else
			{
				_003C_003E1__state = -1;
				CharacterModel characterModel = this.characterModel;
				CharacterRig characterRig = characterModel._characterRig;
				Vector3 position = characterRig.hip.position;
				Transform transform = batTeleboardMenuEffect._camera.transform;
				Vector3 position2 = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				object obj2 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				object obj3 = num2 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				object obj4 = num3 - 0;
				object obj5 = obj2 * obj2;
				object obj6 = obj3 * obj3;
				object obj7 = obj5 + obj6;
				object obj8 = obj4 * obj4;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
				Vector3 vector2;
				object obj12;
				object obj13;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
				{
					object obj10 = obj4 / obj9;
					object obj11 = obj3 / obj9;
					vector2 = (Vector3)(obj2 / obj9);
					obj12 = obj11;
					obj13 = obj10;
				}
				else
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v105 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num5 = 0;
					vector2 = Vector3.zeroVector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v106 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v106 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
					obj13 = 0;
				}
				float num6 = (float)vector2 * batTeleboardMenuEffect._offsetDistance;
				float num7 = (float)obj12 * batTeleboardMenuEffect._offsetDistance;
				float num8 = (float)obj13 * batTeleboardMenuEffect._offsetDistance;
				object obj14;
				if (~(batTeleboardMenuEffect._lastWas1 ? 1u : 0u) == 0)
				{
					Transform transform2 = batTeleboardMenuEffect._poof2.transform;
					CharacterModel characterModel2 = this.characterModel;
					CharacterRig characterRig2 = characterModel2._characterRig;
					Vector3 position3 = characterRig2.hip.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					float num9 = 0f + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					float num10 = 0f + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					float num11 = 0f + num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Vector3 position4 = vector + 16;
					transform2.position = position4;
					obj14 = batTeleboardMenuEffect + 20;
				}
				else
				{
					Transform transform3 = batTeleboardMenuEffect._poof1.transform;
					CharacterModel characterModel3 = this.characterModel;
					CharacterRig characterRig3 = characterModel3._characterRig;
					Vector3 position5 = characterRig3.hip.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					float num12 = 0f + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					float num13 = 0f + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					float num14 = 0f + num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					((Vector3*)(nint)vector)->x = 0f;
					transform3.position = vector;
					obj14 = batTeleboardMenuEffect + 16;
				}
				GameObject gameObject = ((Component)obj14).gameObject;
				gameObject.SetActive(value: true);
				_ = batTeleboardMenuEffect._reappearDelay;
				object obj15 = default;
				_003C_003E2__current = obj15;
				_003C_003E1__state = 1;
			}
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private EffectPlayer _poof1;

	private EffectPlayer _poof2;

	private bool _lastWas1;

	private Renderer[] _cachedRenderers;

	private float _reappearDelay = 0.2f;

	private float _offsetDistance;

	private float _scale = 0.9f;

	private Camera _camera;

	private void OnEnable()
	{
		GameObject gameObject = _poof1.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _poof2.gameObject;
		gameObject2.SetActive(value: false);
		Layers instance = Layers.Instance;
		Camera camera = NGUITools.FindCameraForLayer(instance._3DGUI);
		_camera = camera;
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		Renderer[] cachedRenderers = _cachedRenderers;
		if (_cachedRenderers != null && cachedRenderers[0] != null)
		{
			SetRenderersActive(null, state: true);
		}
	}

	private void OnDestroy()
	{
		StopAllCoroutines();
	}

	public unsafe override void Initialize(Transform root)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected VT, but got Unknown
		//IL_00c7: Expected I, but got Obj
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected VT, but got Unknown
		//IL_017c: Expected I, but got Obj
		//IL_01ae: Expected F4, but got I
		//IL_01a9: Expected native int or pointer, but got VT
		//IL_01c9: Expected F4, but got I
		//IL_01c4: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 96);
		_rootTransform = root;
		Transform transform = base.transform;
		transform.parent = root;
		Transform transform2 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Vector3 localPosition = (Vector3)(quaternion + 32);
		transform2.localPosition = localPosition;
		Transform transform3 = base.transform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		float num5 = (float)Vector3.oneVector * _scale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num6 = 0f * _scale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num7 = 0f * _scale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Vector3 localScale = (Vector3)(quaternion + 16);
		transform3.localScale = localScale;
		Transform transform4 = base.transform;
		nint num8 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v50 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v51 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform4.rotation = quaternion;
		Transform transform5 = base.transform;
		transform5.parent = null;
	}

	private void SetRenderersActive(CharacterModel characterModel, bool state)
	{
		//IL_0149: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		bool flag = _cachedRenderers == null;
		bool flag2 = !flag;
		Renderer[] cachedRenderers = _cachedRenderers;
		if (!flag2)
		{
			if (characterModel != null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
				List<Renderer> list = default;
				IEnumerable<Renderer> collection = default;
				list._002Ector(collection);
				int num3 = 0;
				while (num3 < list._size)
				{
					Renderer renderer = list.get_Item(num3);
					if (renderer.enabled)
					{
						int num4 = num3 + 1;
						num3 = num4;
					}
					else
					{
						list.RemoveAt(num3);
					}
				}
				Renderer[] cachedRenderers2 = list.ToArray();
				_cachedRenderers = cachedRenderers2;
			}
			bool flag3 = _cachedRenderers == null;
			cachedRenderers = _cachedRenderers;
			if (flag3)
			{
				return;
			}
		}
		if (cachedRenderers.Length == 0)
		{
			return;
		}
		bool flag4 = cachedRenderers[0] != null;
		bool flag5 = !flag4;
		object obj = 0;
		if (flag5)
		{
			return;
		}
		while (true)
		{
			Renderer[] cachedRenderers3 = _cachedRenderers;
			if ((nint)obj < cachedRenderers3.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)cachedRenderers3 + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v25+10]");
				((Renderer)0).enabled = state;
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}

	public unsafe override void StartTeleboardEffect(float duration, CharacterModel characterModel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0071: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_038a: Invalid comparison between Obj and F4
		//IL_0403: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_012f: Expected VT, but got Obj
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_02c2: Expected F4, but got I
		//IL_02bd: Expected native int or pointer, but got VT
		//IL_02e1: Expected F4, but got I
		//IL_02dc: Expected native int or pointer, but got VT
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		SetRenderersActive(characterModel, state: false);
		GameObject gameObject = _poof1.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _poof2.gameObject;
		gameObject2.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterModel @ L2 (System.Single)+F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v9+C8]");
		Vector3 position = ((Transform)0).position;
		Transform transform = _camera.transform;
		Vector3 position2 = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		object obj4 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		object obj5 = num3 - 0;
		object obj6 = obj3 * obj3;
		object obj7 = obj4 * obj4;
		object obj8 = obj6 + obj7;
		object obj9 = obj5 * obj5;
		object obj10 = obj8 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		Vector3 vector2;
		object obj13;
		object obj14;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			object obj11 = obj5 / obj10;
			object obj12 = obj4 / obj10;
			vector2 = (Vector3)(obj3 / obj10);
			obj13 = obj12;
			obj14 = obj11;
		}
		else
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			vector2 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v94 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v94 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj14 = 0;
		}
		float num6 = (float)vector2 * _offsetDistance;
		float num7 = (float)obj13 * _offsetDistance;
		float num8 = (float)obj14 * _offsetDistance;
		object obj17;
		if (~(_lastWas1 ? 1u : 0u) == 0)
		{
			object obj15 = this + 20;
			Transform transform2 = ((Component)obj15).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterModel @ L2 (System.Single)+F0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v62+C8]");
			Vector3 position3 = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num9 = 0f + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num10 = 0f + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num11 = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 position4 = vector + 16;
			transform2.position = position4;
			obj17 = obj15;
		}
		else
		{
			object obj18 = this + 16;
			Transform transform3 = ((Component)obj18).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterModel @ L2 (System.Single)+F0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v44+C8]");
			Vector3 position5 = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num12 = 0f + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num13 = 0f + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num14 = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			transform3.position = vector;
			obj17 = obj18;
		}
		GameObject gameObject3 = ((Component)obj17).gameObject;
		gameObject3.SetActive(value: true);
		bool lastWas = (byte)((_lastWas1 ? 1u : 0u) ^ 1u) != 0;
		_lastWas1 = lastWas;
	}

	public override void EndTeleboardEffect(float duration, CharacterModel characterModel)
	{
		IEnumerator routine = DelayEndPoof(0f, characterModel);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DelayEndPoof(float duration, CharacterModel characterModel)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
