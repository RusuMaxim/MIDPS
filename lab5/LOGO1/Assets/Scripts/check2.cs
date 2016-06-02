using UnityEngine;
using System.Collections;

public class check2 : MonoBehaviour {

    public Sprite check;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = check;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = check;
    }
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "peugeot":
                Application.LoadLevel("play");
                break;
        }
    }
}
