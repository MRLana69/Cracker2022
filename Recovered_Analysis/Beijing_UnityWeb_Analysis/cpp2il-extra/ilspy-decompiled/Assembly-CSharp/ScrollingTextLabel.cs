using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Screens;
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

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0513: Unknown result type (might be due to invalid IL or missing references)
				//IL_0518: Expected I4, but got Unknown
				//IL_0521: Unknown result type (might be due to invalid IL or missing references)
				//IL_0526: Expected VT, but got Unknown
				//IL_052f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0534: Expected Obj, but got Unknown
				//IL_053d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0542: Expected Obj, but got Unknown
				//IL_054b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0550: Expected Obj, but got Unknown
				//IL_0559: Expected Obj, but got I4
				//IL_008b: Expected I, but got Obj
				//IL_00a1: Expected Obj, but got I
				//IL_00cc: Expected I, but got Obj
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Expected Obj, but got Unknown
				//IL_01c2: Invalid comparison between Obj and F4
				//IL_05f4: Expected Obj, but got I4
				//IL_05f4: Expected Obj, but got I
				//IL_060b: Expected I4, but got Obj
				//IL_060b: Expected Obj, but got I
				//IL_0614: Unknown result type (might be due to invalid IL or missing references)
				//IL_0619: Expected Obj, but got Unknown
				//IL_0626: Expected F4, but got Obj
				//IL_0621: Expected native int or pointer, but got VT
				//IL_063b: Expected F4, but got I
				//IL_0636: Expected native int or pointer, but got VT
				//IL_064d: Expected I4, but got F4
				//IL_066c: Expected Obj, but got I
				//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c8: Expected Obj, but got Unknown
				//IL_02df: Expected I, but got Obj
				//IL_02f5: Expected Obj, but got I
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Expected Obj, but got Unknown
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Expected Obj, but got Unknown
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Expected Obj, but got Unknown
				//IL_0185: Expected Obj, but got F4
				//IL_068f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0694: Expected Obj, but got Unknown
				//IL_01fe: Expected Obj, but got I
				//IL_0320: Expected I, but got Obj
				//IL_06e4: Expected Obj, but got F4
				//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ef: Expected Obj, but got Unknown
				//IL_070a: Unknown result type (might be due to invalid IL or missing references)
				//IL_070f: Expected Obj, but got Unknown
				//IL_072a: Unknown result type (might be due to invalid IL or missing references)
				//IL_072f: Expected Obj, but got Unknown
				//IL_073d: Expected I, but got Obj
				//IL_0753: Expected Obj, but got I
				//IL_023d: Expected I, but got Obj
				//IL_0253: Expected Obj, but got I
				//IL_077d: Expected F4, but got Obj
				//IL_0778: Expected native int or pointer, but got VT
				//IL_0792: Expected F4, but got I
				//IL_078d: Expected native int or pointer, but got VT
				//IL_079f: Expected I4, but got Obj
				//IL_07bd: Expected F4, but got Obj
				//IL_07bd: Expected VT, but got I4
				//IL_07ce: Expected I4, but got Obj
				//IL_07e4: Expected Obj, but got I4
				//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f3: Expected Obj, but got Unknown
				//IL_07fd: Invalid comparison between Obj and F4
				//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e8: Expected Obj, but got Unknown
				//IL_04f1: Expected Obj, but got I4
				//IL_0505: Expected Obj, but got I4
				//IL_03b1: Expected I, but got Obj
				//IL_027e: Expected I, but got Obj
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fb: Expected Obj, but got Unknown
				//IL_0436: Unknown result type (might be due to invalid IL or missing references)
				//IL_043b: Expected Obj, but got Unknown
				//IL_0448: Expected F4, but got Obj
				//IL_0443: Expected native int or pointer, but got VT
				//IL_045d: Expected F4, but got I
				//IL_0458: Expected native int or pointer, but got VT
				//IL_046a: Expected Obj, but got F4
				//IL_047d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0482: Expected Obj, but got Unknown
				//IL_04a9: Expected Obj, but got F4
				//IL_04b6: Expected I4, but got Obj
				//IL_04d8: Expected Obj, but got I
				object obj = default;
				UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 72);
				Vector3 vector = (Vector3)(obj + 56);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				object obj4 = obj + 40;
				obj4 = 0;
				_ = 0;
				ScrollingTextLabel scrollingTextLabel = _003C_003E4__this;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						goto IL_01ae;
					}
					result = null;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+10]");
					if ((nint)0 == 0)
					{
						_ = 1;
						bool flag = destroyWhenDone;
						nint num = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v93 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num2 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v110 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num3 = duration - fadeOutDuration;
						float num4 = num3 / duration;
						if (num4 < 0f)
						{
							num4 = 0f;
						}
						else if (num4 > 1f)
						{
							num4 = 1f;
						}
						_003CfadeOutAniFactorStart_003E5__2 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+C]");
						((Component)0).tag = (string)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+C]");
						((UILabel)0).fontSize = (int)text;
						object obj6 = scrollingTextLabel + 24;
						((Vector3*)(nint)vector)->x = (float)obj6;
						Vector3 vector2 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S2_v55+8]");
						((Vector3*)(nint)vector2)->z = 0f;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)vector.x;
						_ = vector.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+C]");
						((UIWidget)0).rawPivot = pivot;
						object obj7 = this + 36;
						_ = -1f;
						object obj8 = this + 48;
						_ = -1f;
						object obj9 = this - -64;
						obj9 = 0f;
						goto IL_01ae;
					}
					result = null;
				}
				goto IL_0671;
				IL_0671:
				return result;
				IL_01ae:
				object obj10 = this - -64;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+C]");
					((Component)0).tag = null;
					_ = 0;
					bool flag2 = (byte)(~(destroyWhenDone ? 1u : 0u)) != 0;
					result = null;
					if (!flag2)
					{
						string tag = scrollingTextLabel.tag;
						nint num5 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v85 (Il2CppClass<NGUITools>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num6 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v90 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUITools.DestroyChildren((Transform)(object)tag);
						result = null;
					}
				}
				else
				{
					object obj12 = this - -64;
					float unscaledTime = Time.unscaledTime;
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v38 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num8 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v70 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj14 = this - -64;
					float num9 = unscaledTime / duration;
					float num10 = (float)obj12 + num9;
					if (num10 < 0f)
					{
						num10 = 0f;
					}
					else if (num10 > 1f)
					{
						num10 = 1f;
					}
					obj14 = num10;
					object obj15 = this + 36;
					obj2 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S2_v8+8]");
					_ = 0;
					object obj16 = this + 48;
					obj3 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S2_v13+8]");
					_ = 0;
					object obj17 = this - -64;
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num12 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v69 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector3 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector3)->z = 0f;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					Vector3 vector4 = Vector3.LerpUnclamped(vector, (Vector3)pivot, (float)obj17);
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Vector3 eulerAngles = ((Transform)pivot).eulerAngles;
					object obj19 = this - -64;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_003CfadeOutAniFactorStart_003E5__2))
					{
						object obj20 = this - -64;
						float num13 = (float)obj20 - _003CfadeOutAniFactorStart_003E5__2;
						float num14 = 1f - _003CfadeOutAniFactorStart_003E5__2;
						float num15 = num13 / num14;
						object obj21 = scrollingTextLabel + 24;
						((Vector3*)(nint)vector)->x = (float)obj21;
						Vector3 vector5 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v55+8]");
						((Vector3*)(nint)vector5)->z = 0f;
						obj4 = vector.x;
						_ = vector.z;
						object obj22 = obj4 + 12;
						float num16 = 1f - num15;
						float num17 = (float)obj22 * num16;
						obj22 = num17;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (ScrollingTextLabel)+C]");
						((UIWidget)0).rawPivot = pivot;
					}
					object obj23 = this + 12;
					obj23 = 0;
					_003C_003E1__state = 1;
					result = 1;
				}
				goto IL_0671;
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

	private UILabel label;

	private bool _isScrolling = false;

	private Transform _labelTransform;

	private Color _labelBaseColor;

	private bool _destroyOnDisable;

	private void OnEnable()
	{
		((UpgradeScreen)this).Start();
	}

	private void OnDisable()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		label.tag = null;
		object obj = this + 20;
		GameObject gameObject = label.gameObject;
		obj = gameObject;
		object obj2 = label + 80;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v10+8]");
		_ = 0;
		object obj4 = obj3 + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 24;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15+8]");
		_ = 0;
		if (~(_destroyOnDisable ? 1u : 0u) != 0)
		{
			return;
		}
		string t = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v27 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v32 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyChildren((Transform)(object)t);
	}

	public void StartScrolling(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private IEnumerator StartScrollingCoroutine(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}
}
