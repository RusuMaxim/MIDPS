using UnityEngine;
using System.Collections;

public class loose : MonoBehaviour {

    public Sprite  lose;

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
            case "bmw":
                Application.LoadLevel("lost");
                break;
            case "audi":
                Application.LoadLevel("lost");
                break;
            case "opel":
                Application.LoadLevel("lost");
                break;
        }
    }
}
