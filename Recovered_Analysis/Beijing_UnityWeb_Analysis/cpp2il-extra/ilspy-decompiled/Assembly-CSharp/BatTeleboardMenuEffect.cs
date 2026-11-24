using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class BatTeleboardMenuEffect : ATeleboardMenuEffect
{
	private sealed class _003CDelayEndPoof_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BatTeleboardMenuEffect _003C_003E4__this;

		public CharacterModel characterModel;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0045: Expected I4, but got Obj
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Expected Obj, but got Unknown
				//IL_0085: Expected Obj, but got I4
				BatTeleboardMenuEffect batTeleboardMenuEffect = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						((ColorTeleboardMenuEffect)_003C_003E4__this).AddChildrenMaterials((Transform)(object)characterModel, ref *(List<Material>*)1);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				((EffectPlayer)(object)_003C_003E4__this).LoopFrame = (int)characterModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = ((EffectPlayer)(object)batTeleboardMenuEffect)._doLoop;
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

	private EffectPlayer _poof1;

	private EffectPlayer _poof2;

	private bool _lastWas1;

	private Renderer[] _cachedRenderers;

	private float _reappearDelay;

	private float _offsetDistance;

	private float _scale;

	private Camera _camera;

	private void OnEnable()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = this + 16;
		obj = "";
		object obj2 = this + 20;
		obj2 = "";
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 12;
		Vector3 one = Vector3.one;
		object obj6 = obj5 + 24;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+8]");
		_ = 0;
		object obj7 = this + 28;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20+8]");
		_ = 0;
		_offsetDistance = 0.2f;
		Vector3 one2 = Vector3.one;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = this + 48;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20+8]");
		_ = 0;
		base._002Ector();
	}

	private void OnDisable()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		string text = _poof1.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _poof2.tag;
		((GameObject)(object)text2).tag = null;
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Layers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		object obj2 = (startupFinished ? 1 : 0) - -64;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 48;
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)obj2);
		obj4 = typeName;
	}

	private unsafe void OnDestroy()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		MonoBehaviour.print(this);
		if (_cachedRenderers == null)
		{
			return;
		}
		object obj = _cachedRenderers + 16;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0)
		{
			((ColorTeleboardMenuEffect)this).AddChildrenMaterials((Transform)null, ref *(List<Material>*)1);
		}
	}

	public override void Initialize(Transform root, bool boardOnly = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = root;
		_boardOnly = boardOnly;
	}

	private void SetRenderersActive(CharacterModel characterModel, bool state)
	{
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_00fe: Expected VT, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 56);
		object obj2 = obj + 40;
		object obj3 = obj + 28;
		object obj4 = obj + 16;
		object obj5 = this + 12;
		obj5 = characterModel;
		_boardOnly = state;
		if (state)
		{
			_offsetDistance = 0f;
			return;
		}
		GameObject gameObject = base.gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)characterModel;
		GameObject gameObject2 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 vector = (Vector3)transform / _scale;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject3).parent = transform;
		GameObject gameObject4 = base.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v36 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v46 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Quaternion localRotation = transform.localRotation;
		GameObject gameObject5 = base.gameObject;
		((Transform)(object)gameObject5).parentInternal = null;
	}

	public override void StartTeleboardEffect(float duration, CharacterModel characterModel)
	{
		((GameStats)(object)_rootTransform).JumpsOverTrainsCountIncrement();
	}

	public unsafe override void EndTeleboardEffect(float duration, CharacterModel characterModel)
	{
		//IL_0051: Expected I4, but got Obj
		((ColorTeleboardMenuEffect)this).AddChildrenMaterials((Transform)(object)characterModel, ref *(List<Material>*)null);
		string text = _poof1.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _poof2.tag;
		((GameObject)(object)text2).tag = null;
		((EffectPlayer)(object)this).LoopFrame = (int)characterModel;
		bool lastWas = _lastWas1;
		bool lastWas2 = (byte)((lastWas ? 1u : 0u) ^ 1u) != 0;
		_lastWas1 = lastWas2;
	}

	private IEnumerator DelayEndPoof(float duration, CharacterModel characterModel)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 24;
		obj2 = characterModel;
		return enumerator;
	}

	private void UpdatePoofs(CharacterModel characterModel)
	{
		if ((object)characterModel != null)
		{
			if ((nint)characterModel != 1)
			{
				if ((nint)characterModel == 2)
				{
					GameStats rootTransform = (GameStats)(object)_rootTransform;
					int jetpackPickupsCollected = rootTransform._movingTrainHit + 1;
					rootTransform.JetpackPickupsCollected = jetpackPickupsCollected;
				}
			}
			else
			{
				((GameStats)(object)_rootTransform).JetpackPickupsCollectedIncrement();
			}
		}
		else
		{
			((GameStats)(object)_rootTransform).BarrierHitCountIncrement();
		}
	}

	public BatTeleboardMenuEffect()
	{
		OnDestroy();
	}
}
