using UnityEngine;

public class Product : MonoBehaviour
{
    public float Price, AddEn;

    public void Buy()
    {
        //......
        Debug.Log("����: " + Price + " � ������� " + AddEn + " �������");
    }
}
