using System;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class AnimationEventBroadcaster : MonoBehaviour
{
	public delegate void SendDoKeyframeAnimationDelegate(int soundIndex);

	public delegate void SendPlayKeyframeAnimationDelegate(int soundIndex);

	public delegate void SendSetAnimationSpeedEventDelegate(AnimationEvent animEvent);

	private SendDoKeyframeAnimationDelegate m_SendDoKeyframeAnimation;

	private SendPlayKeyframeAnimationDelegate m_SendPlayKeyframeAnimation;

	private SendSetAnimationSpeedEventDelegate m_SendSetAnimationSpeedEvent;

	public event SendDoKeyframeAnimationDelegate SendDoKeyframeAnimation
	{
		add
		{
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Expected Obj, but got Unknown
			//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Expected Obj, but got Unknown
			//IL_0573: Expected I, but got Obj
			//IL_0589: Expected Obj, but got I
			//IL_026e: Expected I, but got Obj
			//IL_0284: Expected Obj, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_0337: Expected Obj, but got I
			//IL_04f0: Expected I, but got Obj
			//IL_0506: Expected Obj, but got I
			//IL_0037: Expected I, but got Obj
			//IL_004d: Expected Obj, but got I
			//IL_0434: Expected I, but got Obj
			//IL_02af: Expected I, but got Obj
			//IL_05df: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_04d8: Expected Obj, but got I
			//IL_0370: Expected Obj, but got I
			//IL_01fd: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_0139: Expected Obj, but got I
			//IL_03a6: Expected I, but got Obj
			//IL_03bc: Expected Obj, but got I
			//IL_016f: Expected I, but got Obj
			//IL_0185: Expected Obj, but got I
			//IL_03e7: Expected I, but got Obj
			//IL_053e: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			object obj = this - -64;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+54]");
			bool flag = (nint)0 != 0;
			if (value != null)
			{
				if (!flag)
				{
					nint num = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v118 (Il2CppClass<So>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num2 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v126 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					So instance = So.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+38]");
					HoverboardBundle hoverboardBundle = ((CharacterModel)(object)instance).AddHoverboard((string)0, false);
					return;
				}
				object obj4 = this - -64;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v76+26]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+4C]");
					if (!((Game)0).HasSuperSneakers)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+4C]");
						if (!((Game)0).IsInPogostickMode)
						{
							nint num3 = (nint)typeof(So);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v103 (Il2CppClass<So>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(So);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v111 (Il2CppClass<So>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							So instance2 = So.Instance;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+3C]");
							HoverboardBundle hoverboardBundle2 = ((CharacterModel)(object)instance2).AddHoverboard((string)0, false);
							return;
						}
					}
				}
				nint num5 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v80 (Il2CppClass<So>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v88 (Il2CppClass<So>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				So instance3 = So.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+18]");
				HoverboardBundle hoverboardBundle3 = ((CharacterModel)(object)instance3).AddHoverboard((string)0, false);
				return;
			}
			if (!flag)
			{
				nint num7 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v58 (Il2CppClass<So>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v66 (Il2CppClass<So>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardBundle hoverboardBundle4 = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)this.m_SendDoKeyframeAnimation, false);
				return;
			}
			object obj9 = this - -64;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v16+26]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+4C]");
				if (!((Game)0).HasSuperSneakers)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimationEventBroadcaster)+4C]");
					if (!((Game)0).IsInPogostickMode)
					{
						nint num9 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v43 (Il2CppClass<So>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num10 = (nint)typeof(So);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v51 (Il2CppClass<So>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						HoverboardBundle hoverboardBundle5 = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)this.m_SendPlayKeyframeAnimation, false);
						return;
					}
				}
			}
			nint num11 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v20 (Il2CppClass<So>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num12 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v28 (Il2CppClass<So>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardBundle hoverboardBundle6 = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)this.m_SendSetAnimationSpeedEvent, false);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_SendDoKeyframeAnimation;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public event SendPlayKeyframeAnimationDelegate SendPlayKeyframeAnimation
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_SendDoKeyframeAnimation;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_SendPlayKeyframeAnimation;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public event SendSetAnimationSpeedEventDelegate SendSetAnimationSpeedEvent
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_SendPlayKeyframeAnimation;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_SendSetAnimationSpeedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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

	private void DoKeyframeAnimation(int soundIndex)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_SendSetAnimationSpeedEvent;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)soundIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 20;
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

	private void PlayKeyframeAnimation(int soundIndex)
	{
		//IL_002e: Expected Obj, but got I4
		if (this.m_SendDoKeyframeAnimation != null)
		{
			this.m_SendDoKeyframeAnimation.EndInvoke((IAsyncResult)soundIndex);
		}
	}

	private void SetAnimationSpeedEvent(AnimationEvent animEvent)
	{
		if (this.m_SendPlayKeyframeAnimation != null)
		{
			this.m_SendPlayKeyframeAnimation.EndInvoke((IAsyncResult)(object)animEvent);
		}
	}

	public AnimationEventBroadcaster()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		_ = 8f;
		_ = 16f;
		_ = 4f;
		_ = 10f;
		_ = 4f;
		_ = 0.3f;
		_ = 0.6f;
		_ = 0.2f;
		CancelInvoke();
	}
}
