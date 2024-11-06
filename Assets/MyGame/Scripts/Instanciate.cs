using UnityEngine;

public class Instantiate : MonoBehaviour
{
    [SerializeField] private GameObject myPrefab;
    [SerializeField] private GameObject myParent;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject obj = Instantiate(myPrefab);
            obj.transform.SetParent(myParent.transform);
        }
    }
}