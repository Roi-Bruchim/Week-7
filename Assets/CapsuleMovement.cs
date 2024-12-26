using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    void Update()
    {
        // Movement in the forward/backward direction
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Movement in the left/right direction
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // Apply the movement
        transform.Translate(moveHorizontal, 0, moveVertical);
    }
}
