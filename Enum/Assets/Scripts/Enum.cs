using UnityEngine;

public class Enum : MonoBehaviour
{

    [SerializeField] private Colors colors;



    void Update()
    {
        SetCubeColor();
    }



    private enum Colors
    {
        Blue,
        Red,
        Green
    }



    private void SetCubeColor()
    {
        switch (colors)
        {
            case Colors.Red:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;

            case Colors.Blue:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;

            case Colors.Green:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
        }
    }
}
