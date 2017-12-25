using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount;
	public static int SecondCount;
	public static float MilliCount;
	public static string MilliDisplay;

	public GameObject Minutebox;
	public GameObject Secondbox;
	public GameObject Millibox;

	public static float RawTime;

	void Update () 
	{
		MilliCount += Time.deltaTime * 10;
		RawTime += Time.deltaTime;
		MilliDisplay = MilliCount.ToString ("F0");
		Millibox.GetComponent<Text> ().text = "" + MilliDisplay;

		if (MilliCount >= 10)
		{
			MilliCount = 0;
			SecondCount += 1;
		}

		if (SecondCount <= 9) {
			Secondbox.GetComponent<Text> ().text = "0" + SecondCount + ".";
		}
		else
		{
			Secondbox.GetComponent<Text>().text= "" +SecondCount+".";		
		}

		if (SecondCount >= 60) 
		{
			SecondCount = 0;
			MinuteCount += 1;
		}

		if (MinuteCount <= 9) {
			Minutebox.GetComponent<Text> ().text = "0" + MinuteCount + ":";
		}
		else
		{
			Minutebox.GetComponent<Text> ().text = "" + MinuteCount + ":";
		}
	}
}
