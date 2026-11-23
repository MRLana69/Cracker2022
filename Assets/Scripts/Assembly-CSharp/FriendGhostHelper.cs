using System;
using Cpp2ILInjected;
using TMPro;
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

	public CanvasGroup background;

	public CanvasGroup frame;

	public TMP_Text points;

	public TMP_Text scoreType;

	public CanvasGroup competitorIcon;

	private Transform _cachedTransform;

	private Vector3 _resetPosition = (Vector3)1120403456;

	private Vector3 _activePosition;

	private Vector3 _moveOutPosition = (Vector3)(-4389320783558082560L);

	private float _backgroundAlphaDefault;

	private float _frameAlphaDefault;

	private float _pointsAlphaDefault;

	private float _scoreTypeAlphaDefault;

	private float _pictureAlphaDefault;

	public int defaultBackgroundWidth;

	private bool inited;

	private bool _gameRunning;

	public bool noFriendsLeftToGhost;

	private FriendGhostHandler handler;

	private float _animationDuration = 0.5f;

	private float _currentAnimationDuration;

	public AnimatingState currentAnimationState;

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got VT
		//IL_03b9: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected VT, but got Unknown
		//IL_0163: Expected Obj, but got VT
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_0519: Expected Obj, but got I
		//IL_0348: Expected F4, but got I
		//IL_0343: Expected native int or pointer, but got VT
		//IL_0367: Expected F4, but got I
		//IL_0362: Expected native int or pointer, but got VT
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		if (~(inited ? 1u : 0u) != 0)
		{
			Init();
		}
		object obj2 = currentAnimationState - 3;
		if (currentAnimationState != AnimatingState.AnimatingIn)
		{
			if ((nint)obj2 == 1)
			{
				float deltaTime = Time.deltaTime;
				float num = (_currentAnimationDuration += deltaTime);
				object obj3 = _moveOutPosition - _activePosition;
				float num2 = num / _animationDuration;
				float num3 = Math.Min(num2, 1f);
				bool flag = num2 < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				float num5 = (float)obj3 * num4;
				float num6 = (float)_activePosition + num5;
				object obj4 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+34]");
				object obj5 = obj4 - 0;
				float num7 = (float)obj5 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+34]");
				float num8 = 0f + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+44]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+38]");
				object obj6 = num9 - 0;
				float num10 = (float)obj6 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+38]");
				float num11 = 0f + num10;
				float num12 = 0f - _backgroundAlphaDefault;
				float num13 = num12 * num4;
				float alpha = _backgroundAlphaDefault + num13;
				background.alpha = alpha;
				float num14 = 0f - _frameAlphaDefault;
				float num15 = num14 * num4;
				float alpha2 = _frameAlphaDefault + num15;
				frame.alpha = alpha2;
				float num16 = 0f - _pointsAlphaDefault;
				float num17 = num16 * num4;
				float alpha3 = _pointsAlphaDefault + num17;
				points.alpha = alpha3;
				float num18 = 0f - _scoreTypeAlphaDefault;
				float num19 = num18 * num4;
				float alpha4 = _scoreTypeAlphaDefault + num19;
				scoreType.alpha = alpha4;
				float num20 = 0f - _pictureAlphaDefault;
				float num21 = num20 * num4;
				float alpha5 = _pictureAlphaDefault + num21;
				competitorIcon.alpha = alpha5;
				if (!(_currentAnimationDuration < _animationDuration))
				{
					_currentAnimationDuration = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
					_ = 0;
					_ = _resetPosition;
					Vector3 localPosition = vector + 16;
					_cachedTransform.localPosition = localPosition;
					background.alpha = _backgroundAlphaDefault;
					frame.alpha = _frameAlphaDefault;
					points.alpha = _pointsAlphaDefault;
					scoreType.alpha = _scoreTypeAlphaDefault;
					competitorIcon.alpha = _pictureAlphaDefault;
					currentAnimationState = AnimatingState.OffScreen;
					handler.FinishedAnimatingOut();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					((Vector3*)(nint)vector)->x = 0f;
					_cachedTransform.localPosition = vector;
				}
			}
		}
		else
		{
			float deltaTime2 = Time.deltaTime;
			float num22 = (_currentAnimationDuration += deltaTime2);
			object obj7 = _activePosition - _resetPosition;
			float num23 = num22 / _animationDuration;
			float num24 = Math.Min(num23, 1f);
			bool flag2 = num23 < 0f;
			float num25 = 0f;
			if (!flag2)
			{
				num25 = num24;
			}
			float num26 = (float)obj7 * num25;
			float num27 = (float)_resetPosition + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+34]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+28]");
			object obj8 = num28 - 0;
			float num29 = (float)obj8 * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+28]");
			float num30 = 0f + num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+38]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
			object obj9 = num31 - 0;
			float num32 = (float)obj9 * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
			float num33 = 0f + num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition2 = vector + 32;
			_cachedTransform.localPosition = localPosition2;
			if (!(_currentAnimationDuration < _animationDuration))
			{
				_currentAnimationDuration = 0f;
			}
		}
	}

	private void Init()
	{
		//IL_0082: Expected F4, but got I
		//IL_009e: Expected F4, but got I
		float alpha = background.alpha;
		_backgroundAlphaDefault = alpha;
		float alpha2 = frame.alpha;
		_frameAlphaDefault = alpha2;
		TMP_Text tMP_Text = points;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (TMPro.TMP_Text)+C4]");
		_pointsAlphaDefault = 0f;
		TMP_Text tMP_Text2 = scoreType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v12 (TMPro.TMP_Text)+C4]");
		_scoreTypeAlphaDefault = 0f;
		Transform cachedTransform = transform;
		_cachedTransform = cachedTransform;
		inited = true;
		FriendGhostHandler component = _cachedTransform.GetComponent<FriendGhostHandler>();
		handler = component;
	}

	public unsafe void NewGame()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005d: Expected F4, but got I
		//IL_0058: Expected native int or pointer, but got VT
		//IL_006c: Expected F4, but got VT
		//IL_0067: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(inited ? 1u : 0u) != 0)
		{
			Init();
		}
		_gameRunning = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_resetPosition;
		_cachedTransform.localPosition = vector;
		background.alpha = _backgroundAlphaDefault;
		frame.alpha = _frameAlphaDefault;
		points.alpha = _pointsAlphaDefault;
		scoreType.alpha = _scoreTypeAlphaDefault;
		competitorIcon.alpha = _pictureAlphaDefault;
		noFriendsLeftToGhost = false;
	}

	public void AnimateIn()
	{
		if (~(noFriendsLeftToGhost ? 1u : 0u) != 0)
		{
			currentAnimationState = AnimatingState.AnimatingIn;
		}
	}

	public void AnimateOut()
	{
		if (~(_gameRunning ? 1u : 0u) == 0)
		{
			currentAnimationState = AnimatingState.AnimatingOut;
		}
	}

	public unsafe void GameOver()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005d: Expected F4, but got I
		//IL_0058: Expected native int or pointer, but got VT
		//IL_006c: Expected F4, but got VT
		//IL_0067: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(inited ? 1u : 0u) != 0)
		{
			Init();
		}
		_gameRunning = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_resetPosition;
		_cachedTransform.localPosition = vector;
		background.alpha = _backgroundAlphaDefault;
		frame.alpha = _frameAlphaDefault;
		points.alpha = _pointsAlphaDefault;
		scoreType.alpha = _scoreTypeAlphaDefault;
		competitorIcon.alpha = _pictureAlphaDefault;
		currentAnimationState = AnimatingState.OffScreen;
	}

	public unsafe void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002e: Expected F4, but got I
		//IL_0029: Expected native int or pointer, but got VT
		//IL_003d: Expected F4, but got VT
		//IL_0038: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		noFriendsLeftToGhost = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendGhostHelper)+2C]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_resetPosition;
		_cachedTransform.localPosition = vector;
		background.alpha = _backgroundAlphaDefault;
		frame.alpha = _frameAlphaDefault;
		points.alpha = _pointsAlphaDefault;
		scoreType.alpha = _scoreTypeAlphaDefault;
		competitorIcon.alpha = _pictureAlphaDefault;
		currentAnimationState = AnimatingState.OffScreen;
	}

	public FriendGhostHelper()
	{
		//IL_001a: Expected VT, but got I8
		//IL_0025: Expected VT, but got I4
		_ = 0;
		_ = 0;
		_ = -4411275835009400832L;
		base._002Ector();
	}
}
