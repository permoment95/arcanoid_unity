using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ball : MonoBehaviour
{


    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector3 ballInitialForce;



    // Use this for initialization
    void Start()
    {
        ballInitialForce = new Vector2(0.0f, -600.0f);

        // переводим в неактивное состояние
        ballIsActive = false;

        // запоминаем положение
        ballPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            if (!ballIsActive)
            {
                // применим силу
                gameObject.GetComponent<Rigidbody>().AddForce(ballInitialForce);
                // зададим активное состояние
                ballIsActive = !ballIsActive;
            }

        }
    }
}