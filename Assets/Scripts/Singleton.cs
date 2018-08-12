using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
    private static T _instance = null;
    public static T Instance {
        get {
            if (_instance == null) {
                _instance = GameObject.FindObjectOfType<T>();
                if (_instance == null) {
                    GameObject n = new GameObject(typeof(T).FullName);
                    _instance = n.AddComponent<T>();
                }
            }
            return _instance;
        }
    }
}

