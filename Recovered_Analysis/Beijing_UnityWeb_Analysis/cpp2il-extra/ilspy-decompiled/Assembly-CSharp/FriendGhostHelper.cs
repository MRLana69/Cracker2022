using System;
using Cpp2ILInjected;
using UnityEngine;

public class FriendGhostHelper : MonoBehaviour
{
	public enum AnimatingState
	{
		_notset,
		OnScreen,
		OffScreen,
		AnimatingIn,
		AnimatingOut
	}

	public UISprite background;

	public UISprite frame;

	public UILabel points;

	public UILabel scoreType;

	public UITexture picture;

	public UISprite competitorIcon;

	private Transform _cachedTransform;

	private Vector3 _resetPosition;

	private Vector3 _activePosition;

	private Vector3 _moveOutPosition;

	private float _backgroundAlphaDefault;

	private float _frameAlphaDefault;

	private float _pointsAlphaDefault;

	private float _scoreTypeAlphaDefault;

	private float _pictureAlphaDefault;

	public int defaultBackgroundWidth;

	private bool inited;

	private bool _gameRunning;

	public bool noFriendsLeftToGhost = false;

	private FriendGhostHandler handler;

	private float _animationDuration;

	private float _currentAnimationDuration;

	public AnimatingState currentAnimationState;

	private void Update()
	{
		//IL_000b: Expected VT, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got F4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got F4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		_activePosition = (Vector3)(-1);
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		obj = 1f;
		_ = 219f / 255f;
		_ = 0f;
		_ = 1f;
		object obj3 = obj2 - -64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+8]");
		_ = 0;
		object obj4 = this + 68;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		object obj5 = obj2 + 32;
		Color black = Color.black;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+8]");
		_ = 0;
		object obj6 = this + 84;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		object obj7 = obj2 + 16;
		Color black2 = Color.black;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v26+8]");
		_ = 0;
		object obj8 = this + 100;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 1f;
		_ = 219f / 255f;
		_ = 0f;
		_ = 1f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 116;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		CancelInvoke();
	}

	private unsafe void Init()
	{
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected VT, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected VT, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0429: Expected I, but got Obj
		//IL_043f: Expected Obj, but got I
		//IL_0644: Expected F4, but got Obj
		//IL_063f: Expected native int or pointer, but got VT
		//IL_0659: Expected F4, but got I
		//IL_0654: Expected native int or pointer, but got VT
		//IL_0666: Expected F4, but got Obj
		//IL_0661: Expected native int or pointer, but got VT
		//IL_067b: Expected F4, but got I
		//IL_0676: Expected native int or pointer, but got VT
		//IL_06c5: Expected F4, but got Obj
		//IL_06c0: Expected native int or pointer, but got VT
		//IL_06da: Expected F4, but got I
		//IL_06d5: Expected native int or pointer, but got VT
		//IL_06e3: Expected Obj, but got VT
		//IL_046a: Expected I, but got Obj
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0530: Expected F4, but got Obj
		//IL_052b: Expected native int or pointer, but got VT
		//IL_0545: Expected F4, but got I
		//IL_0540: Expected native int or pointer, but got VT
		//IL_0552: Expected F4, but got Obj
		//IL_054d: Expected native int or pointer, but got VT
		//IL_0567: Expected F4, but got I
		//IL_0562: Expected native int or pointer, but got VT
		//IL_05b2: Expected I, but got Obj
		//IL_05c8: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_038b: Expected F4, but got Obj
		//IL_0386: Expected native int or pointer, but got VT
		//IL_03a0: Expected F4, but got I
		//IL_039b: Expected native int or pointer, but got VT
		//IL_03a9: Expected Obj, but got VT
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02cd: Expected F4, but got Obj
		//IL_02c8: Expected native int or pointer, but got VT
		//IL_02e2: Expected F4, but got I
		//IL_02dd: Expected native int or pointer, but got VT
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_0301: Expected native int or pointer, but got VT
		//IL_030f: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 36;
		obj3 = 0;
		_ = 0;
		if (~(inited ? 1u : 0u) != 0)
		{
			NewGame();
		}
		Vector3 vector = (Vector3)(obj2 + 72);
		Vector3 vector2 = (Vector3)(obj2 + 60);
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 12;
		object obj6 = currentAnimationState + -3;
		if (obj6 != null)
		{
			if ((nint)obj6 != 1)
			{
				return;
			}
			float unscaledTime = Time.unscaledTime;
			float currentAnimationDuration = _currentAnimationDuration + unscaledTime;
			_currentAnimationDuration = currentAnimationDuration;
			object obj7 = this + 52;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v54+8]");
			_ = 0;
			object obj8 = this - -64;
			obj5 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v59+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v125 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+8]");
			((Vector3*)(nint)vector)->z = 0f;
			float t = _currentAnimationDuration / _animationDuration;
			Vector3 vector4 = Vector3.LerpUnclamped(vector2, vector, t);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v93 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v121 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float t2 = _currentAnimationDuration / _animationDuration;
			float num5 = Mathf.LerpUnclamped(_backgroundAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			float num6 = Mathf.LerpUnclamped(_frameAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			float num7 = Mathf.LerpUnclamped(_pointsAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			float num8 = Mathf.LerpUnclamped(_scoreTypeAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			float num9 = Mathf.LerpUnclamped(_pictureAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			float num10 = Mathf.LerpUnclamped(_pictureAlphaDefault, 0f, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			if (!(_currentAnimationDuration < _animationDuration))
			{
				_currentAnimationDuration = 0f;
				object obj11 = this + 40;
				((Vector3*)(nint)vector2)->x = (float)obj11;
				Vector3 vector5 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S2_v41+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				Vector3 eulerAngles = ((Transform)vector).eulerAngles;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				currentAnimationState = AnimatingState.OffScreen;
				handler.SetNewChallenger();
			}
			else
			{
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
			}
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		float currentAnimationDuration2 = _currentAnimationDuration + unscaledTime2;
		_currentAnimationDuration = currentAnimationDuration2;
		object obj12 = this + 40;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v20+8]");
		_ = 0;
		object obj13 = this + 52;
		obj5 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v25+8]");
		_ = 0;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v59 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+8]");
		((Vector3*)(nint)vector)->z = 0f;
		float t3 = _currentAnimationDuration / _animationDuration;
		Vector3 vector7 = Vector3.LerpUnclamped(vector2, vector, t3);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles3 = ((Transform)vector).eulerAngles;
		if (!(_currentAnimationDuration < _animationDuration))
		{
			_currentAnimationDuration = 0f;
			currentAnimationState = AnimatingState.OnScreen;
		}
	}

	public void NewGame()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float backgroundAlphaDefault = default;
		_backgroundAlphaDefault = backgroundAlphaDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float frameAlphaDefault = default;
		_frameAlphaDefault = frameAlphaDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float pointsAlphaDefault = default;
		_pointsAlphaDefault = pointsAlphaDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float scoreTypeAlphaDefault = default;
		_scoreTypeAlphaDefault = scoreTypeAlphaDefault;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float pictureAlphaDefault = default;
		_pictureAlphaDefault = pictureAlphaDefault;
		object obj = this + 36;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		inited = true;
		object obj2 = this + 104;
		_0021_00210 componentInChildren = (_0021_00210)((Component)_cachedTransform).GetComponentInChildren<T>();
		obj2 = componentInChildren;
		UISprite uISprite = background;
		defaultBackgroundWidth = ((UIWidget)uISprite).mWidth;
	}

	public void AnimateIn()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		if (~(inited ? 1u : 0u) != 0)
		{
			NewGame();
		}
		_gameRunning = true;
		object obj = this + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		noFriendsLeftToGhost = false;
	}

	public void AnimateOut()
	{
		if (~(noFriendsLeftToGhost ? 1u : 0u) != 0)
		{
			currentAnimationState = AnimatingState.AnimatingIn;
		}
	}

	public void NoFriendsLeft()
	{
		if (~(_gameRunning ? 1u : 0u) == 0)
		{
			currentAnimationState = AnimatingState.AnimatingOut;
		}
	}

	public void GameOver()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		noFriendsLeftToGhost = true;
		currentAnimationState = AnimatingState.OffScreen;
	}

	public void Reset()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		if (~(inited ? 1u : 0u) != 0)
		{
			NewGame();
		}
		_gameRunning = false;
		object obj = this + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		currentAnimationState = AnimatingState.OffScreen;
	}

	public FriendGhostHelper()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		object obj = this + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		currentAnimationState = AnimatingState.OffScreen;
	}
}
