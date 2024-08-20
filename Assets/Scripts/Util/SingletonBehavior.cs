using UnityEngine;

public abstract class SingletonBehavior<T> : MonoBehaviour
	where T: SingletonBehavior<T>
{
	public static T Instance => _instance;

	static T _instance = null;

	virtual protected void Awake(){
		if(_instance){
			Debug.LogError("Multiple SingletonBehavior instances");
			Destroy(this);
			return;
		}
		_instance = this as T;
	}
}