using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarLapCounter : MonoBehaviour {

	public TrackLapTrigger first;
	public TextMesh textMesh;
	public Text winMessage;
	public string color;


	TrackLapTrigger next;
	
	private int lap;

	void Start () {
		lap = 1;
		SetNextTrigger(first);
		UpdateText();
	}
		
	void UpdateText() {
		if (textMesh) {
			textMesh.text = string.Format("Lap {0}/3", lap);		
		}
	}
		
	public void OnLapTrigger(TrackLapTrigger trigger) {
		if (trigger == next) {
			if (first == next) {
				lap++;
				UpdateText();
			}
			SetNextTrigger(next);
		}
	}

	void SetNextTrigger(TrackLapTrigger trigger) {
		next = trigger.next;
		SendMessage("OnNextTrigger", next, SendMessageOptions.DontRequireReceiver);
	}

	void Update(){
		if (lap > 3) {
			winMessage.text = color + " Wins!!";
		}
	}
}
