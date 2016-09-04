using UnityEngine;
using System.Collections;

public class SimpleFollow : MonoBehaviour
{

    //기본 카메라 이동
    Vector3 diff;

    public GameObject player;
    public float followSpeed;

    void Start()
    {
        diff = player.transform.position - transform.position;
    }

    void LateUpdate()
    {
        if (player == null)
        {

        }
        else
        {
            transform.position = Vector3.Lerp(
                transform.position,
                player.transform.position - diff,
                Time.deltaTime * followSpeed);
        }
    }
}
    /*
    public class SimpleFollow : MonoBehaviour
    {   //외부 오브젝트(플레이어) 끌어오기
        public GameObject player;
        //외부 오브젝트로부터의 거리 설정
        public float offsetX = 0f;
        public float offsetY = 25f;
        public float offsetZ = -35f;
        public float followSpeed;
        Vector3 cameraPosition;
    
        void LateUpdate()
        {
            //카메라 포지션을 매 프레임마다 재설정
            cameraPosition.x = player.transform.position.x + offsetX;
            cameraPosition.y = player.transform.position.y + offsetY;
            cameraPosition.z = player.transform.position.z + offsetZ;
            //딱딱하게 움직이기만하기
            //transform.position = cameraPosition;

            //느린 속도를 부여해 부드러운 카메라 이동
            transform.position = Vector3.Lerp(transform.position, 
                                                cameraPosition, 
                                                followSpeed * Time.deltaTime);
        }
    }*/

