using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressManager : MonoBehaviour
{
    public GameEvent onStart;
    public GameEvent onTap;
    void Start()
    {
        onStart.Raise();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if(hit.collider != null){
                onTap.Raise();
            }
        }
    }
}
