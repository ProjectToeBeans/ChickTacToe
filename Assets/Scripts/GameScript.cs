using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public int w = 3;
    public int h = 3;

    public void OnSquareClicked(int x)
    {
        Debug.Log("Clicked " + x + "x");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
