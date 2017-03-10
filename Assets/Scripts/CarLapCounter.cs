using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
				if (lap <= 3) {
					UpdateText ();
				}
			}
			SetNextTrigger(next);
		}
	}

	void SetNextTrigger(TrackLapTrigger trigger) {
		next = trigger.next;
		SendMessage("OnNextTrigger", next, SendMessageOptions.DontRequireReceiver);
	}

	void Update(){
		if (GameObject.Find ("Timer").GetComponent<Timer>().countDownDone == true && lap > 3) {
			winMessage.text = color + " Wins!!\nPress R to restart";
			GameObject.Find ("Timer").GetComponent<Timer>().countDownDone = false;
		}
		if (Input.GetKeyDown("r")){
			SceneManager.LoadScene("tutorial1",LoadSceneMode.Single);
		}
			

	}
}
