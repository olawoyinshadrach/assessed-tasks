using System;
using System.Collections.Generic;
using ThemeParkProject.Model;
using ThemeParkProject.Forms;
using System.Linq;
using System.Text;

namespace ThemeParkProject.Algorithms{
    //the GuestQueue class shall enque and dequeue guets, count them, 
    //return the quest at the head of the queue using peek() and
    //return true/false if queue is full/empty
    
    public class GuestQueue{
        //the queue, with a definite size, implements a list as follows and contains Guest objects:
        private List<Guest> _queue;
        private int _size;
    //Constructor: the queue object shall have size queue attribute
    public GuestQueue(int size){
        _size = size;
        _queue = new List<Guest>();
    }

    //to count the number of uests in queue
    public int Count(){
        return _queue.Count;
    }

    //to test if list is full()
    public bool full(){
        return _size <= _queue.Count;
    }

    //to test if queue is empty
    public bool empty => _queue.Count == 0;

    //the Enqueue method takes a guest (of type Guest) as input and queue him up 
    //IF QUE IS NOT FULL
    public void Enqueue(Guest guest){
        if(full){
            throw new InvalidOperationException("Sorry, queue full");
        }else{
            _queue.Add(guest);
        }
    }

    //the Dequeue method check if QUEUE IS NOT EMPTY and return the first item on queue
    public Guest Dequeue(){
        if (empty){
            throw new InvalidOperationException("sorry, queue empty");
        }else{
            //remove the guest at the head of the queue
            return _queue.RemoveFirst();
        }
    }

    public bool ReverseKGuests(int k){
        //test if there are enough quests in the queue
        if(k > _queue.Count || k <= 0){
            return false;
        }
        //reverse the numver of guests stated
        List<Guest> reversedGuests = _queue.Take(k).Reverse();
        reversedGuests.ToList();
    
        //return the reversed guests into the queue
       for(int i=0; i<k;i++){
            _queue[i] = revGuests[i];
       }
       return true
    }

    //guest with most funds
    public GuestQueue FindhMostFund(){
        //test if list is empty
        if(empty){
            return null;
        }
        else{
            return _queue.OrderByDescending(
                i => i.GuestFund
            ).FirstOrDefault()
        }
    }

    public Guest Peek(){
        if(empty()){
            return null;
        }else{
            return _queue[0];
        }
    } 
}
}