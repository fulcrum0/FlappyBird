using UnityEngine;

public class Pipes : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] float slideSpeed;

    void FixedUpdate()
    {
        SlideToLeft();
    }

    void SlideToLeft()
    {
        transform.position += Vector3.left * slideSpeed * Time.deltaTime;
    }
}