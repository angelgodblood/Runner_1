using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HP_Money : MonoBehaviour
{
    public GameObject effect_1;// эффект столкновения
    public GameObject zvezda_effect;// эффект столкновений с монетами
    public GameObject Player;// игрок
    //public CityTownMove speed;
    //public CityTCV1 speed_2;
    public GameOverLvL GOL;
    private Animator animator; // аниматор
    [SerializeField] private int Life;// жизни
    [SerializeField] private int gold_money;// золото
    [SerializeField] private int serebro_money;// серебро
    [SerializeField] private int bronze_money;// бронза
    [SerializeField] private GameObject Die; // звук смерти
    [SerializeField] private GameObject gameover; // звук проигрыша
    [SerializeField] private GameObject gameOver_panel; // объект проигрыша
    [SerializeField] private Text Life_1; // текст жизней
    [SerializeField] private Text coin_gold; // текст золота
    [SerializeField] private Text coin_bronze; // текст бронзы
    [SerializeField] private Text coin_serebro; // текст серебра
    [SerializeField] GameObject Finish_Panel; // панель финиша
    [SerializeField] private GameObject finish; // текст финиша
    [SerializeField] private GameObject stop_brick; // звук удара об объект
    
    void Start()
    {
        animator = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    void Update()
    {
        
        Life_1.text = Life + " % Жизни";
        coin_gold.text = gold_money + " % Золото";
        coin_serebro.text = serebro_money + " % Серебро";
        coin_bronze.text = bronze_money + " % Бронза";

        if (Life <= 0)
        {
         animator.SetTrigger("Death");
         Instantiate(Die, transform.position, transform.rotation);
         Instantiate(gameover, transform.position, transform.rotation);
         gameOver_panel.SetActive(true);
         Destroy(gameObject);
         Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Life")
        {
            Life++;
            
        }
        if(other.gameObject.tag == "coins_g")
        {
            Instantiate(zvezda_effect, transform.position,Quaternion.identity);
            gold_money ++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "coins_b")//сбор бронзовых монет
        {
            Instantiate(zvezda_effect, transform.position,Quaternion.identity);
            bronze_money++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "coins_s")//сбор серебрянных монет
        {
            Instantiate(zvezda_effect, transform.position,Quaternion.identity);
            serebro_money++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "die")
        {
            Instantiate(effect_1, transform.position,Quaternion.identity);
            Life--;
            Instantiate(stop_brick, transform.position, transform.rotation);
            //StartCoroutine("TimeScale");
            Destroy(other.gameObject);
        }
         
        if (other.gameObject.tag == "die_2")
        {
          Instantiate(effect_1, transform.position,Quaternion.identity);
          animator.SetTrigger("Death");
          Instantiate(Die, transform.position, transform.rotation);
          
          Instantiate(gameover, transform.position, transform.rotation);
          
          gameOver_panel.SetActive(true);
         
          Destroy(other.gameObject);
          Time.timeScale = 0;
        }

        if (other.gameObject.tag == "stop")
        {
            Instantiate(effect_1, transform.position, Quaternion.identity);
            
            Instantiate(stop_brick, transform.position, transform.rotation);

            
            //StartCoroutine(TimeScale());
            
        }
        if (other.gameObject.tag == "stop_2")
        {
            Instantiate(effect_1, transform.position, Quaternion.identity);
            
            Instantiate(stop_brick, transform.position, transform.rotation);

            
            //StartCoroutine(TimeScale());
            
        }
        
    }

    private void OnCollisionEnter(Collision other2)
    {
        if (gold_money >= 100 && serebro_money >= 100 && bronze_money >= 100)//условия для перехода на второй уровень
        {
           finish.SetActive(true);
           Finish_Panel.SetActive(true);
        }

        

        if (gold_money >= 500 && serebro_money >= 500 && bronze_money >= 500)//условия для перехода на третий уровень
        {
           finish.SetActive(true);
           Finish_Panel.SetActive(true);
        }

    }

/*IEnumerator TimeScale()
{
        animator.SetTrigger("Death");
        speed.speed = 0;
        speed_2.speed = 0;
        speed.maxSpeed = 0;
        speed_2.maxSpeed = 0;
        
        yield return new WaitForSecondsRealtime(1f);
        GOL.GameOver.SetActive(true);

    }*/

    
}
