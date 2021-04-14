using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 20f;
    

    // Start is called before the first frame update
    void Start()
    {
        PrintTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();
     
    }

    void PrintTutorial()
    {
        Debug.Log("Welcome to the Obstacle Course.");
        Debug.Log("Control your character with W,A,S,D or arrow keys.");
        Debug.Log("Dodge the obstacles and get to the finish line!");
    }

    void PlayerControls()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

}
