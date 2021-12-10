using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    [Tooltip("Значение минут в секунду, для перемещения солнца. По умолчанию 60")]
    public float timeScaling = 60f;

    // Update is called once per frame
    void Update()
    {
        float angleThisFrame = Time.deltaTime / 360 * timeScaling;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame); //Поворачивает преобразование относительно axis прохода point в мировых координатах на angle градусы.
    }
}
