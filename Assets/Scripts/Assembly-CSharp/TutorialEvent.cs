using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters;
using UnityEngine;

public class TutorialEvent : MonoBehaviour
{
	private sealed class _003CShowArrow_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEvent _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected VT, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected VT, but got Unknown
			//IL_011d: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I
			//IL_0164: Expected Obj, but got I
			//IL_018e: Expected Obj, but got I
			//IL_01b8: Expected Obj, but got I
			//IL_01d5: Expected Obj, but got I
			//IL_01ff: Expected Obj, but got I
			//IL_0229: Expected Obj, but got I
			//IL_0258: Expected Obj, but got I
			//IL_0275: Expected Obj, but got I
			//IL_029f: Expected Obj, but got I
			//IL_02c9: Expected Obj, but got I
			//IL_02f0: Expected F4, but got I
			//IL_02eb: Expected native int or pointer, but got VT
			//IL_030d: Expected Obj, but got I
			//IL_032a: Expected Obj, but got I
			//IL_0354: Expected Obj, but got I
			//IL_037e: Expected Obj, but got I
			//IL_03aa: Expected F4, but got I
			//IL_03a5: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 112);
			TutorialEvent tutorialEvent = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					GameObject mesh = _003C_003E4__this.mesh;
					mesh.SetActive(value: false);
				}
				return true;
			}
			_003C_003E1__state = -1;
			_ = _003C_003E4__this;
			GameObject mesh2 = _003C_003E4__this.mesh;
			Transform transform = mesh2.transform;
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			_ = 0;
			Vector3 axis = (Vector3)(quaternion + 32);
			Quaternion quaternion2 = Quaternion.AngleAxis(tutorialEvent.direction, axis);
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			_ = 0;
			_ = (float)Math.PI;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 16);
			Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			object obj2 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			object obj3 = num2 * 0;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			object obj5 = num3 * 0;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			object obj7 = num4 * 0;
			object obj8 = obj6 - obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			object obj9 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			object obj10 = num6 * 0;
			object obj11 = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			object obj12 = num7 * 0;
			object obj13 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			object obj14 = num8 * 0;
			object obj15 = obj13 - obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			object obj16 = num9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			object obj17 = num10 * 0;
			object obj18 = obj16 - obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			object obj19 = num11 * 0;
			object obj20 = obj18 - obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			object obj21 = num12 * 0;
			object obj22 = obj20 - obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			object obj23 = num13 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+6C]");
			object obj24 = num14 * 0;
			object obj25 = obj23 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			object obj26 = num15 * 0;
			object obj27 = obj25 + obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			object obj28 = num16 * 0;
			object obj29 = obj27 - obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform.rotation = quaternion;
			GameObject mesh3 = _003C_003E4__this.mesh;
			mesh3.SetActive(value: true);
			_ = 1101004800;
			_ = 0;
			throw new ArgumentException();
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

	private Game game;

	private bool displayText;

	private string text;

	private bool displayMesh;

	private float direction;

	private float time = 1f;

	private bool endTutorial;

	private bool allowHoverboard;

	private Hoverboard hoverboard;

	private Character character;

	private bool _initialized;

	private GameObject _mesh;

	private GameObject mesh
	{
		get
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected Obj, but got Unknown
			object result = this + 52;
			if (_mesh == null)
			{
				Camera main = Camera.main;
				GameObject gameObject = main.gameObject;
				Transform transform = gameObject.transform;
				Transform transform2 = transform.Find("arrow");
				GameObject gameObject2 = transform2.gameObject;
				result = gameObject2;
			}
			return (GameObject)result;
		}
	}

	private void Awake()
	{
		Game instance = Game.Instance;
		game = instance;
		Hoverboard instance2 = Hoverboard.Instance;
		hoverboard = instance2;
	}

	private void Start()
	{
		if (this.game != null && !_initialized)
		{
			Game game = this.game;
			character = game._character;
			_initialized = true;
		}
	}

	private IEnumerator ShowArrow()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnDisable()
	{
		if (_mesh != null)
		{
			_mesh.SetActive(value: false);
		}
	}

	private void OnTriggerExit(Collider collider)
	{
		Character character = this.character;
		if (character.StopColliding)
		{
			return;
		}
		GameObject gameObject = collider.gameObject;
		string text = gameObject.name;
		if (!text.Equals("Character"))
		{
			return;
		}
		if (~(displayText ? 1u : 0u) == 0)
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.QueueMessage(this.text);
		}
		if (~(displayMesh ? 1u : 0u) == 0)
		{
			IEnumerator routine = ShowArrow();
			Coroutine coroutine = StartCoroutine(routine);
		}
		if (~(allowHoverboard ? 1u : 0u) == 0)
		{
			Hoverboard hoverboard = this.hoverboard;
			hoverboard.__isAllowed = true;
		}
		if (~(endTutorial ? 1u : 0u) == 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			Game instance3 = Game.Instance;
			instance3.IsRunningOnTutorialTrack__BackingField = false;
			if (!instance2._isTutorialCompleted)
			{
				instance2._dirty = true;
				instance2._isTutorialCompleted = true;
			}
		}
	}
}
