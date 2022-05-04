using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilCealing : MonoBehaviour
{
    public GameObject celaingPiece;
    public Vector3 pos = Vector3.zero;
    public Vector2 pieceSize = new Vector2 (3, 3);
    public Vector2 areaToFill = new Vector2 (20,20);

    
    void Start()
    {
        float pieceArea = pieceSize.x * pieceSize.y;
        float areaSize = areaToFill.x * areaToFill.y;

        int neededPeieces = Mathf.CeilToInt (areaSize / pieceArea);
        Debug.Log(neededPeieces);


        int piecesInRow = Mathf.CeilToInt(areaToFill.x / pieceSize.x);
        int numbreOfRows = Mathf.CeilToInt (areaToFill.y / pieceSize.y);

        Vector3 initialPos = pos;
        for (int i = 0; i < piecesInRow; i++)
        {
            for (int j = 0; j < numbreOfRows; j++)
            {
                Instantiate(celaingPiece, pos, Quaternion.identity);
                initialPos.z += pieceSize.y;
            }
            initialPos.z = pos.z;
            initialPos.x += pieceSize.x;

        }

 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
