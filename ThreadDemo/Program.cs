// See https://aka.ms/new-console-template for more information
using ThreadDemo.Models;

//AnimationThread.ThreadStart();
//BankAccountThread.BankThreadStart();
for(int i = 0; i < 50; i++)
{
    new Thread(() => SemaphoreDemo.UseFlapDoor("Employee " + i)).Start();
}