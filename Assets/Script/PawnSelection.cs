using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PawnSelection : MonoBehaviour
{
    //public
    public Texture g_Texture;
    // public PawnSelection.PawnType g_type = new PawnSelection.PawnType(); 
    //private
    private bool g_isFirstMove;
    public Pawn g_Pawn;


    ////  private  PawnActionControls pawnActionControls;

    //private void Awake()
    //{
    //    //  pawnActionControls = new PawnActionControls();
    //}

    //private void OnEnable()
    //{
    //    //  pawnActionControls.Enable();

    //}

    //private void OnDisable()
    //{
    //    // pawnActionControls.Disable();
    //}
    private void Start()
    {
        Vector2 pos = new Vector2(0.5f,1.5f);
        string texPath = "Assets/Textures/Path_Init.png";
        g_Pawn = new Pawn(texPath, PawnType.pawn,pos,true);
    }
    private void OnMouseDown()
    {
        g_Pawn.TestRun();
        PathManagement pathManagement = new PathManagement();
        if (Input.GetMouseButtonDown(0))
        {
            g_Pawn.TestRun();

            //Read the movement value
            // float movementInput = pawnActionControls.Pawn.Move.ReadValue<float>();
            // Move the player
            Vector3 currentPos = transform.position;
            //currentPos.y += 2;
            //transform.position = currentPos;
            //Creating our path for our pawn

            pathManagement.GenerateMovements(g_Texture, currentPos);
        }
    }
    private void Update()
    {




    }

    //private void GeneratePath()
    //{
    //    Vector2[] virtuelPos;
    //    switch (0)
    //    {
    //        case "pawn":
    //            break;

    //        default:
    //    }

    //}

}


