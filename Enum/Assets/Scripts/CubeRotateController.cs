using UnityEngine;

public class CubeRotateController : MonoBehaviour
{

    [SerializeField] private float rotateSpeed;



    void Update()
    {
        SetCubeRotate();
    }



    private void SetCubeRotate()
    {
        transform.Rotate(new Vector3(1, 1, 0) * rotateSpeed * Time.deltaTime);
    }
}
