using System;
using System.Collections.Generic;
using ThemeParkProject.Model;
using System.Linq;
using System.Text;

namespace ThemeParkProject.Algorithm{
    //we shall implment the head and tail to ensures that 
    //enqueueing and dequeueing are implemented that the queue wraps around
    //at the end of the array.
    
    public class QueueCircular{
        private GuestQueue[] circularqueue;
        private int maxsize;
        private int count;
        private int head;
        private int tail;

        public QueueCircular(int size){
            count = 0;
            head = 0;
            tail = -1
            maxsize = size;
            circularqueue = new GuestQueue[size];
        }

        public bool CircularEnqueue(Guest guest){
            if(full()){
                return false;
            }
            tail += 1;
            tail = tail % maxsize;
            circularqueue[tail] = guest;
            count+=1;
            return true;
            }

        public Guest CircularDequeue(){
            if(empty()){
                return null;
            }

            Guest dequeuedGuest = circularqueue[head];
            circularqueue[head] = null;
            head += 1;
            head = head % maxsize;

            circularqueue[teil] = guest;
            count-=1

            return dequeuedGuest;
        }

        public CircularPeek(){
            if(empty()){
                return null;
            }else{
                return circularqueue[head]
            }
        }


        public int CircularCount(){
            return count;
        }

        public bool CircularFull(){
            if(count == maxsize){
                return true;
            }else{
                return false;
            }
        }

        public bool CircularEmpty(){
            if(count == 0){
                return true;
            }else{
                return false;
            }
        }



        public bool ReverseKCircular(int k){
            if(k <= 0 || count < k){
                return false
            }
            int startReverse = head;
            int endReverse = head+k-1;
            endReverse = endReverse % maxsize;

            int halfway = k/2;

            for(int counter = 0; counter < halfway; counter++){
                int begining = startReverse + counter;
                begining = begining % maxsize;

                int ending = ending + maxsize - counter;
                ending = ending % maxsize;

                Guest current = circularqueue[begining];
                circularqueue[begining] = circularqueue[ending];
                circularqueue[ending] = current;
            }
            return true;
        }

        public Guest FindMostFund(){
            if(!empty()){
                Guest guestWitMostFind = circularqueue[head];
                for(int counter = 1; counter < count; counter++){
                    int fundindex = head + counter;
                    fundindex = fundindex % maxsize;

                    if(circularqueue[fundindex].guestfund){
                        guestWitMostFind = circularqueue[fundindex];
                    }
                }
            }else{
                return null;
            }
            return guestWitMostFind;
    }
}
