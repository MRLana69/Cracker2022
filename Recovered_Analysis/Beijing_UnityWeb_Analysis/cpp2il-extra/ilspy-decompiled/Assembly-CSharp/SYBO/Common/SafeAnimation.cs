using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Json;
using UnityEngine;

namespace SYBO.Common;

public class SafeAnimation
{
	public class SafeAnimationEventEventArgs : EventArgs
	{
		private string _message;

		public unsafe string Message
		{
			get
			{
				//IL_0073: Expected I, but got Obj
				//IL_0089: Expected Obj, but got I
				//IL_0013: Expected I, but got Obj
				nint num = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int day = ((DateTime*)this)->Day;
				Encoding uTF = Encoding.UTF32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				_0021_00210 obj2 = default;
				return JsonApi.Serialize<T>((T)obj2, (JsonContext)null);
			}
		}

		public SafeAnimationEventEventArgs(string message)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected Obj, but got Unknown
			//IL_031e: Expected Obj, but got I4
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected Obj, but got Unknown
			//IL_011b: Expected Obj, but got I4
			//IL_01a3: Expected Obj, but got I
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected Obj, but got Unknown
			//IL_025c: Expected Obj, but got I
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			//IL_0081: Expected Obj, but got I
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_00ce: Expected Obj, but got I4
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected Obj, but got Unknown
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected Obj, but got Unknown
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			AggregatedDataTracking.DataCompleteness dataCompleteness = ((AggregatedDataTracking.DataContainer)(object)this).DataCompleteness;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
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
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v88+C]");
						object obj7 = (nint)0 + (nint)1;
						object obj8 = obj4 + 4;
						object obj9 = obj8 + 1;
						obj8 = obj9;
						object obj10 = obj9 << 2;
						object obj11 = obj4 + obj10;
						obj11 = 107;
						break;
					}
					continue;
				}
				object obj12 = obj4 + 4;
				object obj13 = obj12 + 1;
				obj12 = obj13;
				object obj14 = obj13 << 2;
				object obj15 = obj4 + obj14;
				obj15 = 77;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj16 = (nint)0 << 2;
				object obj17 = obj4 + obj16;
				if ((nint)obj17 == 107)
				{
					object obj18 = obj4 + 4;
					if ((nint)obj18 > -1)
					{
						object obj19 = obj18 + -1;
						obj18 = obj19;
					}
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj20 = (nint)0 << 2;
				object obj21 = obj4 + obj20;
				if ((nint)obj21 == 77)
				{
					object obj22 = obj4 + 4;
					if ((nint)obj22 > -1)
					{
						object obj23 = obj22 + -1;
						obj22 = obj23;
					}
					goto IL_03ac;
				}
			}
			object obj24 = default;
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_03ac;
			IL_03ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj26 = default;
			object obj25 = obj26 + 8;
			obj25 = message;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		}
	}

	private bool _loggingEnabled;

	private EventHandler<SafeAnimationEventEventArgs> m_OnSafeAnimationEvent;

	private Animation _animation;

	public Animation Animation
	{
		get
		{
			((CollisionNotifier)this).ClearFrame();
			return _animation;
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSafeAnimationEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event EventHandler<SafeAnimationEventEventArgs> OnSafeAnimationEvent
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_00ae: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - -64;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D4");
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			object obj4 = obj2 + 32;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			object obj5 = obj2 + 16;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			SafeAnimation safeAnimation = (SafeAnimation)0;
			_loggingEnabled = false;
			safeAnimation = (SafeAnimation)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_loggingEnabled = false;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSafeAnimationEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public unsafe SafeAnimation(Animation animation, bool loggingEnabled)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected VT, but got Unknown
		//IL_011e: Expected F4, but got Obj
		//IL_0119: Expected native int or pointer, but got VT
		//IL_0133: Expected F4, but got I
		//IL_012e: Expected native int or pointer, but got VT
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected VT, but got Unknown
		//IL_014e: Expected F4, but got Obj
		//IL_0149: Expected native int or pointer, but got VT
		//IL_0163: Expected F4, but got I
		//IL_015e: Expected native int or pointer, but got VT
		//IL_01d9: Expected F4, but got Obj
		//IL_01d4: Expected native int or pointer, but got VT
		//IL_01eb: Expected F4, but got I
		//IL_01e6: Expected native int or pointer, but got VT
		//IL_0209: Expected F4, but got Obj
		//IL_0204: Expected native int or pointer, but got VT
		//IL_021e: Expected F4, but got I
		//IL_0219: Expected native int or pointer, but got VT
		//IL_022b: Expected F4, but got Obj
		//IL_0226: Expected native int or pointer, but got VT
		//IL_0240: Expected F4, but got I
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = ((bool*)(loggingEnabled ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loggingEnabled @ L2 (System.Boolean)+8]");
		_ = 0;
		object obj3 = obj2 + 24;
		obj3 = ((bool*)(loggingEnabled ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [loggingEnabled @ L2 (System.Boolean)+8]");
		_ = 0;
		object obj4 = obj2 + 12;
		obj4 = animation;
		_ = ((UnityEngine.Object)animation).m_CachedPtr;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj2 + 60);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		float num3 = vector.x * vector3.x;
		float num4 = vector.y * vector3.y;
		float num5 = num3 + num4;
		float num6 = vector.z * vector3.z;
		float angle = num5 + num6;
		((Vector3*)(nint)vector3)->x = (float)animation;
		((Vector3*)(nint)vector3)->z = (nint)((UnityEngine.Object)animation).m_CachedPtr;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector3);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector, vector3);
	}

	public void DebugLog(string methodName, object message = null)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		object obj = this + 16;
		obj = methodName;
		bool loggingEnabled = (byte)(message & 1) != 0;
		_loggingEnabled = loggingEnabled;
	}

	public unsafe void SetSpeed(string animationClipName, float speed)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected VT, but got Unknown
		//IL_00ce: Expected F4, but got Obj
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		//IL_00ec: Expected Ref, but got VT
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = animationClipName;
		_ = animationClipName.m_stringLength;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 24);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 normalized = ((Vector3*)vector)->normalized;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / speed;
	}

	public void SetSpeed(AnimationState animationState, float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
	}

	public void SetRotation(Quaternion rotation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got VT
		object obj = this + 16;
		obj = rotation;
	}

	public void SetLocalRotation(Quaternion rotation)
	{
		//IL_001c: Expected Obj, but got F4
		//IL_002e: Expected I, but got F4
		GameObject gameObject = _animation.gameObject;
		Transform transform = (Transform)rotation.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)rotation.z;
		Quaternion localRotation = transform.localRotation;
	}

	public bool HasAnimationClip(string animationClipName)
	{
		if (animationClipName.m_stringLength == 1)
		{
			return true;
		}
		if (animationClipName.m_stringLength == 2)
		{
			return true;
		}
		if (animationClipName.m_stringLength == 4)
		{
			return true;
		}
		if (animationClipName.m_stringLength == 5)
		{
			return true;
		}
		if (animationClipName.m_stringLength == 13)
		{
			return true;
		}
		return animationClipName.m_stringLength == 12;
	}

	public AnimationClip GetAnimationClip(string animationClipName)
	{
		//IL_0014: Expected VT, but got Obj
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		if (animationClipName != null)
		{
			CollisionFlags collisionFlags = ((CharacterController)(object)_animation).Move((Vector3)animationClipName);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)collisionFlags).FindKernel(null);
			return (AnimationClip)num3;
		}
		return null;
	}

	public AnimationState GetAnimationState(string animationStateName)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0013: Expected Obj, but got I4
		return (AnimationState)((CharacterController)(object)_animation).Move((Vector3)animationStateName);
	}

	public bool HasAnimationState(string animationStateName)
	{
		//IL_000f: Expected I4, but got Obj
		return _animation.Play((PlayMode)animationStateName);
	}

	public void AddClip(AnimationClip animationClip, string newName)
	{
	}

	public void CrossFadeQueued(string animationName)
	{
		GameObject gameObject = _animation.gameObject;
		((UnityEngine.Object)(object)animationName).m_CachedPtr = (IntPtr)animationName.m_stringLength;
		Vector3 localScale = ((Transform)(object)animationName).localScale;
	}

	public void CrossFadeQueued(string animationName, float fadeLength)
	{
		((CharacterController)(object)animationName).height = fadeLength;
	}

	public void CrossFade(string animationName)
	{
		AnimationState animationState = _animation.PlayQueued(animationName);
		((MeshCombiner)this).Combine((GameObject)(object)"CrossFadeQueued", (IList<ObjectModelInfo>)(object)animationName);
	}

	public unsafe void TryAddAnimationEvent(Animation animationInstance, string animationName, AnimationEvent animationEvent)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0053: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected VT, but got Unknown
		//IL_013c: Expected F4, but got Obj
		//IL_0137: Expected native int or pointer, but got VT
		//IL_0151: Expected F4, but got I
		//IL_014c: Expected native int or pointer, but got VT
		//IL_017b: Expected VT, but got Obj
		//IL_0094: Expected I, but got Obj
		int layer = ((GameObject)this).layer;
		object obj = default;
		Transform transform = (Transform)(obj + 56);
		transform = (Transform)(object)animationInstance;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)animationInstance).m_CachedPtr;
		Vector3 localPosition = transform.localPosition;
		int layer2 = ((GameObject)this).layer;
		object obj2 = obj + 28;
		obj2 = animationName;
		_ = animationName.m_stringLength;
		object obj3 = obj + 16;
		obj3 = animationEvent;
		_ = animationEvent.m_Time;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v29 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj + 40);
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v10+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion2 = quaternion * (Quaternion)transform;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Quaternion localRotation = transform.localRotation;
	}

	public void CrossFade(string animationName, float fadeLength)
	{
		//IL_0055: Expected VT, but got Obj
		//IL_0055: Expected VT, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got F4
		//IL_000d: Expected Obj, but got F4
		bool flag = Physics.Raycast((Vector3)_animation, (Vector3)animationName, fadeLength);
		object obj2 = default;
		object obj = obj2 + 4;
		obj = fadeLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = animationName + " , " + text2;
		obj2 = fadeLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string meshInfos = animationName + " , " + text3;
		((MeshCombiner)this).Combine((GameObject)(object)"CrossFadeQueued", (IList<ObjectModelInfo>)(object)meshInfos);
	}

	public void SetEnabled(string animationName, bool isEnabled)
	{
		((AnimationState)(object)_animation).AddMixingTransform((Transform)(object)animationName, isEnabled);
	}

	public void Stop()
	{
	}

	public void PlayQueued(string animationName)
	{
		_animation.RemoveClip((AnimationClip)(object)animationName);
		((MeshCombiner)this).Combine((GameObject)(object)"CrossFade", (IList<ObjectModelInfo>)(object)animationName);
	}

	public void Play(string animationName)
	{
		//IL_0014: Expected I4, but got Obj
		bool flag = _animation.PlayDefaultAnimation((PlayMode)animationName);
		((MeshCombiner)this).Combine((GameObject)(object)"PlayQueued", (IList<ObjectModelInfo>)(object)animationName);
	}

	public void Play()
	{
		Animation.INTERNAL_CALL_Stop(_animation);
		((MeshCombiner)this).Combine((GameObject)(object)"Stop", (IList<ObjectModelInfo>)null);
	}

	public bool IsPlaying(string animationName)
	{
		//IL_0018: Expected Obj, but got I4
		bool flag = HasAnimationState(animationName);
		return ((TrackedReference)flag).Equals(null);
	}

	public bool HasAnimation()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)_animation != 0;
	}

	private void RaiseOnSafeAnimationEvent(string methodName, object message = null)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_0020: Expected Obj, but got I4
		bool flag = _animation.Play((PlayMode)methodName);
		((AnimationState)flag).wrapMode = (WrapMode)message;
	}
}
