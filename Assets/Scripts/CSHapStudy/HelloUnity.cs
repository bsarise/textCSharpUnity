using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshPro text;

    int damage = 100;
    float time = 5.5f;
    string name = "�̼���"; 

    private void Start() // �ѹ��� �����Ѵ�.
    {
        Debug.Log("�������� �� = " + damage);
        Debug.Log("�ð��� �� = " + time);
        Debug.Log("�̸��� �� = " + name);

        text.text = string.Format($"Only{damage} English{time} is visible : �����̴�?");
    }
}
