using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInstantiater : MonoBehaviour
{
    [SerializeField] private GameObject _tempLate;
    [SerializeField] private int _countOfEnemies;

    public void Start()
    {
        StartCoroutine(Creator());
    }

    private IEnumerator Creator()
    {
        float CoolDownOfCreate = 2;
        float MinCoordinateValue = 0;
        float MaxCoordinateValue = 4;

        for (int i = 0; i < _countOfEnemies; i++)
        {
            float CoordinateX = Random.Range(MinCoordinateValue, MaxCoordinateValue);
            float CoordinateY = Random.Range(MinCoordinateValue, MaxCoordinateValue);
            float CoordinateZ = 0;

            GameObject newObject = Instantiate(_tempLate, new Vector3(CoordinateX, CoordinateY, CoordinateZ), Quaternion.identity);

            yield return new WaitForSeconds(CoolDownOfCreate);
        }
    }
}
