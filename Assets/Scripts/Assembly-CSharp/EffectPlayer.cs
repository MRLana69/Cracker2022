using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

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

	public int LoopFrame
	{
		set
		{
			_loopFrame = value;
		}
	}

	public float Duration => _selectedDuration;

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
	}

	private void OnEnable()
	{
		int startingIndex;
		if (~(_doRandomizeStartingIndex ? 1u : 0u) == 0)
		{
			List<GameObject> effectList = _effectList;
			startingIndex = Random.Range(0, effectList._size);
		}
		else
		{
			startingIndex = 0;
		}
		_startingIndex = startingIndex;
		float selectedDuration = ((!(_maxDuration > _duration)) ? _duration : Random.Range(_duration, _maxDuration));
		_selectedDuration = selectedDuration;
		Reset();
	}

	private void Reset()
	{
		_currentDelay = _delay;
		SetActiveIndex(_startingIndex);
		List<GameObject> effectList = _effectList;
		float currentWait = _selectedDuration / (float)effectList._size;
		_currentWait = currentWait;
	}

	private void Toggle(GameObject gameObject, bool toggle)
	{
		gameObject.SetActive(toggle);
	}

	private void SetActiveIndex(int index)
	{
		if (_currentIndex >= 0)
		{
			GameObject gameObject = _effectList.get_Item(_currentIndex);
			Toggle(gameObject, toggle: false);
		}
		_currentIndex = index;
		GameObject gameObject2 = _effectList.get_Item(index);
		Toggle(gameObject2, toggle: true);
	}

	private void Update()
	{
		if (_currentDelay > 0f)
		{
			float deltaTime = Time.deltaTime;
			if ((_currentDelay -= deltaTime) > 0f)
			{
				return;
			}
		}
		if (_loopFrame >= 0)
		{
			if (_currentIndex != _loopFrame)
			{
				_currentWait = 0f;
				SetActiveIndex(_loopFrame);
			}
			return;
		}
		if (_currentWait > 0f)
		{
			float deltaTime2 = Time.deltaTime;
			float currentWait = _currentWait - deltaTime2;
			_currentWait = currentWait;
			return;
		}
		int num = _currentIndex + 1;
		List<GameObject> effectList = _effectList;
		if (num >= effectList._size && !_doLoop)
		{
			int index = num - 1;
			GameObject gameObject = _effectList.get_Item(index);
			Toggle(gameObject, toggle: false);
			_currentIndex = 0;
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: false);
		}
		else
		{
			SetActiveIndex(num);
			List<GameObject> effectList2 = _effectList;
			float currentWait2 = _selectedDuration / (float)effectList2._size;
			_currentWait = currentWait2;
		}
	}

	public EffectPlayer()
	{
		List<GameObject> list = default;
		list._002Ector();
		_effectList = list;
		_currentIndex = -1;
		_loopFrame = -1;
		base._002Ector();
	}
}
