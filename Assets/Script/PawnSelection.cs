using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnSelection : MonoBehaviour
{

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
        if (Input.GetMouseButtonDown(0))
        {

        //Vector3 positionMouse = Input.GMouse
        //Read the movement value
         float movementInput = pawnActionControls.Pawn.Move.ReadValue<float>();
        // Move the player
        Vector3 currentPos = transform.position;
        currentPos.y += 1;
        transform.position = currentPos;
        }
    }
}
