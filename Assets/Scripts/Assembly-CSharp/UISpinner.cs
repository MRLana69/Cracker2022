using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UISpinner : MonoBehaviour
{
	private Image _sprite;

	private float _speed;

	private bool _rotateClockWise;

	private bool _startManually;

	private bool _callStartSpinning;

	private bool _callStopSpinning;

	private bool _shouldRotate;

	private float _deltaTime;

	public bool IsAnimating => _shouldRotate;

	private void OnEnable()
	{
		if (~(_startManually ? 1u : 0u) != 0)
		{
			StartSpinning();
		}
	}

	private void Awake()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		if (_sprite == null)
		{
			Image component = GetComponent<Image>();
			if (component != null)
			{
				object obj = this + 12;
				obj = component;
			}
		}
		if (~(_startManually ? 1u : 0u) == 0)
		{
			StopSpinning();
		}
		else
		{
			StartSpinning();
		}
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a3: Expected I, but got Obj
		//IL_00c8: Expected F4, but got I
		//IL_00c3: Expected native int or pointer, but got VT
		//IL_00d6: Expected F4, but got VT
		//IL_00d1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(_shouldRotate ? 1u : 0u) == 0)
		{
			float num = (_deltaTime = RealTimeTracker.deltaTime);
			float num2 = 0f - num;
			float num3 = num;
			if (!_rotateClockWise)
			{
				num3 = num2;
			}
			float angle = num3 * _speed;
			Transform transform = _sprite.transform;
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.backVector;
			transform.Rotate(vector, angle);
		}
	}

	public void StartSpinning()
	{
		_sprite.enabled = true;
		_shouldRotate = true;
	}

	public void StopSpinning()
	{
		_sprite.enabled = false;
		_shouldRotate = false;
	}
}
