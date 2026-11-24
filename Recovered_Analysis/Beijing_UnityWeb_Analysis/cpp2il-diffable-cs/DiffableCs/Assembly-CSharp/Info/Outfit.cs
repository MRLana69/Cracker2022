namespace Info;

public class Outfit
{
	public Color32 buttonBgColor; //Field offset: 0x8
	public Color32 buttonIconColor; //Field offset: 0xC
	public UnlockType unlockType; //Field offset: 0x10
	public int uiPriority; //Field offset: 0x14
	public bool isNewInThisUpdate; //Field offset: 0x18
	public int price; //Field offset: 0x1C
	public string title; //Field offset: 0x20

	public Outfit() { }

	public Outfit Clone() { }

	public void Copy(Outfit copyFrom) { }

}

