using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {
	public void Change (string SceneName){
		Application.LoadLevel(SceneName);
	}

}
