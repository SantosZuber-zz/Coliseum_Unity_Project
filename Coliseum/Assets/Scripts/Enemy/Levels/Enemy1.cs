using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    [SerializeField] private GameObject mainGO;
    [SerializeField] Material Red;
    [SerializeField] Material Skin;
    private float animHittedDuration;
    private bool animHittedDurationRunning;
    private float timerMaterialChange;
    private bool timerMaterialChangeRunning;
    void Start()
    {
        Anim.SetBool("lowHealth", false);
        Anim.SetBool("death", false);
    }

    void Update()
    {
        CalcularDistancia();
        LookAtPlayer();
        MoveToPlayer();
        if (EnemyStats.health <= 20)
        {
            Anim.SetBool("lowHealth", true);
        }

        if (timerMaterialChangeRunning)
        {
            timerMaterialChange = timerMaterialChange + 1 * Time.deltaTime;
            if (timerMaterialChange >= 0.1f)
            {
                set_skinned_mat(0, Skin);
                timerMaterialChangeRunning = false;
            }
        }
        if (!timerMaterialChangeRunning)
        {
            timerMaterialChange = 0f;
        }


        if (animHittedDurationRunning)
        {
            animHittedDuration = animHittedDuration + 1f * Time.deltaTime;
            Anim.SetBool("punched", true);
            if (animHittedDuration >= 1)
            {
                animHittedDurationRunning = false;
            }
        }
        if (!animHittedDurationRunning)
        {
            Anim.SetBool("punched", false);
            animHittedDuration = 0f;
        }

        Death();
    }

    public override void RestarVida(int cantidad)
    {
        base.RestarVida(cantidad);
        set_skinned_mat(0, Red);
        timerMaterialChangeRunning = true;
        animHittedDurationRunning = true;
    }

    void set_skinned_mat(int Mat_Nr, Material Mat)
    {
        SkinnedMeshRenderer renderer = mainGO.gameObject.GetComponent<SkinnedMeshRenderer>();

        Material[] mats = renderer.materials;

        mats[Mat_Nr] = Mat;

        renderer.materials = mats;
    }
}
