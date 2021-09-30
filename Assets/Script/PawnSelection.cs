using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawnSelection : MonoBehaviour
{
    //public
    public Texture g_Texture;
    //private

    private  PawnActionControls pawnActionControls;

    private void Awake()
    {
        pawnActionControls = new PawnActionControls();
    }

    private void OnEnable()
    {
        pawnActionControls.Enable();
        
    }

    private void OnDisable()
    {
        pawnActionControls.Disable();
    }
    private void Start()
    {

    }

    private void Update()
    {
        PathManagement pathManagement = new PathManagement();
        if (Input.GetMouseButtonUp(0))
        {
            //Read the movement value
            float movementInput = pawnActionControls.Pawn.Move.ReadValue<float>();
            // Move the player
            Vector3 currentPos = transform.position;
            //currentPos.y += 2;
            //transform.position = currentPos;
            //Creating our path for our pawn

            pathManagement.CreatePath(g_Texture, currentPos);
            pathManagement.TogglePathCreation();
            //delete if clicked again
            if (pathManagement.m_PathDestory)
            {
                print(pathManagement.m_PathPawn);
                Destroy(pathManagement.m_PathPawn);
                print(pathManagement.m_PathPawn);
            }
        }





    }
}
