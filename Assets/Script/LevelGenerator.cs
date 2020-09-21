using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject outsidewall;
    public GameObject insidewall;
    public GameObject outsidecorner;
    public GameObject insidecorner;
    public GameObject normalpellet;
    public GameObject emergypellet;
    public GameObject life;
    public GameObject G1;
    public GameObject G2;
    public GameObject G3;
    public GameObject G4;
    public GameObject Hero;
    public GameObject chery;

    // Start is called before the first frame update
    void Start()
    {
        int[,] levelMap =
        {
     {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
     {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
     {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
     {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
     {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
     {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
     {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
     {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
     {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
     {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
     {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
     {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
     {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
     {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
     {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
     };
        Instantiate(life, new Vector2(28, -10), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(life, new Vector2(28, -3), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(life, new Vector2(28, 10), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(G1, new Vector2(10, 16), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(G2, new Vector2(10, 12), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(G3, new Vector2(16, 12), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(G4, new Vector2(16, 16), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(Hero, new Vector2(18, 22), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(chery, new Vector2(18, 15), Quaternion.identity).transform.Rotate(0, 0, 90);
        Instantiate(chery, new Vector2(18, 17), Quaternion.identity).transform.Rotate(0, 0, 90);

        for (int i = 0; i < levelMap.GetLength(0); i++)
        {

            for (int j = 0; j < levelMap.GetLength(1); j++)
            {
                switch (levelMap[i, j])
                {
                   // case 1:
                    
                }
            }
        }

    }



// Update is called once per frame
void Update()
    {
        
    }
}

