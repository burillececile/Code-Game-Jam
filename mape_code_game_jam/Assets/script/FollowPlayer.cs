using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public SubmarineMovement submarineMovement;

    public float cam�raSousmarin;
    public float cam�raPlongeur;

    public float timeOffset;
    public Vector3 posOffset;

    private Vector3 velocity;

    void Update()
    {
        if (submarineMovement.getPlayerInside())
        {
            gameObject.GetComponent<Camera>().orthographicSize = cam�raSousmarin;
        }
        else
        {
            gameObject.GetComponent<Camera>().orthographicSize = cam�raPlongeur;
        }
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
    }
}