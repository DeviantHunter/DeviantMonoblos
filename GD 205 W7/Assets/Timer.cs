using UnityEngine;
using System.Collections;
using UnityEngine.UI;//always remember to include this!

public class Timer : MonoBehaviour {
	
	private float mytime = 80;
	public Text Timetext;
	private bool Timerisactive=true;

	// Use this for initialization
	void Start () {
		Timetext = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (Timerisactive) {
			mytime -= Time.deltaTime;
			Timetext.text = mytime.ToString ("f0");
			print (mytime);
			if (mytime <= 0) {
				mytime = 0;
				Timerisactive = false;
				print ("player lost");
			}
		}
	}
}
