using UnityEngine;
using System.Collections;

public class check1 : MonoBehaviour {

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
            case "merc":
                Application.LoadLevel("play2");
            break;
        }
    }
}
