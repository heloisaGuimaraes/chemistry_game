using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;





public class MoleculeAtlas : MonoBehaviour{
    
    [SerializeField]
    private SpriteAtlas atlas; 
    private SpriteRenderer myRenderer;

    private Rigidbody2D moleculeRB;//fisica do material
    private float velocity = -0.5f;
    
    private Transform moleculePosition;
    
    private float posX = 1.875f;

   

    


    void Start(){
        myRenderer = GetComponent <SpriteRenderer>();
        moleculeRB = GetComponent <Rigidbody2D>();

        moleculePosition = GetComponent <Transform>();
        

        changeSprite();
    } 

        
        void Update(){
            moleculeRB.velocity = new Vector2 (moleculeRB.velocity.x,velocity);
    }

    public void changeSprite(){
        int x = Random.Range (1, 38);
        myRenderer.sprite = atlas.GetSprite ("molecula_" + x);


    }
 

    public void moveLeft(){
        if (moleculePosition.position.x > -posX/2){
            moleculePosition.position = new Vector3 (moleculePosition.position.x - posX, moleculePosition.position.y, moleculePosition.position.z);
        }
    }
     public void moveRight(){
       if (moleculePosition.position.x < posX/2){
            moleculePosition.position = new Vector3 (moleculePosition.position.x + posX, moleculePosition.position.y, moleculePosition.position.z);
        }
    }

    
  


}
