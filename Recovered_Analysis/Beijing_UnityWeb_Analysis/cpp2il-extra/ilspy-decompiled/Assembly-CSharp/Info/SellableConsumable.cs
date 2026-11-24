using Cpp2ILInjected;
using SYBO.Subway.Cameras;

namespace Info;

public class SellableConsumable
{
	public static readonly SellableConsumable headstart;

	public static readonly SellableConsumable scorebooster;

	public static readonly SellableConsumable hoverboard;

	private UpgradeType upgradeType__BackingField;

	private int price__BackingField;

	private string spriteName__BackingField;

	private string header__BackingField;

	private string description__BackingField;

	public UpgradeType upgradeType
	{
		get
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			//IL_0027: Expected Obj, but got I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 12;
			obj = upgradeType__BackingField;
			object obj3 = obj2 + 8;
			obj3 = obj;
			object obj4 = obj2 + 16;
			obj4 = obj3;
			object obj5 = obj2 + 4;
			obj5 = price__BackingField;
			obj2 = obj5;
			obj4 = obj2;
			_ = spriteName__BackingField;
			bool flag = description__BackingField != null;
			_ = header__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.SellableConsumable)+1C]");
			_ = 0;
			UpgradeType upgradeType = default;
			object obj6 = upgradeType + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.SellableConsumable)+20]");
			obj6 = 0;
			return upgradeType;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001e: Expected Obj, but got I
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected Obj, but got Unknown
			//IL_0054: Expected I4, but got Obj
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I
			//IL_008c: Expected I4, but got Obj
			//IL_009e: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I4
			//IL_00d4: Expected Obj, but got I
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_00fc: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+8]");
			obj = 0;
			object obj3 = obj2 + 8;
			obj3 = obj;
			object obj4 = obj2 + 16;
			obj4 = obj3;
			upgradeType__BackingField = (UpgradeType)obj4;
			object obj5 = obj2 + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+C]");
			obj5 = 0;
			obj2 = obj5;
			obj4 = obj2;
			price__BackingField = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+10]");
			spriteName__BackingField = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+18]");
			bool flag = (nint)0 != 0;
			description__BackingField = (string)flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+14]");
			header__BackingField = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+1C]");
			_ = 0;
			object obj6 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (Info.UpgradeType)+20]");
			obj6 = 0;
		}
	}

	public int price
	{
		get
		{
			return (int)upgradeType__BackingField;
		}
		private set
		{
			upgradeType__BackingField = (UpgradeType)value;
		}
	}

	public string spriteName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)price__BackingField;
		}
		private set
		{
			//IL_000a: Expected I4, but got Obj
			price__BackingField = (int)value;
		}
	}

	public string header
	{
		get
		{
			return spriteName__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public string description
	{
		get
		{
			return header__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	private SellableConsumable(UpgradeType upgradeType, int price, string spriteName, string header, string description)
	{
		((CharacterCamera)this).ResetShake();
	}
}
