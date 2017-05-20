using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour {

	public void triggerMenuBehavior(int i) {
		switch (i) {
		case 0:
			SceneManager.LoadScene ("Menu");
			break;
		case 1:
			Application.Quit ();
			break;
		default:
			break;
		}
	}
}
