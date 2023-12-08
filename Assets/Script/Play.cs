using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public AudioClip[] audios;
    public AudioSource rep;

    void Start(){
        Reproducir();
    }

    public void Reproducir(){
        if((GlobalVariables.sujeto=="El niño")&&(GlobalVariables.verbo=="Come")){
            rep.clip=audios[0];
        }
        if((GlobalVariables.sujeto=="La niña")&&(GlobalVariables.verbo=="Come")){
            rep.clip=audios[1];
        }
        if((GlobalVariables.sujeto=="El niño")&&(GlobalVariables.verbo=="Corre")){
            rep.clip=audios[2];
        }
        if((GlobalVariables.sujeto=="La niña")&&(GlobalVariables.verbo=="Corre")){
            rep.clip=audios[3];
        }
        if((GlobalVariables.sujeto=="El niño")&&(GlobalVariables.verbo=="Bebe")){
            rep.clip=audios[4];
        }
        if((GlobalVariables.sujeto=="La niña")&&(GlobalVariables.verbo=="Bebe")){
            rep.clip=audios[5];
        }
        if((GlobalVariables.sujeto=="El niño")&&(GlobalVariables.complemento=="Casa")){
            rep.clip=audios[6];
        }
        if((GlobalVariables.sujeto=="La niña")&&(GlobalVariables.complemento=="Casa")){
            rep.clip=audios[7];
        }
        if((GlobalVariables.sujeto=="El niño")&&(GlobalVariables.complemento=="Escuela")){
            rep.clip=audios[8];
        }
        if((GlobalVariables.sujeto=="La niña")&&(GlobalVariables.complemento=="Escuela")){
            rep.clip=audios[9];
        }

        rep.Play();
    }
}
