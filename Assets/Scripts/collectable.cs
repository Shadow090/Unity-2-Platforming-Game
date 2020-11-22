using UnityEngine;

abstract public class collectable : MonoBehaviour
{
    public string collectableName;
    public string description;
    public GameObject player;

    abstract public void Use();
}
