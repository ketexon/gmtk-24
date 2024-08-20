using System.Collections;
using UnityEngine;

public static class CoroutineUtil {
	public static void WaitThenDo(this MonoBehaviour mb, float time, System.Action then){
		IEnumerator Impl(){
			yield return new WaitForSeconds(time);
			then?.Invoke();
		}
		mb.StartCoroutine(Impl());
	}
}