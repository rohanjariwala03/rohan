using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

		public void NewLevel(string PlayType)
		{
			SceneManager.LoadScene (PlayType);
		}
		

		public void Backbtn(string Back)
		{
			SceneManager.LoadScene (Back);
		}

		public void Creditsbtn(string Credits)
		{
			SceneManager.LoadScene (Credits);
		}
		
		public void ExitGame()
		{
			Application.Quit ();
		}
	}

