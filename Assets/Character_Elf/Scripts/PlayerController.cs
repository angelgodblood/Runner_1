using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class PlayerController : MonoBehaviour
{
    
    //Крайние точки левая и правая
    public float leftMaxPos; 
    public float rightMaxPos;
    public AnimationClip[] clip;
    public GameObject jump_effect;// эффект при прыжке
    public NameLevel StartLevel; // Старт уровня, после фразы GO
    public float speed; // скорость
    private float cellSize = 1f;// расстояни на которое нужно сдвинуться если была нажата кнопка
    Vector3 direction;//направление движения
    Vector3 destPos;//позиция куда двигаемся
    Rigidbody rb; // твердое тело
    private float jump = 400f; // сила прыжка
    private bool isDead; // жив ли персонаж
    private bool isGround; // на земле
    private Animator animator; // аниматор
    private int i; // обозначение уровня
    private Vector3 checkpoint; // точка сохранения
    private float clipTime;
    private Coroutine _moveCoroutine;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isDead = false;
        checkpoint = transform.position;
        animator = GetComponent<Animator>();
        i = SceneManager.GetActiveScene().buildIndex;

        #region Длина анимации
        AnimatorClipInfo[] stInfos = animator.GetCurrentAnimatorClipInfo(0);
        AnimationClip clip = stInfos[0].clip;
        clipTime = clip.length;
        Debug.Log(clipTime);
        #endregion
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!isDead && StartLevel.Run)
        {
            Moving();
            
            Jump();
        }

    }

    void Moving()
    {

        if (Input.GetKeyDown(KeyCode.A) && isGround)
        {
            StartMoveToSide(Vector3.left, "Left");
            Debug.Log("1");
        }

        else if (Input.GetKeyDown(KeyCode.D) && isGround)
        { 
            StartMoveToSide(Vector3.right, "Right");
            Debug.Log("2");
        }
        
    }

     void StartMoveToSide(Vector3 direction, string animationKey)
    {
        if (_moveCoroutine != null)
            return;

        animator.SetTrigger(animationKey);
        Vector3 destPosition = transform.position + direction * cellSize;
        _moveCoroutine = StartCoroutine(MoveToPosition(destPosition));
        
    }

      IEnumerator MoveToPosition(Vector3 target)
    {
        
        Vector3 position = transform.position;
        

        while (position != target)
        {
            
            // расчет новой пизиции с учетом скорости и конечной позици
            position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            // обрезаем значение что бы position.x не было меньше leftMaxPos и не было больше rightMaxPos
            position.x = Mathf.Clamp(position.x, leftMaxPos, rightMaxPos);

            // через rigidbody переносим позицию
            rb.MovePosition(position);
            yield return null;
            
        }
        
        _moveCoroutine = null;
    }

    void Jump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            
            rb.AddForce(Vector3.up * jump);
            animator.SetTrigger("Jump");
            Instantiate(jump_effect, transform.position,Quaternion.identity);
            isGround = false;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("isGround"))
        {
            isGround = true;
        }
        if(collision.gameObject.CompareTag("checkpoint"))
        {
            checkpoint = collision.transform.position;
        }

    }

}