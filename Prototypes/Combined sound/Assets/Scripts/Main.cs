using System.Collections;
using UnityEngine;

public sealed class Main : MonoBehaviour
{
	private static Main _Instance;

	public static Main Instance
	{
		get
		{
			if (_Instance == null)
			{
				_Instance = FindObjectOfType(typeof(Main)) as Main;
				if (_Instance == null)
				{
					GameObject go = new GameObject("_Main");
					_Instance = go.AddComponent<Main>();
				}
			}
			return _Instance;
		}
	}

	void Start()
	{
		DontDestroyOnLoad(this);

		if (_Instance != this)
		{
			Destroy(this);
			return;
		}

		StartCoroutine(Load());
	}

	IEnumerator Load()
	{
		yield return null;
	}
}