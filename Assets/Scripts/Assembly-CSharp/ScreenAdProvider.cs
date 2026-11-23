using System;
using Cpp2ILInjected;

public abstract class ScreenAdProvider
{
	private Action<ScreenAdProvider> m_onDidCacheInterstitial;

	private Action<ScreenAdProvider> m_onDidFailToLoadInterstitial;

	private Action<ScreenAdProvider> m_onDidDismissInterstitial;

	private Action<ScreenAdProvider> m_onDidShowInterstitial;

	private Action<ScreenAdProvider> m_onDidFailToShowInterstitial;

	private Action<ScreenAdProvider> m_onDidClickInterstitial;

	public abstract bool isInitialized { get; }

	public abstract bool HasCachedInterstials { get; }

	public abstract bool isScreenAdProviderSupported { get; }

	public abstract string id { get; }

	public abstract bool allowedWhenAgeRestricted { get; }

	public event Action<ScreenAdProvider> onDidCacheInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 8;
			Delegate obj2 = this.m_onDidCacheInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 8;
			Delegate obj2 = this.m_onDidCacheInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ScreenAdProvider> onDidFailToLoadInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onDidFailToLoadInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onDidFailToLoadInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ScreenAdProvider> onDidDismissInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onDidDismissInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onDidDismissInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ScreenAdProvider> onDidShowInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_onDidShowInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_onDidShowInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ScreenAdProvider> onDidFailToShowInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_onDidFailToShowInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_onDidFailToShowInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<ScreenAdProvider> onDidClickInterstitial
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_onDidClickInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_onDidClickInterstitial;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public abstract void CacheNowInterstitials();

	public abstract void Init();

	public abstract void ShowInterstitial();

	public virtual bool IsNativeProvider()
	{
		return false;
	}

	public virtual void NativeAdWasShown()
	{
		Action<ScreenAdProvider> action = this.m_onDidShowInterstitial;
		if (this.m_onDidShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public virtual void NativeAdWasHidden()
	{
		Action<ScreenAdProvider> action = this.m_onDidDismissInterstitial;
		if (this.m_onDidDismissInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public virtual void NativeAdWasClicked()
	{
		Action<ScreenAdProvider> action = this.m_onDidClickInterstitial;
		if (this.m_onDidClickInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public virtual NativeInterstitialAdObject NativeGetAdObject()
	{
		return null;
	}

	public virtual void DiscardInvalidAd()
	{
	}

	public void OnDidCacheInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidCacheInterstitial;
		if (this.m_onDidCacheInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnDidFailToLoadInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidFailToLoadInterstitial;
		if (this.m_onDidFailToLoadInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnDidDismissInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidDismissInterstitial;
		if (this.m_onDidDismissInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnDidShowInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidShowInterstitial;
		if (this.m_onDidShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnDidClickInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidClickInterstitial;
		if (this.m_onDidClickInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnDidFailToShowInterstitial(ScreenAdProvider provider)
	{
		Action<ScreenAdProvider> action = this.m_onDidFailToShowInterstitial;
		if (this.m_onDidFailToShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}
}
