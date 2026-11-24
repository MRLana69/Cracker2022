namespace Info;

public class Upgrade
{
	public string name; //Field offset: 0x8
	public string nameTwoLines; //Field offset: 0xC
	public string description; //Field offset: 0x10
	public string mysteryBoxDescription; //Field offset: 0x14
	public int numberOfTiers; //Field offset: 0x18
	public float[] durations; //Field offset: 0x1C
	public float speed; //Field offset: 0x20
	public float landSpeed; //Field offset: 0x24
	public int spawnProbability; //Field offset: 0x28
	public int[] pricesRaw; //Field offset: 0x2C
	public string iconName; //Field offset: 0x30
	public int weight; //Field offset: 0x34

	public Upgrade() { }

	public string GetName() { }

	public int GetPrice(int tier) { }

}

