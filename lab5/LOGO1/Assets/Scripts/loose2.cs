using UnityEngine;
using System.Collections;

public class loose2 : MonoBehaviour {

    public Sprite lose;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = lose;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = lose;
    }
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "volks":
                Application.LoadLevel("lost");
                break;
            case "maserati":
                Application.LoadLevel("lost");
                break;
            case "citroen":
                Application.LoadLevel("lost");
                break;
        }
    }
}
