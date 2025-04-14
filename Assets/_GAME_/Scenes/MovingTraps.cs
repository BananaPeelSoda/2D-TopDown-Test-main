using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("trap"))
        {
            // Restart the level or apply damage to the player
            SceneManager.LoadScene("Level_03");
        }
    }



}
    public class Trap : MonoBehaviour
{
    public Vector3 point1;
    public Vector3 point2;
    public float moveDuration = 3.0f;

    private Vector3 currentTarget;
    private float timeElapsed;

    void Start()
    {
        currentTarget = point1;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= moveDuration)
        {
            timeElapsed = 0.0f;
            currentTarget = currentTarget == point1 ? point2 : point1;
        }

        transform.position = Vector3.Lerp(transform.position, currentTarget, timeElapsed / moveDuration);
    }
}