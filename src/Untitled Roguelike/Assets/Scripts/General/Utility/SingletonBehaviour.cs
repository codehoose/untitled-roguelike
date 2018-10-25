using UnityEngine;

public abstract class SingletonBehaviour<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
{
    #region Singleton pattern

    private static TComponent _instance;

    public static TComponent Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TComponent>();
                if (_instance == null)
                {
                    var goName = "__" + typeof(TComponent).Name;
                    var go = new GameObject(goName);
                    _instance = go.AddComponent<TComponent>();
                }
            }

            return _instance;
        }
    }

    #endregion
}
