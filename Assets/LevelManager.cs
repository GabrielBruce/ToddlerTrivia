using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float menuVolume = 1f;
    public float gameVolume = 0.5f;

    public void LoadLevel(string name) {
        Debug.Log("New Level load: " + name);
        if (name == "Menu")
        {
            FindObjectOfType<AudioSource>().volume = menuVolume;
        }
        else
        {
            FindObjectOfType<AudioSource>().volume = gameVolume;
        }
        SceneManager.LoadScene(name);
    }

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
