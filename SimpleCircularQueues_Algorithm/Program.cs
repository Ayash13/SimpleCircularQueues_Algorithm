﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircularQueues_Algorithm
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /*Innitialing the values of the variables REAR and FRONT to -1
             to indicate that the queue is initially empty. */
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*This statement checks for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /*The following statement checks whether the queue is empty. If the queue is empty,
             then the value of the REAR and FRONT variables is set to 0.*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            
        }
       
    }
    
}