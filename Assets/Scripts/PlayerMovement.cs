using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10f;

    [SerializeField] InputAction moveHorizontal = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        moveHorizontal.Enable();
    }

    void OnDisable()
    {
        moveHorizontal.Disable();
    }

    float horizontal;
    void Update()
    {
        horizontal = moveHorizontal.ReadValue<float>();
        Vector3 movementVector = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }
    public float getHorizontal() { return horizontal; }
    public float getSpeed() { return speed; }
}
