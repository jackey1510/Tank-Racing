using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
	public Text cd;
	public bool countDownDone = false;

    private float time;
	private string countDown;

	void Start()
	{
		StartCoroutine (ready ());
	}

    void Update()
    {
		cd.text = countDown;

		if (countDownDone) {
			time += Time.deltaTime;

			var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
			var seconds = time % 60;//Use the euclidean division for the seconds.
			var fraction = (time * 100) % 100;

			//update the label value
			timerLabel.text = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
		}
    }

	IEnumerator ready(){
		if (!countDownDone) {
			countDown = "3";    
			Debug.Log ("3");
			yield return new WaitForSeconds (1f);  

			countDown = "2";    
			yield return new WaitForSeconds (1f);
			Debug.Log ("2");

			countDown = "1";    
			yield return  new WaitForSeconds (1f);
			Debug.Log ("1");

			countDown = "GO";    
			yield return  new WaitForSeconds (1f);
			countDownDone = true;
			Debug.Log ("GO");

			countDown = ""; 
		}
	}
//	void OnGui(){
//		GUI.color = Color.red;
//		GUI.Box (new Rect (0, 0, 10, 10), "Ready");
//
//		GUI.color = Color.white;
//		GUI.Box (new Rect(0, 0, 10, 10), countDown);
//
//
//
//	}
}