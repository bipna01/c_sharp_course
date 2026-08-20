class Result
{
    public void Grade()
    {
        char grade;
        String name;
        int score;

       
        for(int student=1; student <= 4; student++)
        {
            Console.WriteLine($"Enter your name");
        name= Console.ReadLine();

            Console.WriteLine($"Enter your score");
            score=Convert.ToInt32(Console.ReadLine());


            if(score<=100 && score >=90) {
                grade='A';
            
        }
        else if (score>=89 && score>=80 )
            {
                grade='B';
            }

            else if(score>=79 && score >= 70)
            {
                grade='C';
            } 

        else if( score>=69 && score >= 60)
            {
                grade='D';
            }
            else
            {
                grade = 'E';
            }
           
                  
                Console.WriteLine($"Student Name:" + name);
                  Console.WriteLine($"Student Score: " + score);
                    Console.WriteLine($"Student Grade"+ grade);
               
        }


    }
}