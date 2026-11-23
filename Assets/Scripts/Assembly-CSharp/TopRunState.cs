using UnityEngine;

public class TopRunState : MonoBehaviour
{
	private GameObject _normalStateParent;

	private TopRunNormalStateHelper _normalStateHelper;

	private GameObject _resultsStateParent;

	private GameObject _offlineStateParent;

	private void Awake()
	{
		TopRunNormalStateHelper component = _normalStateParent.GetComponent<TopRunNormalStateHelper>();
		_normalStateHelper = component;
	}

	public void SetState(TopRunStates newState)
	{
		ResetStates();
		switch (newState)
		{
		case TopRunStates.NORMAL:
			SetNormalState();
			break;
		case TopRunStates.RESULTS:
			SetResultsState();
			break;
		case TopRunStates.OFFLINE:
			SetOfflineState();
			break;
		default:
			SetOfflineState();
			break;
		}
	}

	private void ResetStates()
	{
		_normalStateParent.SetActive(value: false);
		_resultsStateParent.SetActive(value: false);
		_offlineStateParent.SetActive(value: false);
	}

	private void SetNormalState()
	{
		_normalStateParent.SetActive(value: true);
		_normalStateHelper.InitNormalState();
	}

	private void SetResultsState()
	{
		_resultsStateParent.SetActive(value: true);
	}

	private void SetOfflineState()
	{
		_offlineStateParent.SetActive(value: true);
	}
}
