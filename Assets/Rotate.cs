using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject CubeRed, CubeBlue;

    private float zOffset = 1.5f;

    private void Update()
    {
        RotateCube();
    }

    void RotateCube()
    {
        CubeRed.transform.position =
            new Vector3(CubeBlue.transform.position.x, CubeRed.transform.position.y, CubeBlue.transform.position.z) + CubeBlue.transform.forward * zOffset;

        CubeRed.transform.LookAt(

            new Vector3(CubeBlue.transform.position.x, CubeRed.transform.position.y, CubeBlue.transform.position.z)

            );
    }
}
