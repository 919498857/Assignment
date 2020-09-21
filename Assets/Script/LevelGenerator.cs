using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject outsidewall;
    public GameObject insidewall;
    public GameObject outsidecorner;
    public GameObject insidecorner;
    public GameObject normalpellet;
    public GameObject powerpellet;
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
                    case 1:
                        if (i == 9 && i == 0)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                        else if (i == 9 && i == 5)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, -90);
                            break;
                        }
                        else if (i == 13 && i == 5)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, -180);
                            break;
                        }
                        else
                        {

                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                    case 2:
                        if (i == 0)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if (i < 9)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                        else if (i >= 10 & i < 13)
                        {
                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                        else
                        {

                            Instantiate(outsidecorner, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                    case 3:
                        if ((i == 4 || i == 7) && j == 2 || (i == 4 && j == 7) || (i == 13 && j == 7) || (i == 10 && j == 13) || (i == 4 && j == 7))
                        {
                            Instantiate(insidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                        else if (((i == 4 || i == 7) && j == 5 || (i == 4 && j == 11) || (i == 13 && j == 8) || (i == 10 && j == 11)))
                        {
                            Instantiate(insidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                        else if (i >= 10 && i < 13)
                        {
                            Instantiate(insidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 180);
                            break;
                        }
                        else
                        {

                            Instantiate(insidecorner, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 270);
                            break;
                        }
                    case 4:
                        if (i == 2 && j < 11)
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if (i == 4 && i < 11)
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if (i == 6)
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if (i == 7 && i < 7 || j > 8)
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if ((i == 9 || i == 10) && (j >= 9 && j <= 10))
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else if (i == 12 && j > 10)
                        {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity);
                            break;
                        }
                        else {
                            Instantiate(insidewall, new Vector2(i, j), Quaternion.identity).transform.Rotate(0, 0, 90);
                            break;
                        }
                    case 5:
                        Instantiate(normalpellet, new Vector2(i, j), Quaternion.identity);
                        break;
                    case 6:    
                        Instantiate(powerpellet, new Vector2(i, j), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(outsidewall, new Vector2(i, j), Quaternion.identity);
                        break;
                }
            }
        }
    }
        

    



// Update is called once per frame
    void Update()
    {
        
    }
}

