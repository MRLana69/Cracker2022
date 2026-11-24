using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Components.Utilities.Examples;

public class ReallySimpleAudioSpawner : MonoBehaviour
{
	private sealed class _003CMusicSpawner_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ReallySimpleAudioSpawner _003C_003E4__this;

		private AudioSource _003Cmusic_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected Obj, but got Unknown
				//IL_00de: Expected Obj, but got I4
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fe: Expected Obj, but got Unknown
				//IL_011a: Expected Obj, but got I4
				//IL_014b: Expected I4, but got Obj
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Expected Obj, but got Unknown
				//IL_0187: Expected Obj, but got I4
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Expected Obj, but got Unknown
				//IL_01c5: Expected Obj, but got I4
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Expected Obj, but got Unknown
				//IL_0201: Expected Obj, but got I4
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Expected Obj, but got Unknown
				//IL_0258: Expected Obj, but got I4
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0273: Expected Obj, but got Unknown
				//IL_0296: Expected Obj, but got I4
				//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b6: Expected Obj, but got Unknown
				//IL_02d2: Expected Obj, but got I4
				ReallySimpleAudioSpawner reallySimpleAudioSpawner = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								if (_003C_003E1__state != 4)
								{
									if (_003C_003E1__state == 5)
									{
										_003C_003E1__state = -1;
										_003Cmusic_003E5__2.Pause();
										return null;
									}
									return null;
								}
								_003C_003E1__state = -1;
								object obj = this + 20;
								bool flag = reallySimpleAudioSpawner.pool.IsSpawned((Transform)(object)reallySimpleAudioSpawner.musicPrefab);
								obj = flag;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								_ = 2f;
								object obj2 = this + 12;
								object obj3 = default;
								obj2 = obj3;
								_003C_003E1__state = 5;
								return 1;
							}
							_003C_003E1__state = -1;
							_003Cmusic_003E5__2.Pause();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							_ = 1f;
							object obj4 = this + 12;
							object obj5 = default;
							obj4 = obj5;
							_003C_003E1__state = 4;
							return 1;
						}
						_003C_003E1__state = -1;
						object obj6 = this + 20;
						bool flag2 = reallySimpleAudioSpawner.pool.IsSpawned((Transform)(object)reallySimpleAudioSpawner.musicPrefab);
						obj6 = flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 2f;
						object obj7 = this + 12;
						object obj8 = default;
						obj7 = obj8;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					GameObject gameObject = _003Cmusic_003E5__2.gameObject;
					reallySimpleAudioSpawner.pool.RemoveAt((int)gameObject);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 1f;
					object obj9 = this + 12;
					object obj10 = default;
					obj9 = obj10;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj11 = this + 20;
				bool flag3 = reallySimpleAudioSpawner.pool.IsSpawned((Transform)(object)reallySimpleAudioSpawner.musicPrefab);
				obj11 = flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
				object obj12 = this + 12;
				object obj13 = default;
				obj12 = obj13;
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

	private sealed class _003CSpawner_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ReallySimpleAudioSpawner _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected I4, but got Unknown
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Expected I4, but got Unknown
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Expected Obj, but got Unknown
				//IL_0064: Expected VT, but got Obj
				//IL_0085: Expected VT, but got Obj
				//IL_0097: Expected I4, but got Obj
				//IL_00ae: Expected I4, but got Obj
				//IL_00dd: Expected Obj, but got I
				//IL_00dd: Expected Obj, but got I
				//IL_0106: Expected Obj, but got I4
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Expected Obj, but got Unknown
				//IL_0149: Expected Obj, but got I4
				Transform transform = default;
				bool flag = (byte)(transform + 40) != 0;
				bool flag2 = (byte)(transform + 28) != 0;
				Transform transform2 = (Transform)(transform + 16);
				ReallySimpleAudioSpawner reallySimpleAudioSpawner = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				GameObject gameObject = _003C_003E4__this.gameObject;
				transform2.position = (Vector3)gameObject;
				GameObject gameObject2 = _003C_003E4__this.gameObject;
				transform.rotation = (Quaternion)gameObject2;
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)transform2 != 0;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				((bool*)(flag ? 1 : 0))->m_value = (byte)(int)transform != 0;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.ReallySimpleAudioSpawner)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.ReallySimpleAudioSpawner)+C]");
				bool flag3 = CopyFolderUtility.CopyFilesInFolder((string)num, (string)0, flag2, flag);
				float time = ScrollRect.RubberDelta(0.7f, 1.4f);
				((AudioSource)flag3).time = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.ReallySimpleAudioSpawner)+14]");
				_ = 0;
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

	public AudioSource prefab;

	public AudioSource musicPrefab;

	public float spawnInterval;

	private SpawnPool pool;

	private void Start()
	{
		CancelInvoke();
	}

	private IEnumerator MusicSpawner()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private IEnumerator Spawner()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public ReallySimpleAudioSpawner()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		object obj = this + 24;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		IEnumerator routine = ((SimpleSpawner)this).Spawner();
		Coroutine coroutine = StartCoroutine_Auto(routine);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)musicPrefab).FindKernel((string)null) != 0)
		{
			IEnumerator routine2 = Spawner();
			Coroutine coroutine2 = StartCoroutine_Auto(routine2);
		}
	}
}
