## Multithreading - C#
> Thread: Execution path of a program. Each trhead has a unique flow of contro. Threads are important for high resource consuming programs which can be executed in different and independent threads each of these executing a a particular job.  
By nature, threads are lightweight processes which increases the efficiency of each CPU cyccle usage. 
We are used to write single threaded processes. However, with the use of Multithreading we can run more than one task at a time, resulting in faster execution and efficient resource consumption.
#### Thread Life Cycle
> The lifecycle of a thread starts with te isntantiation of the *System.Threading.Thread* class. This lifecycle ends when the thread completes execution or its terminated.
Different states during the lifecycle of a thread:
- Unstarted State: Instance of Thread has been created but stat method has not yet been called. 
- Ready State: In this state, the Thread is ready to run and is waiting for a CPU cycle to run.
- Not Runnable State: Threads can be no executable when:
  - Sleep method was called
  - Wait method was called
  - Has been blocked by I/O operations 
- Dead State: This state is achieved when the Thread completes execution or has been aborted.
####
####
####
####
####
####