using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Sprite layer_Green, layer_Blue;

	void OnMouseDown () {

		GetComponent<SpriteRenderer> ().sprite = layer_Blue;
	
	}
	void OnMouseUp () {
	
		GetComponent<SpriteRenderer> ().sprite = layer_Green;
	}

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "PLAY":
                Application.LoadLevel("play");
                break;
            case "SOUND":
                Application.OpenURL("https://google.com");
                break;
        }

    }
		
}
