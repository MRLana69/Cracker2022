namespace SYBO.Subway.Utilities;

public class PlaceholderPrefab : MonoBehaviour, IPrefabBehaviour
{
	private TrackObject[] _trackObjects; //Field offset: 0xC
	private Selector[] _selectors; //Field offset: 0x10

	public Selector[] Selectors
	{
		 get { } //Length: 6
	}

	public TrackObject[] TrackObjects
	{
		 get { } //Length: 13
	}

	public PlaceholderPrefab() { }

	public Selector[] get_Selectors() { }

	public TrackObject[] get_TrackObjects() { }

	public void Initialize() { }

}

