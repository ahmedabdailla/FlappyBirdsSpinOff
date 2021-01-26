using UnityEngine;

namespace Scripts
{
    public class ReactivateAllChildren : MonoBehaviour
    {
        [SerializeField] private Transform[] gameObjects;
        public void Action()
        {
            gameObjects = GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].gameObject.SetActive(true);
            }
        }
    }
}