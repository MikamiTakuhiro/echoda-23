using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Scroll : MonoBehaviour
{
    //動く速さを決める
    [SerializeField] float speed;

    //移動先と移動ポイントを決める
    [SerializeField] float endPos;//ここまで
    [SerializeField] float movePos;//ここで移動

    //TypingMnagerのインスタンスを作成
    [SerializeField] TypingManager typing;

    //表示させるRaw画像のコンポーネント
    public RawImage img;
    //表示させる画像リスト
    public List<Texture> texture_list = new List<Texture>();

    void Start()
    {
        img = GameObject.Find("Gomi").GetComponent<RawImage>();
        //1～9の画像を読み込む
        read_img(9);
    }

    //リソースから表示させたい画像を指定した個数だけ読み込む
    public void read_img(int n)
    {
        Texture tmp;
        for(int i=1; i < n+1; i++)
        {
            tmp = Resources.Load("img/" + i) as Texture;
            texture_list.Add(tmp);
        }
    }

    //ゴミの種類を変更
    public void GomiChange()
    {
        int random = Random.Range(1, texture_list.Count);
        img.texture = texture_list[random];
    }

    public void riverScroll()
    {
        //int random = Random.Range(1, texture_list.Count);
        //img.texture = texture_list[random];
        transform.Translate(speed, 0, 0);

    }

    public void riverChange()
    {
        //endPosまできたらmovePosに移動
        if(transform.position.x > endPos)
        {
            typing._score = typing._score - typing._fString.Length - 1;
        
            typing.ImageChange();
            typing.OutPut();
            transform.position = new Vector3(movePos, transform.position.y, 0);
        }
        else if(typing._aNum >= typing._aString.Length)
        {
            transform.position = new Vector3(movePos, transform.position.y, 0);
        }
    }
}
