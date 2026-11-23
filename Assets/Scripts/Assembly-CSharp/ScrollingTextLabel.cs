using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class ScrollingTextLabel : MonoBehaviour
{
	private sealed class _003CStartScrollingCoroutine_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollingTextLabel _003C_003E4__this;

		public bool destroyWhenDone;

		public float duration;

		public float fadeOutDuration;

		public string text;

		public Vector3 startLocalPos;

		public Vector3 endLocalPos;

		private float _003CfadeOutAniFactorStart_003E5__2;

		private float _003CaniFactor_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02e8: Expected Obj, but got I
			//IL_02f8: Expected Obj, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected Obj, but got Unknown
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected Obj, but got Unknown
			//IL_010e: Expected Obj, but got I
			//IL_0381: Expected Obj, but got VT
			//IL_03d0: Expected Obj, but got I
			//IL_0413: Expected Obj, but got I
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Expected VT, but got Unknown
			//IL_0485: Expected Obj, but got I
			//IL_0273: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 96;
			ScrollingTextLabel scrollingTextLabel = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003CaniFactor_003E5__3 < 1f)
					{
						goto IL_014d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+C]");
					((Behaviour)0).enabled = false;
					_ = 0;
					if (~(destroyWhenDone ? 1u : 0u) == 0)
					{
						GameObject gameObject = scrollingTextLabel.gameObject;
						NGUITools.Destroy(gameObject);
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+10]");
				if ((nint)0 == 0)
				{
					_ = 1;
					_ = destroyWhenDone;
					float num = duration - fadeOutDuration;
					float num2 = num / duration;
					float num3 = Math.Min(num2, 1f);
					bool flag = num2 < 0f;
					float num4 = 0f;
					if (!flag)
					{
						num4 = num3;
					}
					_003CfadeOutAniFactorStart_003E5__2 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+C]");
					((Behaviour)0).enabled = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+C]");
					object obj3 = 0;
					object obj4 = obj3;
					object obj5 = obj3 + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v29+2CC] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+18]");
					_ = 0;
					object obj6 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
					_003CaniFactor_003E5__3 = 0f;
					_ = -1082130432;
					_ = -1082130432;
					goto IL_014d;
				}
			}
			goto IL_02c2;
			IL_014d:
			float deltaTime = Time.deltaTime;
			float num5 = deltaTime / duration;
			float num6 = _003CaniFactor_003E5__3 + num5;
			float num7 = Math.Min(num6, 1f);
			bool flag2 = num6 < 0f;
			float num8 = 0f;
			if (!flag2)
			{
				num8 = num7;
			}
			_003CaniFactor_003E5__3 = num8;
			object obj7 = endLocalPos - startLocalPos;
			float num9 = Math.Max(num8, 0f);
			float num10 = (float)obj7 * num9;
			float num11 = (float)startLocalPos + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+34]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+28]");
			object obj8 = num12 - 0;
			float num13 = (float)obj8 * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+28]");
			float num14 = 0f + num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+38]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+2C]");
			object obj9 = num15 - 0;
			float num16 = (float)obj9 * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScrollingTextLabel+<StartScrollingCoroutine>d__8)+2C]");
			float num17 = 0f + num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Vector3 localPosition = (Vector3)(obj + 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+14]");
			((Transform)0).localPosition = localPosition;
			if (!(_003CaniFactor_003E5__3 < _003CfadeOutAniFactorStart_003E5__2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+18]");
				_ = 0;
				float num18 = _003CaniFactor_003E5__3 - _003CfadeOutAniFactorStart_003E5__2;
				float num19 = 1f - _003CfadeOutAniFactorStart_003E5__2;
				float num20 = num18 / num19;
				float num21 = 1f - num20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (ScrollingTextLabel)+24]");
				float num22 = 0f * num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_02c2;
			IL_02c2:
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

	private TMP_Text label;

	private bool _isScrolling;

	private Transform _labelTransform;

	private Color _labelBaseColor;

	private bool _destroyOnDisable;

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006c: Expected I, but got Obj
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00ad: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		label.enabled = false;
		Transform labelTransform = label.transform;
		_labelTransform = labelTransform;
		TMP_Text tMP_Text = label;
		nint num = (nint)tMP_Text;
		object obj3 = tMP_Text + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+16C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_labelBaseColor = (Color)obj;
		if (~(_destroyOnDisable ? 1u : 0u) == 0)
		{
			GameObject obj4 = gameObject;
			NGUITools.Destroy(obj4);
		}
	}

	private void OnDisable()
	{
		_isScrolling = false;
	}

	public unsafe void StartScrolling(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0044: Expected native int or pointer, but got VT
		//IL_0056: Expected native int or pointer, but got VT
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (duration > 0f && !_isScrolling)
		{
			_ = startLocalPos.z;
			_ = startLocalPos.x;
			((Vector3*)(nint)vector)->z = endLocalPos.z;
			((Vector3*)(nint)vector)->x = endLocalPos.x;
			Vector3 startLocalPos2 = vector + 16;
			IEnumerator routine = StartScrollingCoroutine(text, startLocalPos2, vector, duration, fadeOutDuration, destroyWhenDone);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator StartScrollingCoroutine(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone)
	{
		_ = 0;
		_ = startLocalPos.z;
		_ = startLocalPos.x;
		_ = endLocalPos.x;
		_ = endLocalPos.z;
		IEnumerator result = default;
		return result;
	}
}
