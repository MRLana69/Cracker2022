using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class AvatarAnimations : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public AnimationClip selectedClip;

		public Predicate<AnimationClip> _003C_003E9__0;

		public Predicate<AnimationClip> _003C_003E9__1;

		internal bool _003CPlay_003Eb__0(AnimationClip a)
		{
			return a != selectedClip;
		}

		internal bool _003CPlay_003Eb__1(AnimationClip a)
		{
			return a != selectedClip;
		}
	}

	private sealed class _003CPlay_003Ed__35(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarAnimations _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private int _003Ccount_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_018b: Expected Obj, but got I4
			//IL_0157: Expected Obj, but got I4
			//IL_017d: Expected Obj, but got I4
			//IL_0508: Expected Obj, but got I4
			//IL_053c: Expected Obj, but got I4
			//IL_0525: Expected Obj, but got I4
			AvatarAnimations avatarAnimations = _003C_003E4__this;
			float num = default;
			object obj;
			float num2 = default;
			float num3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_062a;
						}
						_003C_003E1__state = -1;
						num = avatarAnimations.nextAnimationTime;
						obj = 1;
					}
					else
					{
						_003C_003E1__state = -1;
						num2 = avatarAnimations.nextAnimationTime;
						obj = 0;
					}
					goto IL_064d;
				}
				_003C_003E1__state = -1;
				num3 = avatarAnimations.nextAnimationTime;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass35_0 obj2 = default;
				_003C_003E8__1 = obj2;
				_003C_003Ec__DisplayClass35_0 obj3 = _003C_003E8__1;
				obj3.selectedClip = null;
				if (~(avatarAnimations.useStartClip ? 1u : 0u) != 0)
				{
					goto IL_0182;
				}
				string name = avatarAnimations.startClip.name;
				bool flag = avatarAnimations._target.Play(name);
				num3 = (avatarAnimations.nextAnimationTime = avatarAnimations.startClip.length);
			}
			if (!(num3 > 0f))
			{
				avatarAnimations.useStartClip = false;
				goto IL_0182;
			}
			float deltaTime = Time.deltaTime;
			float nextAnimationTime = num3 - deltaTime;
			avatarAnimations.nextAnimationTime = nextAnimationTime;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_062a:
			return false;
			IL_064d:
			object obj4 = obj;
			List<AnimationClip> list3 = default;
			while (true)
			{
				bool flag2;
				if (obj4 != null)
				{
					if ((nint)obj4 == 1)
					{
						if (!(num > 0f))
						{
							flag2 = ++_003Ci_003E5__3 < _003Ccount_003E5__2;
							goto IL_065a;
						}
						float deltaTime2 = Time.deltaTime;
						float nextAnimationTime2 = num - deltaTime2;
						avatarAnimations.nextAnimationTime = nextAnimationTime2;
						_003C_003E2__current = null;
						_003C_003E1__state = 3;
						return true;
					}
					if (~(avatarAnimations.PlayIdleAnimations ? 1u : 0u) != 0)
					{
						break;
					}
					List<AnimationClip> list2;
					if (~(avatarAnimations.usePopupIdles ? 1u : 0u) != 0)
					{
						if (avatarAnimations.Idles != null)
						{
							_003C_003Ec__DisplayClass35_0 obj5 = _003C_003E8__1;
							bool flag3 = obj5._003C_003E9__1 == null;
							bool flag4 = !flag3;
							Predicate<AnimationClip> match = obj5._003C_003E9__1;
							if (!flag4)
							{
								throw new ArgumentException();
							}
							List<AnimationClip> list = avatarAnimations.Idles.FindAll(match);
							list2 = list;
						}
						else
						{
							list3._002Ector();
							list2 = list3;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass35_0 obj6 = _003C_003E8__1;
						bool flag5 = obj6._003C_003E9__0 == null;
						bool flag6 = !flag5;
						Predicate<AnimationClip> match2 = obj6._003C_003E9__0;
						if (!flag6)
						{
							throw new ArgumentException();
						}
						List<AnimationClip> list4 = avatarAnimations.IdlesPopup.FindAll(match2);
						list2 = list4;
					}
					if (list2._size >= 1)
					{
						_003C_003Ec__DisplayClass35_0 obj7 = _003C_003E8__1;
						int index = UnityEngine.Random.Range(0, list2._size);
						AnimationClip selectedClip = list2.get_Item(index);
						obj7.selectedClip = selectedClip;
					}
					_003C_003Ec__DisplayClass35_0 obj8 = _003C_003E8__1;
					if (obj8.selectedClip != null)
					{
						_003C_003Ec__DisplayClass35_0 obj9 = _003C_003E8__1;
						string name2 = obj9.selectedClip.name;
						bool flag7 = avatarAnimations._target.Play(name2);
						_003C_003Ec__DisplayClass35_0 obj10 = _003C_003E8__1;
						float num4 = (avatarAnimations.nextAnimationTime = obj10.selectedClip.length);
						obj4 = 0;
						num2 = num4;
						continue;
					}
				}
				else if (num2 > 0f)
				{
					float deltaTime3 = Time.deltaTime;
					float nextAnimationTime3 = num2 - deltaTime3;
					avatarAnimations.nextAnimationTime = nextAnimationTime3;
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				if (avatarAnimations.usePopupIdles)
				{
					goto IL_04ff;
				}
				int num5 = UnityEngine.Random.Range(avatarAnimations.MinIdleTimes, avatarAnimations.MaxIdleTimes);
				_003Ci_003E5__3 = 0;
				_003Ccount_003E5__2 = num5;
				flag2 = num5 > 0;
				goto IL_065a;
				IL_04ff:
				obj4 = 2;
				continue;
				IL_065a:
				if (flag2)
				{
					if (avatarAnimations._target != null)
					{
						string name3 = avatarAnimations._breath.name;
						bool flag8 = avatarAnimations._target.Play(name3);
					}
					float num6 = (avatarAnimations.nextAnimationTime = avatarAnimations._breath.length);
					obj4 = 1;
					num = num6;
					continue;
				}
				goto IL_04ff;
			}
			avatarAnimations.animationRoutine = null;
			goto IL_062a;
			IL_0182:
			obj = 2;
			goto IL_064d;
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

	private SkinnedMeshRenderer _head;

	private Transform _blendshapeController;

	private Animation _target;

	private List<AnimationClip> IdlesPopup;

	public bool Paused;

	public bool PlayIdleAnimations;

	private AnimationClip startClip;

	private List<AnimationClip> Idles;

	private AnimationClip _breath;

	private CharacterAssetsBundle currentCharacterBundle;

	private bool usePopupIdles;

	private bool useStartClip;

	private IEnumerator animationRoutine;

	private float nextAnimationTime;

	private int _blendshapeCount;

	private int MinIdleTimes = 2;

	private int MaxIdleTimes;

	private CharacterIdlesBundle _idlesBundle;

	public SkinnedMeshRenderer Head
	{
		set
		{
			_head = value;
		}
	}

	public Transform BlendshapeController
	{
		set
		{
			_blendshapeController = value;
		}
	}

	public Animation Target
	{
		set
		{
			_target = value;
		}
	}

	public void Initialize(CharacterAssetsBundle characterAssetsBundle)
	{
		_breath = characterAssetsBundle.Breath;
		currentCharacterBundle = characterAssetsBundle;
		if (~(PlayIdleAnimations ? 1u : 0u) == 0)
		{
			if (~(usePopupIdles ? 1u : 0u) == 0)
			{
				StartIdlePopupAnimations();
			}
			else
			{
				StartIdleAnimations();
			}
		}
		Mesh sharedMesh = _head.sharedMesh;
		bool flag = sharedMesh != null;
		bool flag2 = !flag;
		int blendshapeCount = 0;
		if (!flag2)
		{
			bool flag3 = _head.enabled;
			bool flag4 = !flag3;
			blendshapeCount = 0;
			if (!flag4)
			{
				Mesh sharedMesh2 = _head.sharedMesh;
				blendshapeCount = sharedMesh2.blendShapeCount;
			}
		}
		_blendshapeCount = blendshapeCount;
	}

	private Animation FindAnimationInParent(GameObject current)
	{
		GameObject gameObject = default;
		Animation result;
		while (true)
		{
			Animation component = gameObject.GetComponent<Animation>();
			bool flag = component == null;
			result = component;
			if (!flag)
			{
				break;
			}
			Transform transform = gameObject.transform;
			Transform parent = transform.parent;
			bool flag2 = parent != null;
			bool flag3 = !flag2;
			result = null;
			if (flag3)
			{
				break;
			}
			Transform transform2 = gameObject.transform;
			Transform parent2 = transform2.parent;
			gameObject = parent2.gameObject;
		}
		return result;
	}

	public static float NormalizeBlendShape(float value)
	{
		float num = Math.Abs(value);
		float num2 = Math.Min(num, 1f);
		bool flag = num < 0.1f;
		float result = 0f;
		if (!flag)
		{
			result = num2;
		}
		return result;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008b: Expected F4, but got I
		//IL_00f9: Expected F4, but got I
		//IL_015f: Expected F4, but got Obj
		//IL_01cd: Expected F4, but got I
		//IL_023b: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(PlayIdleAnimations ? 1u : 0u) != 0 || animationRoutine == null || Paused)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		if (_blendshapeCount < 2)
		{
			return;
		}
		Vector3 localPosition = _blendshapeController.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num = Math.Abs(0f);
		float num2 = Math.Min(num, 1f);
		bool flag = num < 0.1f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		float value = num3 * 100f;
		_head.SetBlendShapeWeight(1, value);
		if (_blendshapeCount < 3)
		{
			return;
		}
		Vector3 localPosition2 = _blendshapeController.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num4 = Math.Abs(0f);
		float num5 = Math.Min(num4, 1f);
		bool flag2 = num4 < 0.1f;
		float num6 = 0f;
		if (!flag2)
		{
			num6 = num5;
		}
		float value2 = num6 * 100f;
		_head.SetBlendShapeWeight(2, value2);
		if (_blendshapeCount < 4)
		{
			return;
		}
		Quaternion localRotation = _blendshapeController.localRotation;
		float num7 = Math.Abs((float)obj);
		float num8 = Math.Min(num7, 1f);
		bool flag3 = num7 < 0.1f;
		float num9 = 0f;
		if (!flag3)
		{
			num9 = num8;
		}
		float value3 = num9 * 100f;
		_head.SetBlendShapeWeight(3, value3);
		if (_blendshapeCount < 5)
		{
			return;
		}
		Quaternion localRotation2 = _blendshapeController.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num10 = Math.Abs(0f);
		float num11 = Math.Min(num10, 1f);
		bool flag4 = num10 < 0.1f;
		float num12 = 0f;
		if (!flag4)
		{
			num12 = num11;
		}
		float value4 = num12 * 100f;
		_head.SetBlendShapeWeight(4, value4);
		if (_blendshapeCount >= 6)
		{
			Quaternion localRotation3 = _blendshapeController.localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num13 = Math.Abs(0f);
			float num14 = Math.Min(num13, 1f);
			bool flag5 = num13 < 0.1f;
			float num15 = 0f;
			if (!flag5)
			{
				num15 = num14;
			}
			float value5 = num15 * 100f;
			_head.SetBlendShapeWeight(5, value5);
		}
	}

	private void OnDestroy()
	{
		ClearBundleAnimation();
	}

	private void ClearBundleAnimation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (!(_idlesBundle != null))
		{
			return;
		}
		if (startClip != null)
		{
			string text = startClip.name;
			AnimationClip clip = _target.GetClip(text);
			if (clip != null)
			{
				string clipName = startClip.name;
				_target.RemoveClip(clipName);
			}
		}
		startClip = null;
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
		object obj7 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_03e2;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj7 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
								goto IL_0353;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_0353;
			IL_03e2:
			object obj8 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
			Idles = null;
			GameObject obj9 = _idlesBundle.gameObject;
			UnityEngine.Object.Destroy(obj9);
			return;
			IL_0353:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 != obj11;
			object obj12 = obj13;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_03e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj12 = obj14;
			break;
		}
		_ = 0;
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void StartIdleAnimations()
	{
		//IL_0050: Expected VT, but got Obj
		ClearBundleAnimation();
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		string text = currentCharacterBundle.name;
		string text2 = text + "_idles";
		throw new ArgumentException();
	}

	public void StartIdlePopupAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		usePopupIdles = true;
		Paused = false;
		string newName = _breath.name;
		_target.AddClip(_breath, newName);
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
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		AvatarAnimations avatarAnimations = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			avatarAnimations = (AvatarAnimations)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		IEnumerator enumerator = ((AvatarAnimations)0).Play();
		avatarAnimations.animationRoutine = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	public void StopIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0570: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		animationRoutine = null;
		PlayIdleAnimations = false;
		object obj3 = 24;
		if (!usePopupIdles)
		{
			obj3 = 36;
		}
		object obj4 = (object)this + obj3;
		if (obj4 == null)
		{
			return;
		}
		object obj5 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj6 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj8 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		while (true)
		{
			_ = 0;
			object obj7 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj15;
			object obj16;
			if ((nint)0 != 1)
			{
				if (obj8 == null)
				{
					goto IL_04a3;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj9 = obj + 40;
						object obj10 = obj + 44;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						while (true)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								break;
							}
							if (obj11 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								if (obj12 != null)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
								}
								continue;
							}
							goto IL_039d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag = obj13 != obj14;
						obj15 = obj13;
						obj16 = obj17;
						if (!flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_039d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj15 = obj18;
							obj16 = obj19;
						}
						_ = 0;
						object obj20 = obj + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						goto IL_0670;
					}
				}
			}
			goto IL_0426;
			IL_04a3:
			object obj21 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
			return;
			IL_0426:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj15 = obj22;
			obj16 = obj23;
			goto IL_0670;
			IL_0670:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj24 == obj15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_04a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj16 = obj25;
			}
			_ = 0;
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			break;
			IL_039d:
			_ = 0;
			object obj27 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			goto IL_0426;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void PauseIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Paused = true;
		IEnumerator enumerator = _target.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
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
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = obj10;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
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
			obj6 = 0;
			break;
		}
		object obj13 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public void ResumeIdleAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Paused = false;
		IEnumerator enumerator = _target.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
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
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = obj10;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
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
			obj6 = 0;
			break;
		}
		object obj13 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	private IEnumerator Play()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public AvatarAnimations()
	{
		//IL_000f: Expected I4, but got I8
	}

	private void _003CStartIdleAnimations_003Eb__30_0(CharacterIdlesBundle idlesBundle)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (!(idlesBundle != null))
		{
			goto IL_03b5;
		}
		_idlesBundle = idlesBundle;
		CharacterIdlesBundle idlesBundle2 = _idlesBundle;
		startClip = idlesBundle2.startClip;
		CharacterIdlesBundle idlesBundle3 = _idlesBundle;
		Idles = idlesBundle3.Idles;
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (currentPopupName == "CelebrationPopup")
		{
			int num = 0;
			while (true)
			{
				CharacterIdlesBundle idlesBundle4 = _idlesBundle;
				List<AnimationClip> excludedCelebrationIdles = idlesBundle4.ExcludedCelebrationIdles;
				if (num >= excludedCelebrationIdles._size)
				{
					break;
				}
				CharacterIdlesBundle idlesBundle5 = _idlesBundle;
				AnimationClip item = idlesBundle5.ExcludedCelebrationIdles.get_Item(num);
				if (Idles.Contains(item))
				{
					CharacterIdlesBundle idlesBundle6 = _idlesBundle;
					AnimationClip item2 = idlesBundle6.ExcludedCelebrationIdles.get_Item(num);
					bool flag = Idles.Remove(item2);
				}
				if (startClip != null)
				{
					CharacterIdlesBundle idlesBundle7 = _idlesBundle;
					AnimationClip animationClip = idlesBundle7.ExcludedCelebrationIdles.get_Item(num);
					if (startClip == animationClip)
					{
						startClip = null;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		usePopupIdles = false;
		Paused = false;
		if (startClip != null)
		{
			useStartClip = true;
			string newName = startClip.name;
			_target.AddClip(startClip, newName);
		}
		else
		{
			useStartClip = false;
		}
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
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj7 != obj8;
			object obj9 = obj10;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0398;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		goto IL_0402;
		IL_0402:
		string newName2 = _breath.name;
		_target.AddClip(_breath, newName2);
		IEnumerator enumerator = Play();
		animationRoutine = enumerator;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		return;
		IL_03b5:
		_idlesBundle = null;
		startClip = null;
		Idles = null;
		usePopupIdles = false;
		Paused = false;
		goto IL_0402;
		IL_0398:
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD0");
		goto IL_03b5;
	}
}
