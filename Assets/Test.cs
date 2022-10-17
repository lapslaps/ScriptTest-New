using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("�񕜖��@���������I�c��MP��" + this.mp);
        }
        else
        {
            Debug.Log("�񕜖��@�ɕK�v��MP������Ȃ��I");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        int[] array = {10, 50, 35, 30, 5};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("array��" + (i + 1) + "�Ԗڂ�" + array[i]);
        }
        
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log("array��" + (i + 1) + "�Ԗڂ�" + array[i]);
        }
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        for(int i = 0; i < 11; i ++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}