using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Player;
    public float time, minX, maxX;

    private void FixedUpdate()
    {
        Vector3 newPosition = Player.position + new Vector3(0, 0, -10);
        newPosition.y = 0.1f;
        newPosition = Vector3.Lerp(transform.position, newPosition, time);
        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }
}
