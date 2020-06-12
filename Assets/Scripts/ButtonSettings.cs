using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonSettings : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
  
  
  [SerializeField]
  private GameObject molecule;
  [SerializeField]
  private string id;
  private Transform moleculePosition;
  private bool isPressing = false;


    void Start(){
        moleculePosition = molecule.GetComponent <Transform>();



    }

   

    void Update(){
        if (isPressing){
            if(id.Equals("Left")){
                moleculePosition.position = new Vector3 (-240, moleculePosition.position.y, moleculePosition.position.z);
            }else if (id.Equals("Right")){
                moleculePosition.position = new Vector3 (240, moleculePosition.position.y, moleculePosition.position.z);
            }else {
                moleculePosition.position = new Vector3 (moleculePosition.position.x, moleculePosition.position.y - 0.1f, moleculePosition.position.z);
            }
        }
        
        
    }


    public void OnPointerDown(PointerEventData eventData){
        isPressing = true;
    
     }
    public void OnPointerUp(PointerEventData eventData){
        isPressing = false;
     
     }
}
/*
    public void moveLeft(){
        //positions.position = new Vector3 (positions.position.x - 0.1f, positions.position.y, positions.position.z);
    }
     public void moveRight(){
       // positions.position = new Vector3 (positions.position.x + 0.1f, positions.position.y, positions.position.z);
    }

    public void moveDown(){
        //positions.position = new Vector3 (positions.position.x, positions.position.y - 0.1f, positions.position.z);
        
    }*/
