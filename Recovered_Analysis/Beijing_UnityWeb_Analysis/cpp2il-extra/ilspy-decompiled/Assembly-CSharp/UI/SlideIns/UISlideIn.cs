using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Extensions;
using Kiloo.Common.UI;
using SYBO.Components.Utilities;
using UI.Screens.RewardManagement;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideIn : MonoBehaviour
{
	private sealed class _003CInvokeDidShowCallback_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public UISlideIn _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dc: Expected Obj, but got Unknown
				//IL_00e5: Expected Obj, but got I4
				//IL_00f9: Expected Obj, but got I4
				UISlideIn uISlideIn = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003CstartPoint_003E5__2 = 0f;
				}
				if (_003CstartPoint_003E5__2 < waitTime)
				{
					float aspectRatio = Utils.GetAspectRatio();
					float num = _003CstartPoint_003E5__2 + aspectRatio;
					_003CstartPoint_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				TransformExtensions.Reset((Transform)(object)uISlideIn.m_onDidShowCallback);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CInvokeDidShowCallback_003Ed__13(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
		}

		void IDisposable.Dispose()
		{
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

	private sealed class _003CPreloadSlideIn_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISlideIn _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_008a: Expected Obj, but got I4
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Expected Obj, but got Unknown
				//IL_00a3: Expected Obj, but got I4
				//IL_00b7: Expected Obj, but got I4
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Expected Obj, but got Unknown
				//IL_00db: Expected Obj, but got I4
				//IL_00ef: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							string tag = _003C_003E4__this.tag;
							((GameObject)(object)tag).tag = null;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				string tag2 = _003C_003E4__this.tag;
				((GameObject)(object)tag2).tag = (string)1;
				object obj2 = this + 12;
				obj2 = 0;
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

	private UIWidget _darkBackground;

	private Vector3 posOff;

	private Vector3 posOn;

	private bool _triggerSlideOut;

	private float _slideOutTimer;

	private bool _triggerReadyForNext;

	private float _readyForNextTimer;

	private Action m_onDidShowCallback;

	private event Action onDidShowCallback
	{
		add
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected Obj, but got Unknown
			//IL_0194: Expected I4, but got Obj
			//IL_0194: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0150: Expected Obj, but got VT
			//IL_0054: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			bool flag = ((VideoAdPrizeManager)(object)this).HasVideoAdPrizeIndexChanged();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Boolean)+8]");
			if ((nint)0 == 6)
			{
				nint num = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v27 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v34 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime lastDailyOnlineLog = UserSave.lastDailyOnlineLog;
				obj2 = lastDailyOnlineLog;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9375");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Boolean)+8]");
				if ((nint)0 != 6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.Boolean)+8]");
					if ((nint)0 != 0)
					{
						((VideoAdPrizeManager)(object)this).ResetRandomPrizePoolIfAllPrizesTaken();
					}
				}
			}
			Cooldowns cooldowns = AdsSave.cooldowns;
			Cooldowns cooldowns2 = (Cooldowns)(cooldowns + 1);
			AdsSave.cooldowns = cooldowns2;
			((VideoAdPrizeManager)flag).GiveReward((UnlockItemSource)value);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onDidShowCallback;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public virtual void SetupSlideIn(SlideIn slideIn)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onDidShowCallback;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)slideIn);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 56;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	protected void Start()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	protected void SlideIn(Action onDidShowCallback = null)
	{
	}

	private IEnumerator InvokeDidShowCallback(float waitTime)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IEnumerator)TweenColor.Begin((GameObject)(object)this, waitTime, (Color)0);
	}

	protected virtual void SlideOut()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = this + 16;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		string text = tag;
		((GameObject)(object)text).tag = null;
	}

	protected virtual void ReadyForNewMessage()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		string text = tag;
		object obj = this + 16;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
		_ = 1;
		_triggerReadyForNext = true;
	}

	private void Update()
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = null;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v14 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ShowSlideIn();
	}

	public IEnumerator PreloadSlideIn()
	{
		//IL_001c: Expected Obj, but got I
		IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideIn)+18]");
		return (IEnumerator)((List<VideoAdPrize>)(nint)cachedPtr).get_Item(0);
	}

	public UISlideIn()
	{
		if (!_triggerReadyForNext && !_triggerSlideOut)
		{
			return;
		}
		float aspectRatio = Utils.GetAspectRatio();
		if (~(_triggerSlideOut ? 1u : 0u) == 0)
		{
			float slideOutTimer = _slideOutTimer - aspectRatio;
			_slideOutTimer = slideOutTimer;
			if (!(_slideOutTimer > 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				_triggerSlideOut = false;
			}
		}
		if (~(_triggerReadyForNext ? 1u : 0u) == 0)
		{
			float readyForNextTimer = _readyForNextTimer - aspectRatio;
			_readyForNextTimer = readyForNextTimer;
			if (!(_readyForNextTimer > 0f))
			{
				_triggerReadyForNext = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}
}
