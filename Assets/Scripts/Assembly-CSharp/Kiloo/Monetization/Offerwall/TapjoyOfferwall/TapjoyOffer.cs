using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Monetization.Offerwall.TapjoyOfferwall;

public class TapjoyOffer : IDisplayableOffer
{
	public enum TapjoyOfferType
	{
		None,
		ActionOffer,
		Announcement,
		App,
		DeeplinkOffer,
		EmailOffer,
		GenericOffer,
		MraidOffer,
		OfferpalOffer,
		RatingOffer,
		ReengagementOffer,
		SurveyOffer,
		VideoOffer
	}

	private string _name;

	private string _amount;

	private string _cost;

	private string _payout;

	private string _iconURL;

	private string _iconURLMedium;

	private string _redirectURL;

	private string _storeID;

	private string _type;

	private Texture2D _texture;

	private Action m_textureChanged;

	public string title => _name;

	public string payoutAmount => _amount;

	public string iconToDisplayURL => _iconURLMedium;

	public string actionURL => _redirectURL;

	public string costForInstall => _cost;

	public string offerType => _type;

	public Texture2D texture
	{
		get
		{
			return _texture;
		}
		set
		{
			if (_texture != value)
			{
				_texture = value;
				Action action = this.m_textureChanged;
				if (this.m_textureChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public event Action textureChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_textureChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 48;
			Delegate obj2 = this.m_textureChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public TapjoyOffer(string name, string amount, string cost, string payout, string iconURL, string iconURLMedium, string redirectURL, string storeID, string type)
	{
		_name = string.Empty;
		_amount = string.Empty;
		_cost = string.Empty;
		_payout = string.Empty;
		_iconURL = string.Empty;
		_iconURLMedium = string.Empty;
		_redirectURL = string.Empty;
		_storeID = string.Empty;
		_type = string.Empty;
		_name = name;
		_amount = amount;
		_cost = cost;
		_payout = payout;
		_iconURL = iconURL;
		_iconURLMedium = iconURLMedium;
		_redirectURL = redirectURL;
		_storeID = storeID;
		_type = type;
	}

	public string FormatToString()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
