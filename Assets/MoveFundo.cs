using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundo : MonoBehaviour
{
    float larguraTela;
    // Start is called before the first frame update
    void Start()
    {        
        SpriteRenderer grafico = GetComponent<SpriteRenderer>();

        float larguraImagem = grafico.sprite.bounds.size.x;
        float alturaImagem = grafico.sprite.bounds.size.y;

        float alturaTela = Camera.main.orthographicSize * 2f;
        larguraTela = alturaTela  /Screen.height * Screen.width;
        //larguraTela = Camera.main.orthographicSize * 2f * Screen.width / Screen.height;


        Vector2 novaEscala = transform.localScale;
        novaEscala.x = larguraTela/larguraImagem + 1f;
        novaEscala.y = alturaTela/alturaImagem;
        this.transform.localScale = novaEscala;

        if(this.name == "imagemFundoB")
        {
            transform.position = new Vector2(larguraTela, 0f);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= - larguraTela ){
            transform.position = new Vector2(larguraTela, 0f);
        }
    }
}
