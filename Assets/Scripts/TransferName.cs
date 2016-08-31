using UnityEngine;
using System.Collections;

public class TransferName : MonoBehaviour {

	public void ButtonClicked()
    {
        DispMsg.dispMessage(gameObject.name);
        Assemble.SetComponent(gameObject.name);
    }
}
