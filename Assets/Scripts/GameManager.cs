using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public Sprite[] cardFace;
	public Sprite cardBack;
	public GameObject[] cards;
	public Text matchText;

	private bool _init = false;
	private int _matches = 13;
	
	// Update is called once per frame
	void Update () {
		if (!_init) {
			InitializeCards ();
		}
		if (Input.GetMouseButtonUp (0))
			checkCards ();
	}

	void InitializeCards ()
	{
		for (int id = 0; id < 2; id++) {
			for (int i = 1; i < 14; i++) {
				bool test = false;
				int choice = 0;
				while (!test) {
					choice = Random.Range (0, cards.Length);
					test = !(cards [choice].GetComponent<Card> ().initialized);
				}
				cards [choice].GetComponent<Card> ().cardValue = i;
				cards [choice].GetComponent<Card> ().initialized = true;
			}
		}
		foreach (GameObject c in cards) {
			c.GetComponent<Card> ().setupGraphics ();
		}
		if (!_init)
			_init = true;
	}

	public Sprite getCardBack() {
		return cardBack;
	}

	public Sprite getCardFace(int i) {
		return cardFace [i - 1];
	}

	void checkCards() {
		List<int> c = new List<int> ();
	}
}
