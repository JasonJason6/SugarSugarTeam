using UnityEngine;

namespace SeanStandardScript
{
    /// <summary>
    /// Be aware this will not prevent a non singleton constructor
    ///   such as `T myT = new T();`
    /// </summary>
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        private static readonly object Lock = new object();

        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            lock (Lock)
            {
                if (Instance == null)
                {
                    Instance = this as T;
                }
                else
                {
                    Debug.LogError("Atempted to create singleton instance '" + typeof(T) + 
                                   "' but instance already existed when it should not have.", this);
                }
            }
        }

    }

}