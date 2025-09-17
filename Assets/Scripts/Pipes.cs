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
        transform.position += slideSpeed * Time.deltaTime * Vector3.left;
    }
}