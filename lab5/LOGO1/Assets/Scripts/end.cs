using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {

    public Sprite layer_Green, layer_Blue;

    void OnMouseDown()
    {

        GetComponent<SpriteRenderer>().sprite = layer_Blue;

    }
    void OnMouseUp()
    {

        GetComponent<SpriteRenderer>().sprite = layer_Green;
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "restart":
                Application.LoadLevel("play");
                break;
            case "main":
                Application.LoadLevel("main");
                break;
            
        }

    }
}
