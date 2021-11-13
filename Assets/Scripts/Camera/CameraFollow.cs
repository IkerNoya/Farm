using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player = null;
    [SerializeField] float zOffset = 0;
    [SerializeField] float followSpeed = 0;

    Vector3 wantedCameraPosition = Vector3.zero;

    void Start()
    {
        if (player != null)
            transform.position = new Vector3(player.position.x, player.position.y, zOffset);
    }
    void LateUpdate()
    {
        Vector3 wantedCameraPosition = new Vector3(player.position.x, player.position.y, zOffset);

        if (player != null)
            transform.position = Vector3.Lerp(transform.position, wantedCameraPosition, followSpeed * Time.deltaTime);
       
    }
}
